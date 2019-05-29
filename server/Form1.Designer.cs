namespace server
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.serverOpenbt = new System.Windows.Forms.Button();
            this.serverIptext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logbox = new System.Windows.Forms.TextBox();
            this.messagelog = new System.Windows.Forms.TextBox();
            this.txtTTS = new System.Windows.Forms.TextBox();
            this.OnSendData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(27, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log History";
            // 
            // serverOpenbt
            // 
            this.serverOpenbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.serverOpenbt.FlatAppearance.BorderSize = 0;
            this.serverOpenbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverOpenbt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverOpenbt.ForeColor = System.Drawing.Color.White;
            this.serverOpenbt.Location = new System.Drawing.Point(502, 63);
            this.serverOpenbt.Name = "serverOpenbt";
            this.serverOpenbt.Size = new System.Drawing.Size(123, 28);
            this.serverOpenbt.TabIndex = 2;
            this.serverOpenbt.Text = "Server Open";
            this.serverOpenbt.UseVisualStyleBackColor = false;
            this.serverOpenbt.Click += new System.EventHandler(this.ServerOpenbt_Click);
            // 
            // serverIptext
            // 
            this.serverIptext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.serverIptext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverIptext.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverIptext.ForeColor = System.Drawing.Color.Silver;
            this.serverIptext.Location = new System.Drawing.Point(30, 63);
            this.serverIptext.Name = "serverIptext";
            this.serverIptext.ReadOnly = true;
            this.serverIptext.Size = new System.Drawing.Size(466, 28);
            this.serverIptext.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server IP Address";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(611, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 30);
            this.panel1.TabIndex = 21;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // logbox
            // 
            this.logbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.logbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logbox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.logbox.ForeColor = System.Drawing.Color.Silver;
            this.logbox.Location = new System.Drawing.Point(26, 277);
            this.logbox.Multiline = true;
            this.logbox.Name = "logbox";
            this.logbox.Size = new System.Drawing.Size(595, 111);
            this.logbox.TabIndex = 22;
            // 
            // messagelog
            // 
            this.messagelog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.messagelog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messagelog.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.messagelog.ForeColor = System.Drawing.Color.Silver;
            this.messagelog.Location = new System.Drawing.Point(26, 128);
            this.messagelog.Multiline = true;
            this.messagelog.Name = "messagelog";
            this.messagelog.Size = new System.Drawing.Size(595, 143);
            this.messagelog.TabIndex = 23;
            // 
            // txtTTS
            // 
            this.txtTTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtTTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTTS.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtTTS.ForeColor = System.Drawing.Color.Silver;
            this.txtTTS.Location = new System.Drawing.Point(30, 394);
            this.txtTTS.Multiline = true;
            this.txtTTS.Name = "txtTTS";
            this.txtTTS.Size = new System.Drawing.Size(466, 28);
            this.txtTTS.TabIndex = 24;
            // 
            // OnSendData
            // 
            this.OnSendData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.OnSendData.FlatAppearance.BorderSize = 0;
            this.OnSendData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OnSendData.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnSendData.ForeColor = System.Drawing.Color.White;
            this.OnSendData.Location = new System.Drawing.Point(498, 394);
            this.OnSendData.Name = "OnSendData";
            this.OnSendData.Size = new System.Drawing.Size(123, 28);
            this.OnSendData.TabIndex = 25;
            this.OnSendData.Text = "Send";
            this.OnSendData.UseVisualStyleBackColor = false;
            this.OnSendData.Click += new System.EventHandler(this.OnSendData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.OnSendData);
            this.Controls.Add(this.txtTTS);
            this.Controls.Add(this.messagelog);
            this.Controls.Add(this.logbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverIptext);
            this.Controls.Add(this.serverOpenbt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button serverOpenbt;
        private System.Windows.Forms.TextBox serverIptext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox logbox;
        private System.Windows.Forms.TextBox messagelog;
        private System.Windows.Forms.TextBox txtTTS;
        private System.Windows.Forms.Button OnSendData;
    }
}

