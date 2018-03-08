using System;
using EmployeeManagement_Service.Service.Module;
using EmployeeManagement_Service.ModelDBContext;
using System.Windows.Forms;

namespace EmployeeManagerment_UI.User
{
    public partial class LoginForm : Form
    {
        string _depar = string.Empty;
        public LoginForm()
        {
            InitializeComponent();
            CheckPassWordChar();
        }

        private void cbremember_CheckedChanged(object sender, EventArgs e)
        {
            CheckPassWordChar();
        }

        public void CheckPassWordChar()
        {
            if (cbremember.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
                cbremember.Text = "Show";
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
                cbremember.Text = "Don't Show";
            }
        }

        //Button for login
        private void bntlogin_Click(object sender, EventArgs e)
        {
            _depar = cbbdepartment.Text;
            PdbAccount ac = new EmployeeManagement_Service.Service.Basic.Functions.UserLogins { }.CheckLogin(txtusername.Text,txtpassword.Text,cbbdepartment.Text);
            if (ac != null)
            {
                this.Visible = false;
                MainForm mainform = new MainForm();                
                mainform.ShowDialog();
                this.Visible = true;
                txtusername.Text = "";
                txtpassword.Text = "";                
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Error");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
