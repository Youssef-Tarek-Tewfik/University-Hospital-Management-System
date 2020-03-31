using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using University_Hospital_Management_System.ProjectClasses;

namespace University_Hospital_Management_System.ProjectForms
{
    public partial class BookingAppointmentForm : Form
    {
        private readonly Random randomFees;

        public BookingAppointmentForm()
        {
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
            if (specialtyComboBox.SelectedItem != null && doctorComboBox.SelectedText != null)
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
                int r = cmd.ExecuteNonQuery();

                if (r == -1)
                {
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
    }
}
