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

        #region UI Methods
        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text += label1.Text == null ? label1.Text = "" : label1.Text = onlineUser.name;

            if (onlineUser.GetType() == typeof(Doctor) || onlineUser.GetType() == typeof(Nurse))
            {
                showPatientsData_btn.Visible = true;
                showRoomsData_btn.Visible = true;
            }
            else if (onlineUser.GetType() == typeof(Patient))
            {
                showPatientsData_btn.Visible = false;
                showRoomsData_btn.Visible = false;
            }
        }

        // B. Using ODP.NET Disconnected mode
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

        // B. Using ODP.NET Disconnected mode
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

        // 1. Select 1 or more rows without WHERE condition
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

        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult signOutResult = MessageBox.Show("Are you sure to log out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (signOutResult == DialogResult.Yes)
            {
                onlineUser = null;
                this.Dispose();
                this.Close();
            }
        }

        // 3. Delete rows (without procedures)
        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult deleteResult = MessageBox.Show("Are you sure to delete your account?", "Delete account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (deleteResult == DialogResult.Yes)
            {
                OracleCommand cmd = new OracleCommand
                {
                    Connection = OrclDatabase.conn,
                    CommandText = $"DELETE FROM {onlineUser.type} WHERE ID = :id",
                    CommandType = CommandType.Text
                };

                cmd.Parameters.Add("id", onlineUser.ID);

                if (onlineUser.type == "Doctor" || onlineUser.type == "Nurse")
                {
                    DeleteStaffUser();
                }

                int r = cmd.ExecuteNonQuery();

                if (r != -1)
                {
                    onlineUser = null;
                    this.Dispose();
                    this.Close();
                    MessageBox.Show("User deleted from Database", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // 6. Insert row using stored procedure
        private void addRoomData_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(roomFloorNumber_txt.Text) || !string.IsNullOrWhiteSpace(roomFloorNumber_txt.Text) ||
                !string.IsNullOrEmpty(roomType_txt.Text) || !string.IsNullOrWhiteSpace(roomType_txt.Text))
            {
                OracleCommand cmd = new OracleCommand
                {
                    Connection = OrclDatabase.conn,
                    CommandText = "AddNewRoom",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("floor", roomFloorNumber_txt.Text);
                cmd.Parameters.Add("roomType", roomType_txt.Text);

                int r = cmd.ExecuteNonQuery();

                if (r == -1)
                {
                    MessageBox.Show("New room Added to Database", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bookAppointment_btn_Click(object sender, EventArgs e)
        {
            BookingAppointmentForm appointmentForm = new BookingAppointmentForm(onlineUser);
            appointmentForm.Show();
        }

        #endregion

        #region Helper Methods
        private void DeleteStaffUser()
        {
            OracleCommand cmd = new OracleCommand
            {
                Connection = OrclDatabase.conn,
                CommandText = $"DELETE FROM Staff WHERE ID = :id",
                CommandType = CommandType.Text
            };

            cmd.Parameters.Add("id", onlineUser.ID);
            int r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show("Staff Member deleted");
            }
        }

        private void ClearMemory()
        {
            adapter.Dispose();
            builder.Dispose();
            ds.Dispose();
            ds.Clear();
        }

        #endregion


    }
}
