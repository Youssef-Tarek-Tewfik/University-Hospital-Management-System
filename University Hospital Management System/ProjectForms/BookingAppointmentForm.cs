using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using University_Hospital_Management_System.ProjectClasses;

namespace University_Hospital_Management_System.ProjectForms
{
    public partial class BookingAppointmentForm : Form
    {
        private readonly Random randomFees;
        SystemPersona onlineUser;

        public BookingAppointmentForm(SystemPersona loggedinUser)
        {
            onlineUser = loggedinUser;
            randomFees = new Random();
            InitializeComponent();
        }

        private void specialtyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            doctorComboBox.Items.Clear();

            OracleCommand cmd = new OracleCommand
            {
                Connection = OrclDatabase.conn,
                CommandText = "GetAllDoctorsOfSpecialty",
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("spec", specialtyComboBox.SelectedItem.ToString());
            cmd.Parameters.Add("name", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                doctorComboBox.Items.Add(dr[0]);
            }

            dr.Dispose();
            cmd.Dispose();
            dr.Close();
        }

        private void bookAppointment_btn_Click(object sender, EventArgs e)
        {
            if (specialtyComboBox.SelectedItem != null && doctorComboBox.SelectedItem != null && roomTypeComboBox.SelectedItem != null)
            {
                OracleCommand cmd = new OracleCommand
                {
                    Connection = OrclDatabase.conn,
                    CommandText = "AddNewAppointment",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("atime", appointmentDatePicker.Value.ToLongTimeString());
                cmd.Parameters.Add("adate", appointmentDatePicker.Value.ToShortDateString());
                cmd.Parameters.Add("fees", fees_txt.Text);

                // Get Room ID and Staff ID assigned for new appointment
                OracleCommand cmd2 = new OracleCommand
                {
                    Connection = OrclDatabase.conn,
                    CommandText = "SELECT r.ID, s.ID, s.Name FROM Room r, Staff s WHERE r.Type=:type AND r.Status='Not Scheduled' AND s.Name=:name",
                    CommandType = CommandType.Text
                };

                cmd2.Parameters.Add("type", roomTypeComboBox.SelectedItem.ToString());
                cmd2.Parameters.Add("name", doctorComboBox.SelectedItem.ToString());

                int r = cmd.ExecuteNonQuery();
                OracleDataReader dr = cmd2.ExecuteReader();

                if (r == -1)
                {
                    if (dr.Read())
                    {
                        InsertIntoAttendsTable(dr[1].ToString(), dr[0].ToString());
                    }
                    else
                    {
                        MessageBox.Show("No room found. Try another type.");
                        return;
                    }

                    this.Dispose();
                    this.Close();
                    MessageBox.Show("Appointment booked Successfully", "Booking Operation Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                cmd.Dispose();
            }
            else
            {
                MessageBox.Show("Select data first", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void doctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fees_txt.Text = randomFees.Next(200, 2000).ToString();
        }

        private void InsertIntoAttendsTable(string staffID, string roomID)
        {
            OracleCommand cmd = new OracleCommand
            {
                Connection = OrclDatabase.conn,
                CommandText = $"INSERT INTO Attends VALUES ({onlineUser.ID}, {staffID}, {roomID}, AppointmentIDSeq.currval)",
                CommandType = CommandType.Text
            };

            OracleCommand cmd2 = new OracleCommand
            { 
                Connection = OrclDatabase.conn,
                CommandText = "UpdateRoomStatus",
                CommandType = CommandType.StoredProcedure
            };

            cmd2.Parameters.Add("RoomID", int.Parse(roomID));
            cmd2.Parameters.Add("newStatus", "Scheduled");
            cmd2.Parameters.Add("staffID", int.Parse(staffID));
            cmd2.Parameters.Add("patientID", int.Parse(onlineUser.ID));

            int insertQueryResult = cmd.ExecuteNonQuery();
            int updateQueryResult = cmd2.ExecuteNonQuery();

            if (insertQueryResult != -1 && updateQueryResult == -1)
            {
                MessageBox.Show("Inserted into attends table and updated room status");
            }
        }
        
    }
}
