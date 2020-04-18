using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using University_Hospital_Management_System.ProjectClasses;

namespace University_Hospital_Management_System.ProjectForms
{
    public partial class MainForm : Form
    {
        private SystemPersona onlineUser;
        private OracleDataAdapter adapter;
        private OracleCommandBuilder builder;
        private DataSet ds;

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
            label1.Text += onlineUser.name;

            if (onlineUser.GetType() == typeof(Doctor) || onlineUser.GetType() == typeof(Nurse))
                deleteAccountToolStripMenuItem.Visible = false;
            else
                deleteAccountToolStripMenuItem.Visible = true;

            if (onlineUser.GetType() == typeof(Doctor) || onlineUser.GetType() == typeof(Nurse))
            {
                bookAppointment_btn.Visible = false;
                reportsComboBox.SelectedIndex = 0;
            }
            else if (onlineUser.GetType() == typeof(Patient))
            {
                showPatientsData_btn.Visible = false;
                showRoomsData_btn.Visible = false;
                viewReports_btn.Visible = false;
                reportsComboBox.Visible = false;
            }
        }

        // B. Using ODP.NET Disconnected mode
        private void searchPatientsData_btn_Click(object sender, EventArgs e)
        {
            //ClearMemory();
            patientName_txt.Text = string.Empty;
            string cmdString = "SELECT * FROM Patient_History";

            if (!string.IsNullOrEmpty(patientID_txt.Text))
            {
                cmdString += " WHERE PID=:id";

                // 2. Select one or more rows using bind parameters
                // Get name of patient and show it
                OracleCommand cmd = new OracleCommand
                {
                    Connection = OrclDatabase.conn,
                    CommandText = $"SELECT name FROM Patient WHERE id = {onlineUser.ID}",
                    CommandType = CommandType.Text
                };

                //cmd.Parameters.Add("pID", int.Parse(onlineUser.ID));
                //cmd.Parameters.Add("pName", patientName_txt.Text);
                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    patientName_txt.Text = (string)dr[0];
                }
                else
                {
                    MessageBox.Show("No patients found with entered ID", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                cmd.Dispose();
                dr.Dispose();
                dr.Close();

                //adapter = new OracleDataAdapter(cmdString, OrclDatabase.oracleConnectionString);
                //adapter.SelectCommand.Parameters.Add("id", patientID_txt.Text);
            }

            adapter = new OracleDataAdapter(cmdString, OrclDatabase.oracleConnectionString);
            adapter.SelectCommand.Parameters.Add("id", patientID_txt.Text);
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
            string[] info_to_delete = {@"DELETE FROM assigned_for WHERE ID = :id",
                @"DELETE FROM drug_history WHERE ID = :id",
                @"DELETE FROM attends WHERE ID = :id",
                @"DELETE FROM preexisting_condition WHERE ID = :id",
                @"DELETE FROM Patient_history WHERE ID = :id",
                @"DELETE FROM Patient WHERE ID = :id" };
            if (deleteResult == DialogResult.Yes)
            {
                for (int i = 0; i < info_to_delete.Length; ++i)
                {
                    try
                    {
                        OracleCommand cmd = new OracleCommand
                        {
                            Connection = OrclDatabase.conn,
                            CommandText = info_to_delete[i],
                            CommandType = CommandType.Text
                        };

                        cmd.Parameters.Add("id", onlineUser.ID);

                        int r = cmd.ExecuteNonQuery();

                        if (r != -1 && i == info_to_delete.Length - 1)
                        {
                            onlineUser = null;
                            this.Dispose();
                            this.Close();
                            MessageBox.Show("User deleted from Database", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {

                    }
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

        // 6. Update using stored procedures
        private void saveNewUserChanges_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userUsername_txt.Text) && !string.IsNullOrWhiteSpace(userUsername_txt.Text) &&
                !string.IsNullOrEmpty(userNewPassword_txt.Text) && !string.IsNullOrWhiteSpace(userNewPassword_txt.Text) &&
                !string.IsNullOrEmpty(userConfirmNewPassword_txt.Text) && !string.IsNullOrWhiteSpace(userConfirmNewPassword_txt.Text))
            {
                if (userNewPassword_txt.Text == userConfirmNewPassword_txt.Text)
                {
                    OracleCommand cmd = new OracleCommand
                    {
                        Connection = OrclDatabase.conn,
                        CommandText = (onlineUser.GetType() == typeof(Doctor) || onlineUser.GetType() == typeof(Nurse)) ?
                                        "UpdateStaffData" : "UpdateUserData",
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add("ID", int.Parse(onlineUser.ID));
                    cmd.Parameters.Add("newUsername", userUsername_txt.Text);
                    cmd.Parameters.Add("newPassword", userNewPassword_txt.Text);

                    int result = cmd.ExecuteNonQuery();

                    if (result == -1)
                    {
                        MessageBox.Show("User's new data updated Successfully", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Check password again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Check missing data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewUserData_btn_Click(object sender, EventArgs e)
        {
            userDataPanel.Visible = !userDataPanel.Visible;
            viewUserData_btn.Text = userDataPanel.Visible == false ? "View my Data" : "Hide my Data";

            userID_txt.Text = onlineUser.ID;
            userName_txt.Text = onlineUser.name;
            userUsername_txt.Text = onlineUser.userName;
        }

        private void showAppointments_btn_Click(object sender, EventArgs e)
        {
            AppointmentsForm appointmentsForm = new AppointmentsForm(onlineUser);
            appointmentsForm.Show();
        }

        private void viewReports_btn_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm(reportsComboBox.SelectedItem.ToString());
            reportsForm.Show();
        }

        private void findFloorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindFloorForm form = new FindFloorForm();
            form.Show();
        }

        #endregion

        #region Helper Methods
        // 3. Delete rows (without procedures)
        private void DeleteStaffUser()
        {
            OracleCommand cmd = new OracleCommand
            {
                Connection = OrclDatabase.conn,
                CommandText = "DeleteDoctorData",
                CommandType = CommandType.StoredProcedure
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
