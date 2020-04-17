using System;
using System.Windows.Forms;
using University_Hospital_Management_System.ProjectClasses;

namespace University_Hospital_Management_System.ProjectForms
{
    public partial class AuthForm : Form
    {
        string onlineUserType;

        public AuthForm()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (onlineUserType != null)
            {
                OrclDatabase.SignInUser(username_txt.Text, password_txt.Text, onlineUserType);
            }
            else
            {
                MessageBox.Show("Select User type first", "Check Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AuthForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OrclDatabase.conn.Close();
        }

        private void registrationLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            //this.Dispose();
            //this.Close();
        }

        private void UserType_CheckedChanged(object sender, EventArgs e)
        {
            onlineUserType = ((RadioButton)sender).Text;
        }

        private void show_password_cb_CheckedChanged(object sender, EventArgs e)
        {
            password_txt.UseSystemPasswordChar = show_password_cb.Checked ? false : true;
        }
    }
}
