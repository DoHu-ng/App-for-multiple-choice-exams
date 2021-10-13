using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExam
{
    public partial class FormRegister : Form
    {
        //static byte[] dataSend = new byte[1024];
        //static byte[] dataRec = new byte[1024];
        //static string input = "";
        //static string output = "";

        //static IPEndPoint ipep;
        //static Socket server;

        public FormRegister()
        {
            InitializeComponent();
            //ipep = new IPEndPoint(IPAddress.Parse("169.254.237.167"), 8989);
            //server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //server.Connect(ipep);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin form = new FormLogin();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string regex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                string username = txtUsername.Text;
                string pass = Sha512();
                string passtest = txtPassword.Text;
                string cpass = txtCPassWord.Text;
                string email = txtEmail.Text;
                                
                if (Regex.IsMatch(email, regex) == false)
                {
                    MessageBox.Show("Email không hợp lệ. Vui lòng nhập lại!!!");
                    txtEmail.Text = "";
                    return;
                }
                else if (passtest != cpass || passtest == "" || cpass == "")
                {
                    MessageBox.Show("Password không trùng với Comfirm Password và không được đặt password \"\"");
                    txtCPassWord.Text = "";
                    return;
                }
                else
                {
                    Program.input = "RS" + "|" + username.Trim() + "|" + pass.Trim() + "|" + email.Trim()+"|";
                    MessageBox.Show(Program.input);
                    Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
                    Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);
                    btnSave.Visible = false;
                    btnCreate.Visible = true;
                    int recv = Program.server.Receive(Program.dataRec);
                    
                    MessageBox.Show(Encoding.ASCII.GetString(Program.dataRec, 0, recv));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình nhập. Vui lòng nhập lại");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Button Create
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            txtCPassWord.Text = "";
            btnSave.Visible = true;
            btnCreate.Visible = false;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                Program.input = "RD" + "|" + username.Trim();
                MessageBox.Show(Program.input);
                Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
                Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);

                int recv = Program.server.Receive(Program.dataRec);
                MessageBox.Show(Encoding.ASCII.GetString(Program.dataRec, 0, recv));
            }
            catch (Exception)
            {

                MessageBox.Show("Xảy ra lỗi trong quá trình nhập. Vui lòng nhập lại");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string regex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                string username = txtUsername.Text;
                string pass = Sha512();
                string passtest = txtPassword.Text;
                string cpass = txtCPassWord.Text;
                string email = txtEmail.Text;

                if (Regex.IsMatch(email, regex) == false)
                {
                    MessageBox.Show("Email không hợp lệ. Vui lòng nhập lại!!!");
                    txtEmail.Text = "";
                    return;
                }
                else if (passtest != cpass || passtest == "" || cpass == "")
                {
                    MessageBox.Show("Password không trùng với Comfirm Password và không được đặt password \"\"");
                    txtCPassWord.Text = "";
                    return;
                }
                else
                {
                    Program.input = "RU" + "|" + username.Trim() + "|" + pass.Trim() + "|" + email.Trim() + "|";
                    MessageBox.Show(Program.input);
                    Program.dataSend = Encoding.ASCII.GetBytes(Program.input);
                    Program.server.Send(Program.dataSend, Program.dataSend.Length, SocketFlags.None);
                    btnSave.Visible = false;
                    btnCreate.Visible = true;
                    int recv = Program.server.Receive(Program.dataRec);

                    MessageBox.Show(Encoding.ASCII.GetString(Program.dataRec, 0, recv));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình nhập. Vui lòng nhập lại");
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
