using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExam
{
    public partial class FormMain : Form
    {
        private int childFormNumber = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin form = new FormLogin();
            Program.isTeacher = false;
            form.ShowDialog();
        }      

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Program.isTeacher!=true)
            {
                raDeThi.Visible = false;
                soanDeThi.Visible = false;
                logOut.Visible = false;
                xinChao.Visible = false;
                bangKetQua.Visible = false;
            }
            else
            {
                thiTN.Visible = false;
                raDeThi.Visible = true;
                soanDeThi.Visible = true;
                logOut.Visible = true;
                logIn.Visible = false;
                xinChao.Visible = true;
                bangKetQua.Visible = true;
                xinChao.Text += " " + Program.userLogin;
            }
        }

        private void soanDeThi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormExamPrepare form = new FormExamPrepare();
            form.ShowDialog();
        }

        private void logInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin form = new FormLogin();
            form.ShowDialog();
        }

        private void raDeThi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FromExamQues form = new FromExamQues();
            form.ShowDialog();
        }

        private void thiTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrepareThi form = new FormPrepareThi();
            form.ShowDialog();
        }

        private void bangKetQua_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormResult form = new FormResult();
            form.ShowDialog();
        }
    }
}
