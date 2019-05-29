using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using messanger;
namespace server
{
    //서버 부분 입니다.
    public partial class Form1 : Form
    {
        delegate void AppendTextDelegate(Control ctrl, string s);
        AppendTextDelegate _textAppender;

        private Point mCurrentPosition = new Point(0, 0);
        Socket clientSocket; //접속한 클라이언트를 나타내는 소켓
        Socket mainSock;
        int portNum = 5000; //포트번호 3천번
        public byte[] Buffer;
        IPAddress thisaddress;
        IPEndPoint serverEP;



        public Form1()
        {
            InitializeComponent();
            //소켓생성
            mainSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _textAppender = new AppendTextDelegate(AppendText);

        }
        void AppendText(Control ctrl, string s)
        {
            if (ctrl.InvokeRequired)
                ctrl.Invoke(_textAppender, ctrl, s);
            else
            {
                string source = ctrl.Text;
                ctrl.Text = source + Environment.NewLine + s;
            }
        }

        //서버 실행 준비
        private void Form1_Load(object sender, EventArgs e)
        {
            //서버 아이피주소 값 가져오기
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress addr in host.AddressList)
            {
                if(addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    thisaddress = addr;
                    break;
                }
            }
            //주소가 없다면
            if (thisaddress == null)
                thisaddress = IPAddress.Loopback;
            serverIptext.Text = thisaddress.ToString();
        }
        //서버 접속
        private void ServerOpenbt_Click(object sender, EventArgs e)
        {
            //서버 열기 버튼을 클릭하면
            //소켓을열고 listen, send, receive를 다해야됨
            //바인딩해주고 포트번호
            serverEP = new IPEndPoint(thisaddress, 5000);
            //바인드
            mainSock.Bind(serverEP);
            //준비
            mainSock.Listen(10);
            mainSock.BeginAccept(AcceptCallback, null);

            Log("서버 오픈");
        }

        List<Socket> connectedClients = new List<Socket>();
        void AcceptCallback(IAsyncResult ar)
        {
            //클라이언트의 연결 요청을 수락
            Socket client = mainSock.EndAccept(ar);

            //또다른 클라이언트의 연결을 대기
            mainSock.BeginAccept(AcceptCallback, null);

            AsyncObject obj = new AsyncObject(4096);
            obj.WorkingSocket = client;

            //연결된 클라이언트 리스트에 추가
            connectedClients.Add(client);

            AppendText(logbox, string.Format($"IP : {client.RemoteEndPoint}가 접속했습니다."));

            //클라이언트의 데이터를 받음
            client.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);

        }
        //메시지 받는부분
        void DataReceived(IAsyncResult ar)
        {
            //BeginReceive에서 추가적으로 넘어온 데이터를 AsyncObject형식으로 변환
            AsyncObject obj = (AsyncObject)ar.AsyncState;

            //데이터 수신 끝
            int received = obj.WorkingSocket.EndReceive(ar);

            //받은 데이터가 없으면(연결 끊어짐) 끝낸다.
            if(received <= 0)
            {
                obj.WorkingSocket.Close();
                return;
            }

            //텍스트로 변환
            string text = Encoding.UTF8.GetString(obj.Buffer);

            //0x01 기준으로 짜른다.
            //token[0] - 보낸사람 IP
            //token[1] - 보낸 메시지
            string[] tokens = text.Split('\x01');
            string ip = tokens[0];
            string msg = tokens[1];

            //텍스트박스에 추가해준다
            //비동기식으로 작업하기 때문에 폼의 UI스레드에서 작업을해야함
            //대리자를 이용해 처리함
            AppendText(messagelog, string.Format($"[받음] {ip}: {msg}"));

            //for문을 이용해 "역순으로" 클라이언트에게 데이터를 보냄
            for(int i = connectedClients.Count -1; i>=0; i--)
            {
                Socket socket = connectedClients[i];
                if(socket != obj.WorkingSocket)
                {
                    try
                    {
                        socket.Send(obj.Buffer);
                    }catch
                    {
                        //오류 발생하면 전송취소후 리스트 삭제
                        try
                        {
                            socket.Dispose();
                        }
                        catch
                        {
                            connectedClients.RemoveAt(i);
                        }
                    }
                }
                
            }
            //데이터를 받은 후 다시 버퍼를 비워주고 수신대기
            obj.ClearBuffer();
            //수신대기
            obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);

        }

        private void Log(string msg)
        {
            //메시지 들어오면 로그창에 넣어줌
            logbox.Text += DateTime.Now.ToString()+ " " + msg + "\r\n";
        }

        //폼 종료
        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //폼이동
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mCurrentPosition = new Point(-e.X, -e.Y);
        }
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (mCurrentPosition.X + e.X), this.Location.Y + (mCurrentPosition.Y + e.Y));
            }
        }

        //메시지 보내는 부분
        private void OnSendData_Click(object sender, EventArgs e)
        {
            string tts = txtTTS.Text.Trim();
            byte[] bDts = Encoding.UTF8.GetBytes(thisaddress.ToString() + '\x01' + tts);

            //연결된 모든 클라이언트에게 전송한다.
            for(int i = connectedClients.Count - 1; i>=0; i--)
            {
                Socket socket = connectedClients[i];
                try { socket.Send(bDts); } catch {
                    //오류가 발생하면 전송 취소하고 리스트에서 삭제
                    try { socket.Dispose(); } catch { }
                    connectedClients.RemoveAt(i);
                }
            }
            AppendText(messagelog, string.Format($"[보냄] {thisaddress.ToString()} : {tts}"));
            txtTTS.Clear();
        }
    }
}
