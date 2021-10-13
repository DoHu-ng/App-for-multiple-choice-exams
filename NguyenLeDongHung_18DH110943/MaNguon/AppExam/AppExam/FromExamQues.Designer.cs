namespace AppExam
{
    partial class FromExamQues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromExamQues));
            this.listViewExamQues = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNameEQ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodeEQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCodeExam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewExamQues
            // 
            this.listViewExamQues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewExamQues.FullRowSelect = true;
            this.listViewExamQues.HideSelection = false;
            this.listViewExamQues.Location = new System.Drawing.Point(12, 407);
            this.listViewExamQues.Name = "listViewExamQues";
            this.listViewExamQues.Size = new System.Drawing.Size(652, 208);
            this.listViewExamQues.TabIndex = 49;
            this.listViewExamQues.UseCompatibleStateImageBehavior = false;
            this.listViewExamQues.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code Exam Question";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name Exam Question";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "By";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hour";
            this.columnHeader4.Width = 40;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Minute";
            this.columnHeader5.Width = 40;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Second";
            this.columnHeader6.Width = 40;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(48, 621);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 33);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(512, 621);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 33);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(268, 621);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 33);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSecond);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtMinute);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtHour);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtNameEQ);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtCodeEQ);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cboCodeExam);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 190);
            this.panel2.TabIndex = 45;
            // 
            // txtSecond
            // 
            this.txtSecond.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecond.Location = new System.Drawing.Point(584, 157);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(65, 30);
            this.txtSecond.TabIndex = 11;
            this.txtSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecond_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(456, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 22);
            this.label9.TabIndex = 10;
            this.label9.Text = "Second";
            // 
            // txtMinute
            // 
            this.txtMinute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute.Location = new System.Drawing.Point(361, 157);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(65, 30);
            this.txtMinute.TabIndex = 9;
            this.txtMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinute_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(233, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Minutes";
            // 
            // txtHour
            // 
            this.txtHour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour.Location = new System.Drawing.Point(139, 157);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(65, 30);
            this.txtHour.TabIndex = 7;
            this.txtHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHour_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hours";
            // 
            // txtNameEQ
            // 
            this.txtNameEQ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameEQ.Location = new System.Drawing.Point(159, 109);
            this.txtNameEQ.Name = "txtNameEQ";
            this.txtNameEQ.Size = new System.Drawing.Size(448, 30);
            this.txtNameEQ.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Name Exam Q";
            // 
            // txtCodeEQ
            // 
            this.txtCodeEQ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeEQ.Location = new System.Drawing.Point(159, 63);
            this.txtCodeEQ.Name = "txtCodeEQ";
            this.txtCodeEQ.Size = new System.Drawing.Size(449, 30);
            this.txtCodeEQ.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Code Exam Q";
            // 
            // cboCodeExam
            // 
            this.cboCodeExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodeExam.FormattingEnabled = true;
            this.cboCodeExam.Location = new System.Drawing.Point(159, 14);
            this.cboCodeExam.Name = "cboCodeExam";
            this.cboCodeExam.Size = new System.Drawing.Size(449, 30);
            this.cboCodeExam.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Code Exam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 44;
            this.label3.Text = "Form Exam";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(28, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 164);
            this.panel1.TabIndex = 43;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(161, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Phạm Quốc Anh";
            // 
            // FromExamQues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(676, 666);
            this.Controls.Add(this.listViewExamQues);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FromExamQues";
            this.Text = "Ứng dụng thi trắc nghiệm";
            this.Load += new System.EventHandler(this.FromExamQues_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewExamQues;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox cboCodeExam;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNameEQ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodeEQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label10;
    }
}