using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExam
{
    public partial class FormExamQuestion : Form
    {
        static bool exitForm = false;
        public FormExamQuestion()
        {
            InitializeComponent();
        }

        private void FormExamQuestion_Load(object sender, EventArgs e)
        {
            txtBy.Text = Program.userLogin;
            txtCodeExamQ.Text = Program.CodeExamQ;
            txtNameExamQ.Text = Program.NameExamQ;
            LoadingData();
            if (exitForm==true)
            {
                this.Hide();
                FromExamQues form = new FromExamQues();
                form.ShowDialog();
            }
            exitForm = false;
        }

        private void LoadingData()
        {
            Program.input = "EQL" + "|" + Program.CodeExam.Trim();
            MessageBox.Show(Program.input);
            Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
            Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);

            int recv = Program.server.Receive(Program.dataRec);
            MessageBox.Show(Encoding.ASCII.GetString(Program.dataRec, 0, recv));
            string messRec = Encoding.ASCII.GetString(Program.dataRec, 0, recv);

            if (messRec == "Null")
            {
                MessageBox.Show("Bộ đề này trống nên không thể tạo đề thi");
                exitForm = true;
                return;
            }                      
            else
            {
                exitForm = false;
                string[] listExam = messRec.Split('~');

                for (int i = 0; i < listExam.Length - 1; i++)
                {
                    string[] listExamP = listExam[i].Split('|');                    
                    AddToListView1(listExamP[0], listExamP[1]);
                }
            }          
        }

        private void AddToListView1(string codeQ, string qAA)
        {
            ListViewItem item = new ListViewItem(codeQ);
            item.SubItems.Add(qAA);
            listView1.Items.Add(item);
        }
        private void AddToListView2(string codeQ, string qAA)
        {
            ListViewItem item = new ListViewItem(codeQ);
            item.SubItems.Add(qAA);
            listView2.Items.Add(item);
        }
        private void RemoveFromListView1()
        {
            if (listView1.Items.Count > 0)
            {              
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }
        private void RemoveFromListView2()
        {
            if (listView2.Items.Count > 0)
            {
                listView2.Items.Remove(listView2.SelectedItems[0]);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FromExamQues form = new FromExamQues();
            form.ShowDialog();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtAnswer.Text = "";

            if (listView1.Items.Count > 0)
            {
                string chuoi;
                ListViewItem lvi = listView1.SelectedItems[0];
                chuoi = lvi.SubItems[1].Text;
                chuoi = decrypt_aes(chuoi);
                
                string[] dsQuestion = chuoi.Split('|');

                string[] dsAnswer = dsQuestion[5].Split('$');

                txtQuestion.Text = dsQuestion[0];
                txtA.Text = dsQuestion[1];
                txtB.Text = dsQuestion[2];
                txtC.Text = dsQuestion[3];
                txtD.Text = dsQuestion[4];
                foreach (var item in dsAnswer)
                {
                    if (item == "A" || item == "B" || item == "C" || item == "D")
                    {
                        txtAnswer.Text += item;
                    }                    
                }
            }
        }

        private string decrypt_aes(string message)
        {
            string s = "ABCDEFGHABCDEFGH";
            char[] kytu = s.ToCharArray();
            byte[] key = new byte[kytu.Length];
            byte[] iv = new byte[kytu.Length];
            for (int i = 0; i < kytu.Length; i++)
            {
                key[i] = (byte)(kytu[i]);
            }
            iv = key;
            int keysize = 128;
            int blocksize = 128;
            int ciphermode = 1;
            int padmod = 2;
            string x = aesDecryt(message, key, iv, blocksize, keysize, ciphermode, padmod);
            x = ConvertHexToString(x);
            return x;
        }

        private string ConvertHexToString(string hex)
        {
            string chuoi = "";
            for (int i = 0; i < hex.Length / 2; i++)
            {
                chuoi += (char)Convert.ToInt32(hex.Substring(2 * i, 2), 16);
            }

            return chuoi;
        }

        private string aesDecryt(string ciphertext, byte[] key, byte[] iv, int blocksize, int keysize, int ciphermod, int padmod)
        {
            string plaintext = "";
            SymmetricAlgorithm x = SymmetricAlgorithm.Create("Rijndael");
            x.BlockSize = blocksize;
            x.KeySize = keysize;
            x.Key = key;
            x.IV = iv;
            x.Padding = PaddingMode.Zeros;
            x.Mode = CipherMode.CBC;
            ICryptoTransform xcrypt = x.CreateDecryptor();
            MemoryStream xmemstream = new MemoryStream();
            CryptoStream xstream = new CryptoStream(xmemstream, xcrypt, CryptoStreamMode.Write);
            Encoding encoding = Encoding.Unicode;
            byte[] cipher = new byte[ciphertext.Length / 2];
            string[] cip = new string[ciphertext.Length / 2];
            int so = 0;
            for (int i = 0; i < cipher.Length; i++)
            {
                cip[i] = ciphertext.Substring(i * 2, 2);
                so = Convert.ToInt32(cip[i], 16);
                cipher[i] = (byte)so;
            }
            xstream.Write(cipher, 0, cipher.Length);
            xstream.Close();
            byte[] plain = xmemstream.ToArray();
            string hex = "";
            for (int i = 0; i < plain.Length; i++)
            {
                hex = Convert.ToString(plain[i], 16);

                if (hex.Length == 1)
                {
                    hex = "0" + hex;
                }
                plaintext += hex;
            }
            return plaintext;
        }       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem lvi = listView1.SelectedItems[0];

                string code = lvi.SubItems[0].Text;
                string content = lvi.SubItems[1].Text;

                string codeEQ = txtCodeExamQ.Text;

                Program.input = "EQA" + "|" + codeEQ.Trim() + "|" + code.Trim() + "|" + content.Trim();
                MessageBox.Show(Program.input);
                Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
                Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);

                int recv = Program.server.Receive(Program.dataRec);
                MessageBox.Show(Encoding.ASCII.GetString(Program.dataRec, 0, recv));

                AddToListView2(code, content);
                RemoveFromListView1();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hãy chọn câu hỏi ở List View 1");                
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem lvi = listView2.SelectedItems[0];

                string code = lvi.SubItems[0].Text;
                string content = lvi.SubItems[1].Text;

                string codeEQ = txtCodeExamQ.Text;

                if (listView2.Items.Count > 0)
                {
                    Program.input = "EQD" + "|" + codeEQ.Trim() + "|" + code.Trim();
                    MessageBox.Show(Program.input);
                    Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
                    Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);

                    int recv = Program.server.Receive(Program.dataRec);
                    MessageBox.Show(Encoding.ASCII.GetString(Program.dataRec, 0, recv));

                    RemoveFromListView2();
                    AddToListView1(code, content);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hãy chọn câu hỏi ở List View 2");
            }
        }      
    }
}
