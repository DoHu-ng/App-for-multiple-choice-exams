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
using System.Timers;
using System.Windows.Forms;

namespace AppExam
{
    public partial class FormThi : Form
    {
        static int count = 0;
        static int countQuestion = 0;
        static string[] dsExam;
        static string[] dsCauHoi;
        static string[] dsA;
        static string[] dsB;
        static string[] dsC;
        static string[] dsD;
        static string[] dsDapAn;

        static string[] dsKetQua;

        //Tạo biến khởi đầu cho CountDown
        System.Timers.Timer t;
        int h, m, s;

        //
        static int h1 = 0;
        static int m1 = 0;
        static int s1 = 0;

        static int h2 = 0;
        static int m2 = 0;
        static int s2 = 0;
        public FormThi()
        {
            InitializeComponent();
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

        private void FormThi_Load(object sender, EventArgs e)
        {
            txtCodeExamQ.Text = Program.CodeExamQ;
            txtStudentName.Text = Program.studentName;
            txtIDCode.Text = Program.idCode;

            MessageBox.Show(Program.hour.ToString() + Program.minute.ToString() + Program.second.ToString());

            //Tải danh sách câu hỏi và đáp án theo mã đề phía trên
            Program.input = "TL" + "|" + Program.CodeExamQ.Trim();
            MessageBox.Show(Program.input);
            Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
            Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);

            int recv = Program.server.Receive(Program.dataRec);
            MessageBox.Show(Encoding.ASCII.GetString(Program.dataRec, 0, recv));
            string messRec = Encoding.ASCII.GetString(Program.dataRec, 0, recv);

            if (messRec=="Null")
            {
                MessageBox.Show("Bộ đề trống. Xin vui lòng chọn đề khác !!!");
                this.Hide();
                FormPrepareThi form = new FormPrepareThi();
                form.ShowDialog();
            }

            //Xử lý dữ liệu sau khi đã tải về từ server
            dsExam = messRec.Split('~');

            for (int i = 0; i < dsExam.Length-1; i++)
            {
                dsExam[i] = decrypt_aes(dsExam[i]);
            }

            dsCauHoi = new string[dsExam.Length - 1];
            dsA = new string[dsExam.Length - 1];
            dsB = new string[dsExam.Length - 1];
            dsC = new string[dsExam.Length - 1];
            dsD = new string[dsExam.Length - 1];
            dsDapAn = new string[dsExam.Length - 1];
            dsKetQua = new string[dsExam.Length - 1];
            countQuestion = dsCauHoi.Length;

            for (int i = 0; i < dsExam.Length-1; i++)
            {
                string[] temp = dsExam[i].Split('|');

                dsCauHoi[i] = temp[0];
                dsA[i] = temp[1];
                dsB[i] = temp[2];
                dsC[i] = temp[3];
                dsD[i] = temp[4];

                string dapAn = temp[5];

                string[] temp2 = dapAn.Split('$');
                foreach (var item in temp2)
                {
                    if (item == "A" || item == "B" || item == "C" || item == "D")
                    {
                        dsDapAn[i] += item;
                    }
                }
            }

            //Làm sạch danh sách kết quả
            for (int i = 0; i < dsKetQua.Length; i++)
            {
                dsKetQua[i] = "";
            }

            //Load dữ liệu câu hỏi 1
            lbQuestion.Text = "QUESTION " + count;
            txtQuestion.Text = dsCauHoi[count];
            txtA.Text = dsA[count];
            txtB.Text = dsB[count];
            txtC.Text = dsC[count];
            txtD.Text = dsD[count];
            txtRecAns.Text = dsDapAn[count];

            //Load thời gian từ Program
            h1 = Program.hour;
            m1 = Program.minute;
            s1 = Program.second;
            //Chuyển đổi giá trị Hour, Minute, Second lấy từ Program
            if (s1 >= 60)
            {
                //Số giây còn lại khi chia cho 60 để đổi thành phút
                s2 = s1 % 60;
                //Đổi giây thành phút
                s1 = s1 / 60;
                m1 += s1;
                s1 = s2;
            }
            if (m1 >= 60)
            {
                //Số phút còn lại khi chia cho 60 để đổi thành giờ
                m2 = m1 % 60;
                //Đổi giây thành phút
                m1 = m1 / 60;
                h1 += m1;
                m1 = m2;
            }
            //Load Countdown khi vừa load form
            t = new System.Timers.Timer();
            t.Interval = 1000; //1s
            t.Elapsed += OnTimeEvent;
            //Chạy countdown
            t.Start();
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                txtcountDown.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                //Dừng countdown theo điều kiện
                if (s1 == s && m1 == m && h1 == h)
                {
                    t.Stop();
                    Submit();
                }
            }));
        }       
        private void btnNext_Click(object sender, EventArgs e)
        {
            //Ghi lại đáp ở vị trí hiện tại
            if (dsKetQua[count] == "")
            {
                if (cbA.Checked == true)
                {
                    dsKetQua[count] += "A";
                }
                if (cbB.Checked == true)
                {
                    dsKetQua[count] += "B";
                }
                if (cbC.Checked == true)
                {
                    dsKetQua[count] += "C";
                }
                if (cbD.Checked == true)
                {
                    dsKetQua[count] += "D";
                }
            }
            else
            {
                dsKetQua[count] = "";
                if (cbA.Checked == true)
                {
                    dsKetQua[count] += "A";
                }
                if (cbB.Checked == true)
                {
                    dsKetQua[count] += "B";
                }
                if (cbC.Checked == true)
                {
                    dsKetQua[count] += "C";
                }
                if (cbD.Checked == true)
                {
                    dsKetQua[count] += "D";
                }
            }
            //Chuyển câu hỏi về phía sau
            if (count + 1 < countQuestion)
            {
                count++;
                lbQuestion.Text = "QUESTION " + count;
                txtQuestion.Text = dsCauHoi[count];
                txtA.Text = dsA[count];
                txtB.Text = dsB[count];
                txtC.Text = dsC[count];
                txtD.Text = dsD[count];
                txtRecAns.Text = dsDapAn[count];

                //Ghi lại đáp án đã điền từ trước
                if (dsKetQua[count]!="")
                {
                    switch (dsKetQua[count])
                    {
                        case "A":
                            cbA.Checked = true;
                            cbB.Checked = false;
                            cbC.Checked = false;
                            cbD.Checked = false;
                            break;
                        case "B":
                            cbB.Checked = true;
                            cbA.Checked = false;
                            cbC.Checked = false;
                            cbD.Checked = false;
                            break;
                        case "C":
                            cbC.Checked = true;
                            cbA.Checked = false;
                            cbB.Checked = false;
                            cbD.Checked = false;
                            break;
                        case "D":
                            cbD.Checked = true;
                            cbB.Checked = false;
                            cbC.Checked = false;
                            cbA.Checked = false;
                            break;
                        case "AB":
                            cbA.Checked = true;
                            cbB.Checked = true;
                            cbC.Checked = false;
                            cbD.Checked = false;
                            break;
                        case "AC":
                            cbA.Checked = true;
                            cbC.Checked = true;
                            cbB.Checked = false;
                            cbD.Checked = false;
                            break;
                        case "AD":
                            cbA.Checked = true;
                            cbD.Checked = true;
                            cbC.Checked = false;
                            cbB.Checked = false;
                            break;
                        case "BC":
                            cbB.Checked = true;
                            cbC.Checked = true;
                            cbA.Checked = false;
                            cbD.Checked = false;
                            break;
                        case "BD":
                            cbB.Checked = true;
                            cbD.Checked = true;
                            cbC.Checked = false;
                            cbA.Checked = false;
                            break;
                        case "CD":
                            cbC.Checked = true;
                            cbD.Checked = true;
                            cbA.Checked = false;
                            cbB.Checked = false;
                            break;
                        case "ABC":
                            cbA.Checked = true;
                            cbB.Checked = true;
                            cbC.Checked = true;
                            cbD.Checked = false;
                            break;
                        case "ABD":
                            cbA.Checked = true;
                            cbB.Checked = true;
                            cbD.Checked = true;
                            cbC.Checked = false;
                            break;
                        case "ACD":
                            cbA.Checked = true;
                            cbC.Checked = true;
                            cbD.Checked = true;
                            cbB.Checked = false;
                            break;
                        case "BCD":
                            cbB.Checked = true;
                            cbC.Checked = true;
                            cbD.Checked = true;
                            cbA.Checked = false;
                            break;
                        case "ABCD":
                            cbA.Checked = true;
                            cbB.Checked = true;
                            cbC.Checked = true;
                            cbD.Checked = true;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    cbA.Checked = false;
                    cbB.Checked = false;
                    cbC.Checked = false;
                    cbD.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Không còn câu hỏi nữa !!!");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //Ghi lại đáp ở vị trí hiện tại
            if (dsKetQua[count] == "")
            {
                if (cbA.Checked == true)
                {
                    dsKetQua[count] += "A";
                }
                if (cbB.Checked == true)
                {
                    dsKetQua[count] += "B";
                }
                if (cbC.Checked == true)
                {
                    dsKetQua[count] += "C";
                }
                if (cbD.Checked == true)
                {
                    dsKetQua[count] += "D";
                }
            }
            else
            {
                dsKetQua[count] = "";
                if (cbA.Checked == true)
                {
                    dsKetQua[count] += "A";
                }
                if (cbB.Checked == true)
                {
                    dsKetQua[count] += "B";
                }
                if (cbC.Checked == true)
                {
                    dsKetQua[count] += "C";
                }
                if (cbD.Checked == true)
                {
                    dsKetQua[count] += "D";
                }
            }
            //Chuyển câu hỏi về phía trước
            if (count - 1 >= 0)
            {
                count--;
                lbQuestion.Text = "QUESTION " + count;
                txtQuestion.Text = dsCauHoi[count];
                txtA.Text = dsA[count];
                txtB.Text = dsB[count];
                txtC.Text = dsC[count];
                txtD.Text = dsD[count];
                txtRecAns.Text = dsDapAn[count];

                //Ghi lại đáp án đã điền từ trước
                if (dsKetQua[count] != "")
                {
                    switch (dsKetQua[count])
                    {
                        case "A":
                            cbA.Checked = true;
                            cbB.Checked = false;
                            cbC.Checked = false;
                            cbD.Checked = false;
                            break;
                        case "B":
                            cbB.Checked = true;
                            cbA.Checked = false;
                            cbC.Checked = false;
                            cbD.Checked = false;
                            break;
                        case "C":
                            cbC.Checked = true;
                            cbA.Checked = false;
                            cbB.Checked = false;
                            cbD.Checked = false;
                            break;
                        case "D":
                            cbD.Checked = true;
                            cbB.Checked = false;
                            cbC.Checked = false;
                            cbA.Checked = false;
                            break;
                        case "AB":
                            cbA.Checked = true;
                            cbB.Checked = true;
                            cbC.Checked = false;
                            cbD.Checked = false;
                            break;
                        case "AC":
                            cbA.Checked = true;
                            cbC.Checked = true;
                            cbB.Checked = false;
                            cbD.Checked = false;
                            break;
                        case "AD":
                            cbA.Checked = true;
                            cbD.Checked = true;
                            cbC.Checked = false;
                            cbB.Checked = false;
                            break;
                        case "BC":
                            cbB.Checked = true;
                            cbC.Checked = true;
                            cbA.Checked = false;
                            cbD.Checked = false;
                            break;
                        case "BD":
                            cbB.Checked = true;
                            cbD.Checked = true;
                            cbC.Checked = false;
                            cbA.Checked = false;
                            break;
                        case "CD":
                            cbC.Checked = true;
                            cbD.Checked = true;
                            cbA.Checked = false;
                            cbB.Checked = false;
                            break;
                        case "ABC":
                            cbA.Checked = true;
                            cbB.Checked = true;
                            cbC.Checked = true;
                            cbD.Checked = false;
                            break;
                        case "ABD":
                            cbA.Checked = true;
                            cbB.Checked = true;
                            cbD.Checked = true;
                            cbC.Checked = false;
                            break;
                        case "ACD":
                            cbA.Checked = true;
                            cbC.Checked = true;
                            cbD.Checked = true;
                            cbB.Checked = false;
                            break;
                        case "BCD":
                            cbB.Checked = true;
                            cbC.Checked = true;
                            cbD.Checked = true;
                            cbA.Checked = false;
                            break;
                        case "ABCD":
                            cbA.Checked = true;
                            cbB.Checked = true;
                            cbC.Checked = true;
                            cbD.Checked = true;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    cbA.Checked = false;
                    cbB.Checked = false;
                    cbC.Checked = false;
                    cbD.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Không còn câu hỏi nữa !!!");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Lưu kết quả đã chọn câu cuối
            if (dsKetQua[count] == "")
            {
                if (cbA.Checked == true)
                {
                    dsKetQua[count] += "A";
                }
                if (cbB.Checked == true)
                {
                    dsKetQua[count] += "B";
                }
                if (cbC.Checked == true)
                {
                    dsKetQua[count] += "C";
                }
                if (cbD.Checked == true)
                {
                    dsKetQua[count] += "D";
                }
            }
            else
            {
                dsKetQua[count] = "";
                if (cbA.Checked == true)
                {
                    dsKetQua[count] += "A";
                }
                if (cbB.Checked == true)
                {
                    dsKetQua[count] += "B";
                }
                if (cbC.Checked == true)
                {
                    dsKetQua[count] += "C";
                }
                if (cbD.Checked == true)
                {
                    dsKetQua[count] += "D";
                }
            }
            //Dừng Countdown
            t.Stop();
            //Tính điểm 
            double score = 0;

            for (int i = 0; i < dsCauHoi.Length; i++)
            {
                if (dsDapAn[i] == dsKetQua[i])
                    score++;
            }

            int totalQues = dsCauHoi.Length;
            double scoreDecimal = score / totalQues * 10;

            MessageBox.Show("Số câu đã hoàn thành bài kiểm tra đề " + Program.CodeExamQ + " là: " + score + "/" + totalQues.ToString());
            MessageBox.Show("Điểm số bài kiểm tra đề " + Program.CodeExamQ + " là: " + scoreDecimal);

            //Lưu kết quả vào database
            string datetime = DateTime.Now.ToString();
            Program.input = "TS" + "|" + datetime + "|" + Program.NameExamQ.Trim() + "|" + Program.studentName + "|" + Program.idCode + "|" + scoreDecimal;
            MessageBox.Show(Program.input);
            Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
            Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);

            count = 0;
            countQuestion = 0;
            this.Hide();
            FormPrepareThi form = new FormPrepareThi();
            form.ShowDialog();
        }

        private void Submit()
        {
            //Lưu kết quả đã chọn câu cuối
            if (dsKetQua[count] == "")
            {
                if (cbA.Checked == true)
                {
                    dsKetQua[count] += "A";
                }
                if (cbB.Checked == true)
                {
                    dsKetQua[count] += "B";
                }
                if (cbC.Checked == true)
                {
                    dsKetQua[count] += "C";
                }
                if (cbD.Checked == true)
                {
                    dsKetQua[count] += "D";
                }
            }
            else
            {
                dsKetQua[count] = "";
                if (cbA.Checked == true)
                {
                    dsKetQua[count] += "A";
                }
                if (cbB.Checked == true)
                {
                    dsKetQua[count] += "B";
                }
                if (cbC.Checked == true)
                {
                    dsKetQua[count] += "C";
                }
                if (cbD.Checked == true)
                {
                    dsKetQua[count] += "D";
                }
            }
            //Dừng Countdown
            t.Stop();
            //Tính điểm 
            double score = 0;

            for (int i = 0; i < dsCauHoi.Length; i++)
            {
                if (dsDapAn[i] == dsKetQua[i])
                    score++;
            }

            int totalQues = dsCauHoi.Length;
            double scoreDecimal = score / totalQues * 10;

            MessageBox.Show("Số câu đã hoàn thành bài kiểm tra đề " + Program.CodeExamQ + " là: " + score + "/" + totalQues.ToString());
            MessageBox.Show("Điểm số bài kiểm tra đề " + Program.CodeExamQ + " là: " + scoreDecimal);

            //Lưu kết quả vào database
            string datetime = DateTime.Now.ToString();
            Program.input = "TS" + "|" + datetime + "|" + Program.NameExamQ.Trim() + "|" + Program.studentName + "|" + Program.idCode + "|" + scoreDecimal;
            MessageBox.Show(Program.input);
            Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
            Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);

            count = 0;
            countQuestion = 0;
            this.Hide();
            FormPrepareThi form = new FormPrepareThi();
            form.ShowDialog();
        }
    }
}
