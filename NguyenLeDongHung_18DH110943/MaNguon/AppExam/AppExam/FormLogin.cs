using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExam
{
    public partial class FormLogin : Form
    {
        //static byte[] dataSend = new byte[1024];
        //static byte[] dataRec = new byte[1024];
        //static string input = "";
        //static string output = "";

        //IPEndPoint ipep;
        //Socket server;
        int index = 1;
        int second = 0;
        string code;
        public FormLogin()
        {
            InitializeComponent();
            //ipep = new IPEndPoint(IPAddress.Parse("169.254.237.167"), 8989);
            //server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //server.Connect(ipep);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {            
            this.Close();
            Program.input = "Exit Register";
            MessageBox.Show(Program.input);
            Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
            Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister form = new FormRegister();
            form.ShowDialog();
        }
        private string Sha512()
        {
            string pass = txtPassword.Text;
            byte[] x_message_data = Encoding.Default.GetBytes(pass);
            HashAlgorithm x_hash_alg = HashAlgorithm.Create("SHA512");
            byte[] x_hash_code = x_hash_alg.ComputeHash(x_message_data);
            string hex = null;
            foreach (var x_byte in x_hash_code)
            {
                hex += x_byte.ToString("X2") + "";
            }
            return hex;
        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            if (index < 3)
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                string hashpass = Sha512(); 
                txtHash.Text = hashpass;                
                
                if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username hay Password không được trống");
                    return;
                }
                else
                {
                    Program.input = "LL" + "|" + username.Trim() + "|" + hashpass.Trim() + "|";
                    MessageBox.Show(Program.input);
                    Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
                    Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);
                    
                    int recv = Program.server.Receive(Program.dataRec);
                    MessageBox.Show(Encoding.ASCII.GetString(Program.dataRec, 0, recv));
                    string dbpass = Encoding.ASCII.GetString(Program.dataRec, 0, recv).ToString();
                    if (hashpass == dbpass)
                    {
                        txtHash.Text = "Hash Login Successful >>>>>";
                        Random ran = new Random();
                        code = ran.Next(100001, 999999).ToString();

                        txtMa.Text = code;

                        string to = "donghunglig009@gmail.com";
                        string from = "dohusecret009@gmail.com";
                        string subject = "ID code xác thực";
                        string message = code;
                        string passemail = "lifeisagame_16042000";
                        SendMail(from, to, subject, message, passemail);

                        txtMa.Visible = true;
                        txtAuThenMa.Visible = true;
                        lbID.Visible = true;
                        btnLogin2.Visible = true;
                        btnLogin1.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu. Vui lòng nhập lại!!!");
                        index++;
                        //txtUsername.Text = "";
                        txtPassword.Text = "";
                        txtHash.Text = "";
                    }
                }

            }
            else
            {
                MessageBox.Show("Da nhap sai qua 3 lan. Xin vui long doi 20 giay sau de nhap lai!!!");
                second = 20;
                lbScreen.Visible = true;
                countdownTimer.Start();
                index = 1;
                return;
            }
        }
        private void SendMail(string from, string to, string subject, string message, string passemail)
        {
            try
            {
                MailMessage mess = new MailMessage(from, to, subject, message);
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from, passemail);
                client.Send(mess);
            }
            catch (Exception)
            {

                txtHash.Text = "Send Mail No Successfull. Please check Internet Connection";
            }
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
            txtPassword.Refresh();
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            string codeAuthen = txtAuThenMa.Text;
            if (codeAuthen == code)
            {
                this.Hide();
                MessageBox.Show("Đăng nhập thành công vào hệ thống >>>");

                Program.userLogin = txtUsername.Text;
                Program.isTeacher = true;

                FormMain form = new FormMain();
                form.ShowDialog();
            }
            else
            {
                txtAuThenMa.Text = "";
                txtAuThenMa.Visible = false;
                txtMa.Text = "";
                txtMa.Visible = false;
                lbID.Visible = false;
                btnLogin2.Visible = false;
                btnLogin1.Visible = true;
                txtPassword.Text = "";
                txtUsername.Text = "";
                txtHash.Text = "Vui lòng đăng nhập lại";
                MessageBox.Show("Nhập sai mã chứng thực OTP vui lòng đăng nhập lại");
            }
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            lbScreen.Text = second--.ToString();
            if (second < 0)
            {
                countdownTimer.Stop();
                lbScreen.Visible = false;
            }
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Đăng nhập thành công vào hệ thống với quyền Student>>>");            
            Program.isTeacher = false;

            FormMain form = new FormMain();
            form.ShowDialog();
        }
    }
}
