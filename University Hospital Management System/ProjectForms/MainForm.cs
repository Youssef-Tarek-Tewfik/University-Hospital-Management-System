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
            label1.Text +=  label1.Text == null ? label1.Text = "" : label1.Text = onlineUser.name;
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

        private void showRoomsData_btn_Click(object sender, EventArgs e)
        {
            roomsDataPanel.Visible = !roomsDataPanel.Visible;
            showRoomsData_btn.Text = roomsDataPanel.Visible == false ? "Show Rooms Data" : "Hide Rooms Data";

            OracleCommand cmd = new OracleCommand
            { 
                Connection = OrclDatabase.conn,
                CommandText = "SELECT * FROM Room",
                CommandType = CommandType.Text
            };

            OracleDataReader dr = cmd.ExecuteReader();
            int i = 0;

            while (dr.Read())
            {
                roomsDataGridView.RowCount++;
                roomsDataGridView.Rows[i].Cells[0].Value = dr[0];
                roomsDataGridView.Rows[i].Cells[1].Value = dr[1];
                roomsDataGridView.Rows[i].Cells[2].Value = dr[2];
                roomsDataGridView.Rows[i].Cells[3].Value = dr[3];
                i++;
            }

            cmd.Dispose();
            dr.Dispose();
            dr.Close();
        }

        private void roomsDataPanel_VisibleChanged(object sender, EventArgs e)
        {
            roomsDataGridView.RowCount = 1;
        }
    }
}
