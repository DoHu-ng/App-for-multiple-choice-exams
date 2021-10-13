using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExam
{
    public partial class FormPrepareThi : Form
    {
        public FormPrepareThi()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain form = new FormMain();
            form.ShowDialog();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodeExamQ.Text)|| String.IsNullOrEmpty(txtStudentName.Text)|| String.IsNullOrEmpty(txtIdenCode.Text))
            {
                MessageBox.Show("Không được để trống bất kỳ trường nào !!!");
                return;
            }
            Program.CodeExamQ = txtCodeExamQ.Text;
            Program.studentName = txtStudentName.Text;
            Program.idCode = txtIdenCode.Text;

            Program.input = "PT" + "|" + Program.CodeExamQ.Trim();
            MessageBox.Show(Program.input);
            Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
            Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);

            int recv = Program.server.Receive(Program.dataRec);
            MessageBox.Show(Encoding.ASCII.GetString(Program.dataRec, 0, recv));
            string messRec = Encoding.ASCII.GetString(Program.dataRec, 0, recv);

            string[] dsRec = messRec.Split('|');

            if (dsRec[0]=="OK")
            {
                Program.hour = int.Parse(dsRec[1]);
                Program.minute = int.Parse(dsRec[2]);
                Program.second = int.Parse(dsRec[3]);
                Program.NameExamQ = dsRec[4];
                this.Hide();
                FormThi form = new FormThi();
                form.ShowDialog();                
            }
            else
            {
                MessageBox.Show("Code Exam Q không tồn tại. Vui lòng kiểm tra lại code");
                txtCodeExamQ.Clear();
            }            
        }

        private void FormPrepareThi_Load(object sender, EventArgs e)
        {

        }
    }
}
