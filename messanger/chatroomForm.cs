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
using System.IO;
using System.Threading;
 
namespace messanger
{
    public partial class chatroomForm : Form
    {
        delegate void AppendTextDelegate(Control ctrl, string s);
        AppendTextDelegate _textAppender;
        Socket mainSock;

        private Point mCurrentPosition = new Point(0, 0);
        LoginForm loginform;

        public chatroomForm()
        {
            InitializeComponent();
            //연결 소켓 생성
            mainSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
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
        private void ChatroomForm_Load(object sender, EventArgs e)
        {
            editbt.BackColor = Color.FromArgb(26, 177, 136);
            this.editbt.AutoSize = true;
            loginform = new LoginForm();
            loginform.ShowDialog();

            //로그인창이 닫히면 실행하는 부분 소켓열고, 연결하고
            if(loginform.Visible == false)
            {
                //서버 연결하기
                IPAddress ipaddress = IPAddress.Parse("192.168.10.103");
                IPEndPoint endPoint = new IPEndPoint(ipaddress, 5000);

                //연결하기
                mainSock.Connect(ipaddress, 5000);
                AsyncObject obj = new AsyncObject(4096);
                obj.WorkingSocket = mainSock;
                mainSock.BeginReceive(obj.Buffer, 0, obj.BufferSize, 0, DataReceived, obj);

            }
        }

        private void DataReceived(IAsyncResult ar)
        {
            // BeginReceive에서 추가적으로 넘어온 데이터를 AsyncObject 형식으로 변환한다.
            AsyncObject obj = (AsyncObject)ar.AsyncState;

            // 데이터 수신을 끝낸다.
            int received = obj.WorkingSocket.EndReceive(ar);

            // 받은 데이터가 없으면(연결끊어짐) 끝낸다.
            if (received <= 0)
            {
                obj.WorkingSocket.Close();
                return;
            }

            // 텍스트로 변환한다.
            string text = Encoding.UTF8.GetString(obj.Buffer);

            // 0x01 기준으로 짜른다.
            // tokens[0] - 보낸 사람 IP
            // tokens[1] - 보낸 메세지
            string[] tokens = text.Split('\x01');
            string ip = tokens[0];
            string msg = tokens[1];

            // 텍스트박스에 추가해준다.
            // 비동기식으로 작업하기 때문에 폼의 UI 스레드에서 작업을 해줘야 한다.
            // 따라서 대리자를 통해 처리한다.
            AppendText(fromtext, string.Format("[받음]{0}: {1}", ip, msg));

            // 클라이언트에선 데이터를 전달해줄 필요가 없으므로 바로 수신 대기한다.
            // 데이터를 받은 후엔 다시 버퍼를 비워주고 같은 방법으로 수신을 대기한다.
            obj.ClearBuffer();

            // 수신 대기
            obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }

        //닉네임 변경하는 부분
        private void Editbt_Click(object sender, EventArgs e)
        {
            
        }

        //종료하는 부분
        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //화면 움직이는 부분
        private void Header1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mCurrentPosition = new Point(-e.X, -e.Y);
        }
        private void Header1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (mCurrentPosition.X + e.X), this.Location.Y + (mCurrentPosition.Y + e.Y));
            }
        }

        private void Sendbt_Click(object sender, EventArgs e)
        {
            // 보낼 텍스트
            string tts = sendtextbox.Text.Trim();

            // 서버 ip 주소와 메세지를 담도록 만든다.
            IPEndPoint ip = (IPEndPoint)mainSock.LocalEndPoint;
            string addr = ip.Address.ToString();

            // 문자열을 utf8 형식의 바이트로 변환한다.
            byte[] bDts = Encoding.UTF8.GetBytes(addr + '\x01' + tts);

            // 서버에 전송한다.
            mainSock.Send(bDts);

            // 전송 완료 후 텍스트박스에 추가하고, 원래의 내용은 지운다.
            AppendText(fromtext, string.Format("[보냄]{0}: {1}", addr, tts));
            sendtextbox.Clear();
        }

        private void Sendtextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Sendbt_Click(sender, e);
            }
            
        }

        //텍스트 버튼
        private void Sendfilebt_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "텍스트(.txt)|*.txt";

        }

        //이미지 버튼
        private void Sendimagebt_Click(object sender, EventArgs e)
        {
            string imagefile = string.Empty;
            OpenFileDialog dia = new OpenFileDialog();
            dia.Multiselect = false;
            dia.Filter = "이미지(.png)|*.png";
            if(dia.ShowDialog() == DialogResult.OK)
            {
                imagefile = dia.FileName;
            }
            else if(dia.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            topicturebox.Image = Bitmap.FromFile(imagefile);
            topicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            byte[] recev = new byte[513];
            try
            {
                NetworkStream ns = mainSock.Getstream
            }
                    
        }
            
    }

}

