using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_Hospital_Management_System.ProjectClasses;

namespace University_Hospital_Management_System.ProjectForms
{
    public partial class MainForm : Form
    {
        SystemPersona onlineUser;

        public MainForm(SystemPersona loggedinUser)
        {
            onlineUser = loggedinUser;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text += onlineUser.name;
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            onlineUser = null;
            this.Dispose();
            this.Close();
        }

    }
}
