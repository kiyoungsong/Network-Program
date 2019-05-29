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
using System.IO;
using System.Net.Sockets;

namespace messanger
{

    public partial class LoginForm : Form
    {
        private Point mCurrentPosition = new Point(0, 0);

        public LoginForm()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }

        }

        //위쪽 회원가입 버튼 누르면 나오는 이벤트
        private void SignUpbt_Click(object sender, EventArgs e)
        {
            if (slideA.Left == 474)
            {
                slideB.Visible = false;
                slideB.Left = 474;

                slideA.Visible = false;
                slideA.Left = 32;
                slideA.Visible = true;

                pictureBox1.Left = signUpbt.Left;
                pictureBox1.Width = signUpbt.Width;
            }

        }

        //위쪽 로그인 버튼 누르면 나오는 이벤트
        private void SignInbt_Click(object sender, EventArgs e)
        {
            //버튼 UI구현 부분
            if (slideB.Left == 474)
            {
                slideA.Visible = false;
                slideA.Left = 474;

                slideB.Visible = false;
                slideB.Left = 32;
                slideB.Visible = true;

                pictureBox1.Left = signInbt.Left;
                pictureBox1.Width = signInbt.Width;

            }

        }

        //로그인 창 Sign in 버튼 누르면 나오는 이벤트
        private void Signinfinalbt_Click(object sender, EventArgs e)
        {
            //로그인창이 닫히면서 메인폼인 채팅창이 나오면서 서버와 연결되야됨
            this.Close();
        }

        //종료버튼 누르면 나오는 이벤트
        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //윈도우창 움직이는 것들 2개
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
    }
}
