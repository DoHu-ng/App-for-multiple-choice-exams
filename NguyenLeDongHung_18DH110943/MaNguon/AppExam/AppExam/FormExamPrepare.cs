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
    public partial class FormExamPrepare : Form
    {
        public FormExamPrepare()
        {
            InitializeComponent();
            LoadingData();
        }

        private void LoadingData()
        {
            Program.input = "EPL" + "|";
            //MessageBox.Show(Program.input);
            Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
            Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);

            int recv = Program.server.Receive(Program.dataRec);
            MessageBox.Show(Encoding.ASCII.GetString(Program.dataRec, 0, recv));

            string arrExam = Encoding.ASCII.GetString(Program.dataRec, 0, recv);            
            if (String.IsNullOrEmpty(arrExam))
            {
                return;
            }
            else
            {
                string[] listExam = arrExam.Split('~');

                for (int i = 0; i < listExam.Length - 1; i++)
                {
                    string[] listExamP = listExam[i].Split('|');
                    //foreach (var item2 in listExamP)
                    //{
                    //    MessageBox.Show(item2);
                    //}
                    AddToListView(listExamP[1], listExamP[2]);
                }
            }

            //foreach (var item in listExam)
            //{
            //    string[] listExamP = item.Split('|');
            //    foreach (var item2 in listExamP)
            //    {
            //        MessageBox.Show(item2);
            //    }
            //    AddToListView(listExamP[1], listExamP[2]);
            //}

        }

        private void AddToListView(string codeE, string nameE)
        {
            ListViewItem item = new ListViewItem(codeE);
            item.SubItems.Add(nameE);
            listViewExam.Items.Add(item);            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string codeE = "CODE"+txtCodeExam.Text;
            string nameE = txtNameExam.Text;

            if (String.IsNullOrEmpty(codeE)||String.IsNullOrEmpty(nameE))
            {
                MessageBox.Show("Code Exam hoặc Name Exam không được để trống");
                return;
            }
            else
            {
                Program.input = "EPA" + "|" + codeE.Trim() + "|" + nameE.Trim() + "|";
                MessageBox.Show(Program.input);
                Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
                Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);

                int recv = Program.server.Receive(Program.dataRec);
                MessageBox.Show(Encoding.ASCII.GetString(Program.dataRec, 0, recv));

                string test = "Exam Prepare " + codeE + "da ton tai." + " Khong the tao";

                if (Encoding.ASCII.GetString(Program.dataRec, 0, recv) != test)
                {
                    ListViewItem item = new ListViewItem(codeE);
                    item.SubItems.Add(nameE);
                    listViewExam.Items.Add(item);                    
                    txtCodeExam.Focus();
                }
                txtCodeExam.Clear();
                txtNameExam.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string codeE = txtCodeExam.Text;
            string nameE = txtNameExam.Text;
            if (listViewExam.Items.Count > 0)
            {
                Program.input = "EPD" + "|" + listViewExam.SelectedItems[0].Text.Trim() + "|";
                MessageBox.Show(Program.input);
                Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
                Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);

                int recv = Program.server.Receive(Program.dataRec);
                MessageBox.Show(Encoding.ASCII.GetString(Program.dataRec, 0, recv));

                listViewExam.Items.Remove(listViewExam.SelectedItems[0]);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain form = new FormMain();
            form.ShowDialog();
        }

        private void ExamPrepare_Load(object sender, EventArgs e)
        {

        }

        private void listViewExam_DoubleClick(object sender, EventArgs e)
        {
            if (listViewExam.Items.Count > 0)
            {
                Program.CodeExam = listViewExam.SelectedItems[0].Text;
                if (Program.CodeExam != "")
                {
                    this.Hide();
                    FormQuestion form = new FormQuestion();
                    form.ShowDialog();
                }
            }
        }

        private void txtCodeExam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
