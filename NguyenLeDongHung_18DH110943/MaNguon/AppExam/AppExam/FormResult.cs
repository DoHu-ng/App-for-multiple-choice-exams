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
    public partial class FormResult : Form
    {
        public FormResult()
        {
            InitializeComponent();
        }

        private void FormResult_Load(object sender, EventArgs e)
        {
            LoadingData();            
        }

        private void LoadingData()
        {
            Program.input = "RSL" + "|";
            //MessageBox.Show(Program.input);
            Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
            Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);

            int recv = Program.server.Receive(Program.dataRec);
            MessageBox.Show(Encoding.ASCII.GetString(Program.dataRec, 0, recv));

            string arrResult = Encoding.ASCII.GetString(Program.dataRec, 0, recv);
            if (String.IsNullOrEmpty(arrResult) || arrResult=="Null")
            {
                return;
            }
            else
            {
                string[] listResult = arrResult.Split('~');

                for (int i = 0; i < listResult.Length - 1; i++)
                {
                    string[] listResultM = listResult[i].Split('|');
                    
                    AddToListView(listResultM[3], listResultM[4], listResultM[2], listResultM[1], listResultM[5]);
                }
            }
        }

        private void AddToListView(string studentName, string idCode, string examName, string dateTime, string mark)
        {
            ListViewItem item = new ListViewItem(studentName);
            item.SubItems.Add(idCode);
            item.SubItems.Add(examName);
            item.SubItems.Add(dateTime);
            item.SubItems.Add(mark);
            
            listViewResult.Items.Add(item);
        }

        //private void RemoveAllItem()
        //{
        //    for (int i = listViewResult.Items.Count - 1; i >= 0; i--)
        //    {
        //        if (listViewResult.Items[i].Selected)
        //        {
        //            listViewResult.Items[i].Remove();
        //        }
        //    }
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain form = new FormMain();
            form.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keySearch = txtSearch.Text;
            if (keySearch!="")
            {
                Program.input = "RSS" + "|" + keySearch.Trim();
                //MessageBox.Show(Program.input);
                Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
                Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);

                int recv = Program.server.Receive(Program.dataRec);
                MessageBox.Show(Encoding.ASCII.GetString(Program.dataRec, 0, recv));

                string arrResult = Encoding.ASCII.GetString(Program.dataRec, 0, recv);
                if (String.IsNullOrEmpty(arrResult) || arrResult == "Null")
                {
                    MessageBox.Show("Không tìm thấy đối tượng phù hợp");
                    listViewResult.Items.Clear();
                }
                else
                {
                    listViewResult.Items.Clear();
                    string[] listResult = arrResult.Split('~');

                    for (int i = 0; i < listResult.Length - 1; i++)
                    {
                        string[] listResultM = listResult[i].Split('|');

                        AddToListView(listResultM[3], listResultM[4], listResultM[2], listResultM[1], listResultM[5]);
                    }
                }
            }
            else
            {
                listViewResult.Items.Clear();
                LoadingData();
            }
            txtSearch.Clear();
        }
    }
}
