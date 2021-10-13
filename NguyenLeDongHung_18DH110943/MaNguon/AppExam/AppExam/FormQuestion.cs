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
    public partial class FormQuestion : Form
    {
        string codeE = "";
        public FormQuestion()
        {
            InitializeComponent();
            codeE = Program.CodeExam;
            LoadingData();
        }

        private void LoadingData()
        {
            Program.input = "QL" + "|"+codeE;
            //MessageBox.Show(Program.input);
            Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
            Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);

            int recv = Program.server.Receive(Program.dataRec);
            MessageBox.Show(Encoding.ASCII.GetString(Program.dataRec, 0, recv));

            string arrQues = Encoding.ASCII.GetString(Program.dataRec, 0, recv);
            
            if (String.IsNullOrEmpty(arrQues)|| arrQues=="Null")
            {                
                return;
            }
            else
            {
                
                string[] listQues = arrQues.Split('~');

                for (int i = 0; i < listQues.Length - 1; i++)
                {
                    string[] listQuesP = listQues[i].Split('|');
                    //foreach (var item2 in listExamP)
                    //{
                    //    MessageBox.Show(item2);
                    //}
                    AddToListView(listQuesP[1], listQuesP[3]);
                }
            }       
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormExamPrepare form = new FormExamPrepare();
            form.ShowDialog();
        }

        private void FormQuestion_Load(object sender, EventArgs e)
        {
            lbMaDe.Text = "Form Exam " + codeE;
        }

        private void txtCodeQ_KeyPress(object sender, KeyPressEventArgs e)
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

        //Thuật toán mã hóa
        private string encrypt_aes(string message)
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
            string x = aesEncryt(message, key, iv, blocksize, keysize, ciphermode, padmod);
            return x;

        }

        private string aesEncryt(string message, byte[] key, byte[] iv, int blocksize, int keysize, int ciphermod, int padmod)
        {
            string kq = "";
            SymmetricAlgorithm x = SymmetricAlgorithm.Create("Rijndael");
            x.BlockSize = blocksize;
            x.KeySize = keysize;
            x.Key = key;
            x.IV = iv;
            x.Padding = (PaddingMode)padmod;
            x.Mode = (CipherMode)ciphermod;
            ICryptoTransform xcrypto = x.CreateEncryptor();
            MemoryStream xmemstream = new MemoryStream();
            CryptoStream xstream = new CryptoStream(xmemstream, xcrypto, CryptoStreamMode.Write);
            Encoding encoding = Encoding.UTF8;
            byte[] m = Encoding.UTF8.GetBytes(message);
            xstream.Write(m, 0, message.Length);
            xstream.Close();
            byte[] cipher = xmemstream.ToArray();

            string hex = "";
            for (int i = 0; i < cipher.Length; i++)
            {
                hex = Convert.ToString(cipher[i], 16);
                if (hex.Length == 1)
                {
                    hex = "0" + hex;
                }
                kq += hex;
            }
            return kq;
        }

        private static readonly string[] VietnameseSigns = new string[]
        {

            "aAeEoOuUiIdDyY",

            "áàạảãâấầậẩẫăắằặẳẵ",

            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",

            "éèẹẻẽêếềệểễ",

            "ÉÈẸẺẼÊẾỀỆỂỄ",

            "óòọỏõôốồộổỗơớờợởỡ",

            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",

            "úùụủũưứừựửữ",

            "ÚÙỤỦŨƯỨỪỰỬỮ",

            "íìịỉĩ",

            "ÍÌỊỈĨ",

            "đ",

            "Đ",

            "ýỳỵỷỹ",

            "ÝỲỴỶỸ"

        };

        public static string RemoveSign4VietnameseString(string str)
        {

            //Tiến hành thay thế , lọc bỏ dấu cho chuỗi

            for (int i = 1; i < VietnameseSigns.Length; i++)

            {

                for (int j = 0; j < VietnameseSigns[i].Length; j++)

                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);

            }

            return str;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtQuestion.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            cbA.Checked = false;
            cbB.Checked = false;
            cbC.Checked = false;
            cbD.Checked = false;
            btnCreate.Visible = false;
            btnSave.Visible = true;            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string codeQ = "Q" + codeE + txtCodeQ.Text;
                string quesAndAns = "";
                //Mã Đề, Mã Câu Hỏi, Nội Dung, Đáp Án

                quesAndAns = txtQuestion.Text.Trim() + "|" + txtA.Text.Trim() + "|" + txtB.Text.Trim() + "|" + txtC.Text.Trim() + "|" + txtD.Text.Trim() + "|";
                if (cbA.Checked)
                {
                    quesAndAns += "A$";
                }
                if (cbB.Checked)
                {
                    quesAndAns += "B$";
                }
                if (cbC.Checked)
                {
                    quesAndAns += "C$";
                }
                if (cbD.Checked)
                {
                    quesAndAns += "D$";
                }                
                
                if (String.IsNullOrEmpty(txtQuestion.Text) || String.IsNullOrEmpty(txtA.Text) || String.IsNullOrEmpty(txtB.Text) || String.IsNullOrEmpty(txtC.Text) || String.IsNullOrEmpty(txtD.Text))
                {
                    MessageBox.Show("Question và 4 Answer không được trống");
                    return;
                }
                else if (cbA.Checked == false && cbB.Checked == false && cbC.Checked == false && cbD.Checked == false)
                {
                    MessageBox.Show("Phải Check ít nhất 1 trong 4 Answer");

                    return;
                }
                else
                {
                    //Mã hóa
                    quesAndAns = RemoveSign4VietnameseString(quesAndAns);
                    quesAndAns = encrypt_aes(quesAndAns);

                    Program.input = "QS" + "|" + codeQ.Trim() + "|" + codeE.Trim() + "|" + quesAndAns;
                    MessageBox.Show(Program.input);
                    Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
                    Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);

                    int recv = Program.server.Receive(Program.dataRec);
                    MessageBox.Show(Encoding.ASCII.GetString(Program.dataRec, 0, recv));

                    string test = "Question " + codeQ + " da ton tai." + " Khong the tao";

                    if (Encoding.ASCII.GetString(Program.dataRec, 0, recv)!=test)
                    {
                        ListViewItem item = new ListViewItem(codeQ);
                        item.SubItems.Add(quesAndAns);
                        listViewQuestion.Items.Add(item);
                        txtCodeQ.Clear();
                        txtA.Clear();
                        txtB.Clear();
                        txtC.Clear();
                        txtD.Clear();
                        txtCodeQ.Focus();
                    }                   
                    
                    txtQuestion.Text = "";
                    txtA.Text = "";
                    txtB.Text = "";
                    txtC.Text = "";
                    txtD.Text = "";
                    cbA.Checked = false;
                    cbB.Checked = false;
                    cbC.Checked = false;
                    cbD.Checked = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình nhập liệu" + ex);
            }
        }

        private void AddToListView(string codeQ, string Content)
        {
            ListViewItem item = new ListViewItem(codeQ);
            item.SubItems.Add(Content);
            listViewQuestion.Items.Add(item);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {            
            if (listViewQuestion.Items.Count > 0)
            {
                Program.input = "QD" + "|" + listViewQuestion.SelectedItems[0].Text.Trim() + "|";
                MessageBox.Show(Program.input);
                Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
                Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);

                int recv = Program.server.Receive(Program.dataRec);
                MessageBox.Show(Encoding.ASCII.GetString(Program.dataRec, 0, recv));

                listViewQuestion.Items.Remove(listViewQuestion.SelectedItems[0]);
            }
        }
    }
}
