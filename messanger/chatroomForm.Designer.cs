namespace messanger
{
    partial class chatroomForm
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
            this.header2 = new System.Windows.Forms.Panel();
            this.edittext = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editbt = new System.Windows.Forms.Button();
            this.header1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sendbt = new System.Windows.Forms.Button();
            this.sendfilebt = new System.Windows.Forms.Button();
            this.sendimagebt = new System.Windows.Forms.Button();
            this.sendtextbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fromtext = new System.Windows.Forms.TextBox();
            this.frompicturebox = new System.Windows.Forms.PictureBox();
            this.topicturebox = new System.Windows.Forms.PictureBox();
            this.header2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.header1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frompicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // header2
            // 
            this.header2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.header2.Controls.Add(this.header1);
            this.header2.Controls.Add(this.edittext);
            this.header2.Controls.Add(this.pictureBox1);
            this.header2.Controls.Add(this.editbt);
            this.header2.Dock = System.Windows.Forms.DockStyle.Top;
            this.header2.Location = new System.Drawing.Point(0, 0);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(1029, 83);
            this.header2.TabIndex = 21;
            // 
            // edittext
            // 
            this.edittext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.edittext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edittext.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edittext.ForeColor = System.Drawing.Color.White;
            this.edittext.Location = new System.Drawing.Point(3, 51);
            this.edittext.Name = "edittext";
            this.edittext.Size = new System.Drawing.Size(181, 26);
            this.edittext.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(3, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 5);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // editbt
            // 
            this.editbt.BackColor = System.Drawing.Color.Transparent;
            this.editbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.editbt.FlatAppearance.BorderSize = 0;
            this.editbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbt.Image = global::messanger.Properties.Resources.edit2;
            this.editbt.Location = new System.Drawing.Point(190, 41);
            this.editbt.Name = "editbt";
            this.editbt.Size = new System.Drawing.Size(55, 42);
            this.editbt.TabIndex = 2;
            this.editbt.UseVisualStyleBackColor = false;
            this.editbt.Click += new System.EventHandler(this.Editbt_Click);
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.header1.Controls.Add(this.button1);
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1029, 39);
            this.header1.TabIndex = 0;
            this.header1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header1_MouseDown);
            this.header1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header1_MouseMove);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(996, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.topicturebox);
            this.panel3.Controls.Add(this.frompicturebox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 464);
            this.panel3.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.sendbt);
            this.panel1.Controls.Add(this.sendfilebt);
            this.panel1.Controls.Add(this.sendimagebt);
            this.panel1.Controls.Add(this.sendtextbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 47);
            this.panel1.TabIndex = 0;
            // 
            // sendbt
            // 
            this.sendbt.BackColor = System.Drawing.Color.Transparent;
            this.sendbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sendbt.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.sendbt.FlatAppearance.BorderSize = 0;
            this.sendbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendbt.Image = global::messanger.Properties.Resources._11send_button1;
            this.sendbt.Location = new System.Drawing.Point(736, 7);
            this.sendbt.Name = "sendbt";
            this.sendbt.Size = new System.Drawing.Size(36, 33);
            this.sendbt.TabIndex = 8;
            this.sendbt.UseVisualStyleBackColor = false;
            this.sendbt.Click += new System.EventHandler(this.Sendbt_Click);
            // 
            // sendfilebt
            // 
            this.sendfilebt.BackColor = System.Drawing.Color.Transparent;
            this.sendfilebt.FlatAppearance.BorderSize = 0;
            this.sendfilebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendfilebt.Image = global::messanger.Properties.Resources._11clip__2_;
            this.sendfilebt.Location = new System.Drawing.Point(6, 4);
            this.sendfilebt.Name = "sendfilebt";
            this.sendfilebt.Size = new System.Drawing.Size(39, 38);
            this.sendfilebt.TabIndex = 6;
            this.sendfilebt.UseVisualStyleBackColor = false;
            this.sendfilebt.Click += new System.EventHandler(this.Sendfilebt_Click);
            // 
            // sendimagebt
            // 
            this.sendimagebt.BackColor = System.Drawing.Color.Transparent;
            this.sendimagebt.FlatAppearance.BorderSize = 0;
            this.sendimagebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendimagebt.Image = global::messanger.Properties.Resources._11picture__2_;
            this.sendimagebt.Location = new System.Drawing.Point(60, 2);
            this.sendimagebt.Name = "sendimagebt";
            this.sendimagebt.Size = new System.Drawing.Size(39, 40);
            this.sendimagebt.TabIndex = 9;
            this.sendimagebt.UseVisualStyleBackColor = false;
            this.sendimagebt.Click += new System.EventHandler(this.Sendimagebt_Click);
            // 
            // sendtextbox
            // 
            this.sendtextbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sendtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sendtextbox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendtextbox.Location = new System.Drawing.Point(114, 6);
            this.sendtextbox.Name = "sendtextbox";
            this.sendtextbox.Size = new System.Drawing.Size(602, 30);
            this.sendtextbox.TabIndex = 7;
            this.sendtextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sendtextbox_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.fromtext);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(245, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 464);
            this.panel2.TabIndex = 0;
            // 
            // fromtext
            // 
            this.fromtext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromtext.Location = new System.Drawing.Point(1, 1);
            this.fromtext.Multiline = true;
            this.fromtext.Name = "fromtext";
            this.fromtext.ReadOnly = true;
            this.fromtext.Size = new System.Drawing.Size(783, 417);
            this.fromtext.TabIndex = 10;
            // 
            // frompicturebox
            // 
            this.frompicturebox.Location = new System.Drawing.Point(0, 1);
            this.frompicturebox.Name = "frompicturebox";
            this.frompicturebox.Size = new System.Drawing.Size(245, 230);
            this.frompicturebox.TabIndex = 0;
            this.frompicturebox.TabStop = false;
            // 
            // topicturebox
            // 
            this.topicturebox.Location = new System.Drawing.Point(3, 231);
            this.topicturebox.Name = "topicturebox";
            this.topicturebox.Size = new System.Drawing.Size(245, 233);
            this.topicturebox.TabIndex = 1;
            this.topicturebox.TabStop = false;
            // 
            // chatroomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1029, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.header2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "chatroomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ChatroomForm_Load);
            this.header2.ResumeLayout(false);
            this.header2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.header1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frompicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header2;
        private System.Windows.Forms.Button editbt;
        private System.Windows.Forms.TextBox edittext;
        private System.Windows.Forms.Panel header1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sendbt;
        private System.Windows.Forms.Button sendfilebt;
        private System.Windows.Forms.Button sendimagebt;
        private System.Windows.Forms.TextBox sendtextbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox fromtext;
        private System.Windows.Forms.PictureBox frompicturebox;
        private System.Windows.Forms.PictureBox topicturebox;
    }
}

