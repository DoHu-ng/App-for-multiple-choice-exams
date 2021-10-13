namespace AppExam
{
    partial class FormQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuestion));
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRecAns = new System.Windows.Forms.TextBox();
            this.cbD = new System.Windows.Forms.CheckBox();
            this.cbC = new System.Windows.Forms.CheckBox();
            this.cbB = new System.Windows.Forms.CheckBox();
            this.cbA = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtCodeQ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMaDe = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewQuestion = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = true;
            this.btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(287, 621);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(124, 33);
            this.btnCreate.TabIndex = 49;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(48, 622);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 33);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(512, 622);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 33);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(287, 622);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 33);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtRecAns);
            this.panel2.Controls.Add(this.cbD);
            this.panel2.Controls.Add(this.cbC);
            this.panel2.Controls.Add(this.cbB);
            this.panel2.Controls.Add(this.cbA);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtD);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtC);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtB);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtA);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtQuestion);
            this.panel2.Controls.Add(this.txtCodeQ);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 291);
            this.panel2.TabIndex = 44;
            // 
            // txtRecAns
            // 
            this.txtRecAns.Location = new System.Drawing.Point(16, 221);
            this.txtRecAns.Name = "txtRecAns";
            this.txtRecAns.Size = new System.Drawing.Size(100, 22);
            this.txtRecAns.TabIndex = 21;
            // 
            // cbD
            // 
            this.cbD.AutoSize = true;
            this.cbD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbD.Location = new System.Drawing.Point(578, 254);
            this.cbD.Name = "cbD";
            this.cbD.Size = new System.Drawing.Size(46, 26);
            this.cbD.TabIndex = 20;
            this.cbD.Text = "D";
            this.cbD.UseVisualStyleBackColor = true;
            // 
            // cbC
            // 
            this.cbC.AutoSize = true;
            this.cbC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbC.Location = new System.Drawing.Point(458, 254);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(45, 26);
            this.cbC.TabIndex = 19;
            this.cbC.Text = "C";
            this.cbC.UseVisualStyleBackColor = true;
            // 
            // cbB
            // 
            this.cbB.AutoSize = true;
            this.cbB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbB.Location = new System.Drawing.Point(333, 254);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(45, 26);
            this.cbB.TabIndex = 18;
            this.cbB.Text = "B";
            this.cbB.UseVisualStyleBackColor = true;
            // 
            // cbA
            // 
            this.cbA.AutoSize = true;
            this.cbA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbA.Location = new System.Drawing.Point(194, 254);
            this.cbA.Name = "cbA";
            this.cbA.Size = new System.Drawing.Size(46, 26);
            this.cbA.TabIndex = 17;
            this.cbA.Text = "A";
            this.cbA.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Answer";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(194, 221);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(430, 22);
            this.txtD.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(159, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "D.";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(194, 193);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(430, 22);
            this.txtC.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(160, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "C.";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(194, 165);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(430, 22);
            this.txtB.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(161, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "B.";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(194, 137);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(430, 22);
            this.txtA.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "A.";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(194, 61);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(430, 70);
            this.txtQuestion.TabIndex = 7;
            // 
            // txtCodeQ
            // 
            this.txtCodeQ.Location = new System.Drawing.Point(194, 16);
            this.txtCodeQ.Name = "txtCodeQ";
            this.txtCodeQ.Size = new System.Drawing.Size(430, 22);
            this.txtCodeQ.TabIndex = 6;
            this.txtCodeQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeQ_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Question";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Code Question";
            // 
            // lbMaDe
            // 
            this.lbMaDe.AutoSize = true;
            this.lbMaDe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbMaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDe.Location = new System.Drawing.Point(210, 178);
            this.lbMaDe.Name = "lbMaDe";
            this.lbMaDe.Size = new System.Drawing.Size(136, 29);
            this.lbMaDe.TabIndex = 43;
            this.lbMaDe.Text = "Form Exam";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(28, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 164);
            this.panel1.TabIndex = 42;
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
            this.label2.Size = new System.Drawing.Size(321, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ứng dụng trắc nghiệm ";
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
            // listViewQuestion
            // 
            this.listViewQuestion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewQuestion.FullRowSelect = true;
            this.listViewQuestion.HideSelection = false;
            this.listViewQuestion.Location = new System.Drawing.Point(12, 509);
            this.listViewQuestion.Name = "listViewQuestion";
            this.listViewQuestion.Size = new System.Drawing.Size(652, 106);
            this.listViewQuestion.TabIndex = 50;
            this.listViewQuestion.UseCompatibleStateImageBehavior = false;
            this.listViewQuestion.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code Question";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Question And Answer";
            this.columnHeader2.Width = 495;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phạm Quốc Anh";
            // 
            // FormQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(676, 666);
            this.Controls.Add(this.listViewQuestion);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbMaDe);
            this.Controls.Add(this.panel1);
            this.Name = "FormQuestion";
            this.Text = "Ứng dụng thi trắc nghiệm";
            this.Load += new System.EventHandler(this.FormQuestion_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtRecAns;
        private System.Windows.Forms.CheckBox cbD;
        private System.Windows.Forms.CheckBox cbC;
        private System.Windows.Forms.CheckBox cbB;
        private System.Windows.Forms.CheckBox cbA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtCodeQ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMaDe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewQuestion;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
    }
}