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
    public partial class FromExamQues : Form
    {
        public FromExamQues()
        {
            InitializeComponent();
        }

        private void FromExamQues_Load(object sender, EventArgs e)
        {
            LoadingData();
            LoadingData2();
        }

        private void LoadingData()
        {
            Program.input = "EQsL" + "|";
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
                cboCodeExam.DataSource = listExam;                
            }          

        }

        private void LoadingData2()
        {
            Program.input = "EQsL2" + "|";
            //MessageBox.Show(Program.input);
            Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
            Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);

            int recv = Program.server.Receive(Program.dataRec);
            MessageBox.Show(Encoding.ASCII.GetString(Program.dataRec, 0, recv));

            string arrExamQ = Encoding.ASCII.GetString(Program.dataRec, 0, recv);
            if (String.IsNullOrEmpty(arrExamQ))
            {
                return;
            }
            else
            {
                string[] listExamQ = arrExamQ.Split('~');

                for (int i = 0; i < listExamQ.Length - 1; i++)
                {
                    string[] listExamQQ = listExamQ[i].Split('|');
                    //foreach (var item2 in listExamP)
                    //{
                    //    MessageBox.Show(item2);
                    //}
                    AddToListView(listExamQQ[1], listExamQQ[2], listExamQQ[3], listExamQQ[4], listExamQQ[5], listExamQQ[6]);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Program.CodeExam = cboCodeExam.Text;

            string codeEQ = txtCodeEQ.Text;
            string nameEQ = txtNameEQ.Text;
            string Hour = txtHour.Text;
            string Minute = txtMinute.Text;
            string Second = txtSecond.Text;

            Program.CodeExamQ = txtCodeEQ.Text;
            Program.NameExamQ = txtNameEQ.Text;

            if (String.IsNullOrEmpty(codeEQ) || String.IsNullOrEmpty(nameEQ))
            {
                MessageBox.Show("Code Exam Q hoặc Name Exam Q không được để trống");
                return;
            }
            else if (String.IsNullOrEmpty(Hour) || String.IsNullOrEmpty(Minute) || String.IsNullOrEmpty(Second))
            {
                MessageBox.Show("Thời gian thi không được để trống");
                return;
            }
            else
            {
                Program.input = "EQsA" + "|" + codeEQ.Trim() + "|" + nameEQ.Trim() + "|" +Program.userLogin+"|"+Hour.Trim()+"|"+Minute.Trim()+"|"+Second.Trim();
                MessageBox.Show(Program.input);
                Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
                Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);

                int recv = Program.server.Receive(Program.dataRec);
                MessageBox.Show(Encoding.ASCII.GetString(Program.dataRec, 0, recv));                

                if (Encoding.ASCII.GetString(Program.dataRec, 0, recv) != "Null")
                {
                    AddToListView(codeEQ, nameEQ, Program.userLogin, Hour, Minute, Second);
                    txtCodeEQ.Clear();
                    txtNameEQ.Clear();
                    txtHour.Clear();
                    txtMinute.Clear();
                    txtSecond.Clear();
                    this.Hide();
                    FormExamQuestion form = new FormExamQuestion();
                    form.ShowDialog();
                }
                                                
            }                                
        }

        private void AddToListView(string codeEQ, string nameEQ, string userLogin, string Hour, string Minute, string Sencond)
        {
            ListViewItem item = new ListViewItem(codeEQ);
            item.SubItems.Add(nameEQ);
            item.SubItems.Add(userLogin);
            item.SubItems.Add(Hour);
            item.SubItems.Add(Minute);
            item.SubItems.Add(Sencond);
            listViewExamQues.Items.Add(item);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain form = new FormMain();
            form.ShowDialog();
        }

        private void txtHour_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMinute_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSecond_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {            
            if (listViewExamQues.Items.Count > 0)
            {
                Program.input = "EQsD" + "|" + listViewExamQues.SelectedItems[0].Text.Trim();
                MessageBox.Show(Program.input);
                Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
                Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);

                int recv = Program.server.Receive(Program.dataRec);
                MessageBox.Show(Encoding.ASCII.GetString(Program.dataRec, 0, recv));

                listViewExamQues.Items.Remove(listViewExamQues.SelectedItems[0]);
            }
        }
    }
}
