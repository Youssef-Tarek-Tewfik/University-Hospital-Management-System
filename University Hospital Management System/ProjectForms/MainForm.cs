using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using University_Hospital_Management_System.ProjectClasses;

namespace University_Hospital_Management_System.ProjectForms
{
    public partial class MainForm : Form
    {
        SystemPersona onlineUser;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        public MainForm()
        {
            InitializeComponent();
        }

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
            DialogResult signOutResult = MessageBox.Show("Are you sure to log out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (signOutResult == DialogResult.Yes)
            {
                onlineUser = null;
                this.Dispose();
                this.Close();
            }
        }

        private void searchPatientsData_btn_Click(object sender, EventArgs e)
        {
            //ClearMemory();
            string cmdString = "SELECT * FROM Patient_History";

            if (!string.IsNullOrEmpty(patientID_txt.Text))
            {
                cmdString += " WHERE PID=:id";
            }

            adapter = new OracleDataAdapter(cmdString, OrclDatabase.oracleConnectionString);

            if (!string.IsNullOrEmpty(patientID_txt.Text))
            {
                adapter.SelectCommand.Parameters.Add("id", patientID_txt.Text);
            }

            ds = new DataSet("Patient_History");
            adapter.Fill(ds);
            patientsDataGridView.DataSource = ds.Tables[0];
        }

        private void saveChanges_btn_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);

            if (adapter == null)
            {
                return;
            }

            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Changes saved in Database", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showPatientsData_btn_Click(object sender, EventArgs e)
        {
            patientsDataPanel.Visible = !patientsDataPanel.Visible;
            showPatientsData_btn.Text = patientsDataPanel.Visible == false ? "Show Patients Data" : "Hide Patients Data";
        }

        private void patientsDataPanel_VisibleChanged(object sender, EventArgs e)
        {
            patientsDataGridView.DataSource = null;
        }

        private void ClearMemory()
        {
            adapter.Dispose();
            builder.Dispose();
            ds.Dispose();
            ds.Clear();
        }

    }
}
