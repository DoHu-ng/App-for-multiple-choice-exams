namespace AppExam
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lbScreen = new System.Windows.Forms.Label();
            this.btnLogin1 = new System.Windows.Forms.Button();
            this.btnLogin2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRegis = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStudent = new System.Windows.Forms.Button();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtAuThenMa = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbScreen
            // 
            this.lbScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbScreen.Font = new System.Drawing.Font("Times New Roman", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScreen.Location = new System.Drawing.Point(-1, 0);
            this.lbScreen.Name = "lbScreen";
            this.lbScreen.Size = new System.Drawing.Size(677, 665);
            this.lbScreen.TabIndex = 30;
            this.lbScreen.Text = "20";
            this.lbScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbScreen.Visible = false;
            // 
            // btnLogin1
            // 
            this.btnLogin1.AutoSize = true;
            this.btnLogin1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin1.Location = new System.Drawing.Point(276, 620);
            this.btnLogin1.Name = "btnLogin1";
            this.btnLogin1.Size = new System.Drawing.Size(124, 33);
            this.btnLogin1.TabIndex = 27;
            this.btnLogin1.Text = "Login";
            this.btnLogin1.UseVisualStyleBackColor = false;
            this.btnLogin1.Click += new System.EventHandler(this.btnLogin1_Click);
            // 
            // btnLogin2
            // 
            this.btnLogin2.AutoSize = true;
            this.btnLogin2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin2.Location = new System.Drawing.Point(276, 620);
            this.btnLogin2.Name = "btnLogin2";
            this.btnLogin2.Size = new System.Drawing.Size(124, 33);
            this.btnLogin2.TabIndex = 29;
            this.btnLogin2.Text = "Login";
            this.btnLogin2.UseVisualStyleBackColor = false;
            this.btnLogin2.Visible = false;
            this.btnLogin2.Click += new System.EventHandler(this.btnLogin2_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(540, 620);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 33);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRegis
            // 
            this.btnRegis.AutoSize = true;
            this.btnRegis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegis.Location = new System.Drawing.Point(12, 620);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(124, 33);
            this.btnRegis.TabIndex = 26;
            this.btnRegis.Text = "Registration";
            this.btnRegis.UseVisualStyleBackColor = false;
            this.btnRegis.Click += new System.EventHandler(this.btnRegis_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnStudent);
            this.panel2.Controls.Add(this.txtMa);
            this.panel2.Controls.Add(this.txtAuThenMa);
            this.panel2.Controls.Add(this.lbID);
            this.panel2.Controls.Add(this.cbShow);
            this.panel2.Controls.Add(this.txtHash);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 371);
            this.panel2.TabIndex = 25;
            // 
            // btnStudent
            // 
            this.btnStudent.AutoSize = true;
            this.btnStudent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Location = new System.Drawing.Point(264, 335);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(124, 33);
            this.btnStudent.TabIndex = 31;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(377, 273);
            this.txtMa.Multiline = true;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(223, 32);
            this.txtMa.TabIndex = 12;
            this.txtMa.Visible = false;
            // 
            // txtAuThenMa
            // 
            this.txtAuThenMa.Location = new System.Drawing.Point(122, 273);
            this.txtAuThenMa.Multiline = true;
            this.txtAuThenMa.Name = "txtAuThenMa";
            this.txtAuThenMa.Size = new System.Drawing.Size(223, 32);
            this.txtAuThenMa.TabIndex = 11;
            this.txtAuThenMa.Visible = false;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(14, 273);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(45, 32);
            this.lbID.TabIndex = 10;
            this.lbID.Text = "ID";
            this.lbID.Visible = false;
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.Location = new System.Drawing.Point(536, 83);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(64, 21);
            this.cbShow.TabIndex = 9;
            this.cbShow.Text = "Show";
            this.cbShow.UseVisualStyleBackColor = true;
            this.cbShow.CheckedChanged += new System.EventHandler(this.cbShow_CheckedChanged);
            // 
            // txtHash
            // 
            this.txtHash.Enabled = false;
            this.txtHash.Location = new System.Drawing.Point(16, 123);
            this.txtHash.Multiline = true;
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(584, 95);
            this.txtHash.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(122, 80);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(408, 22);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(122, 16);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(408, 22);
            this.txtUsername.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Login Form";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(32, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 164);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sinh viên: Nguyễn Lê Đông Hưng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ứng dụng trắc nghiệm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::AppExam.Properties.Resources.HUFLIT_logo;
            this.pictureBox1.Location = new System.Drawing.Point(442, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phạm Quốc Anh";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(676, 666);
            this.Controls.Add(this.lbScreen);
            this.Controls.Add(this.btnLogin1);
            this.Controls.Add(this.btnLogin2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegis);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLogin";
            this.Text = "Ứng dụng thi trắc nghiệm";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbScreen;
        private System.Windows.Forms.Button btnLogin1;
        private System.Windows.Forms.Button btnLogin2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRegis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtAuThenMa;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.CheckBox cbShow;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Label label5;
    }
}

