using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using University_Hospital_Management_System.ProjectClasses;

namespace University_Hospital_Management_System.ProjectForms
{
    public partial class AppointmentsForm : Form
    {
        SystemPersona onlineUser;

        public AppointmentsForm(SystemPersona loggedinUser)
        {
            onlineUser = loggedinUser;
            InitializeComponent();
        }

        // 5. Select multiple rows using stored procedure
        private void AppointmentsForm_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand
            {
                Connection = OrclDatabase.conn,
                CommandText = "GetAppointments",
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("userID", onlineUser.ID);
            cmd.Parameters.Add("CID", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            int i = 0;

            while (dr.Read())
            {
                appointmentsDataGridView.RowCount++;
                appointmentsDataGridView.Rows[i].Cells[0].Value = dr[0];
                appointmentsDataGridView.Rows[i].Cells[1].Value = dr[1];
                appointmentsDataGridView.Rows[i].Cells[2].Value = dr[2];
                appointmentsDataGridView.Rows[i].Cells[3].Value = dr[3];
                appointmentsDataGridView.Rows[i].Cells[4].Value = dr[4];
                appointmentsDataGridView.Rows[i].Cells[5].Value = dr[5];
                i++;
            }

            cmd.Dispose();
            dr.Dispose();
            dr.Close();
        }

        // 6. Update & Delete rows using stored procedures
        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            if (appointmentsDataGridView.SelectedCells.Count > 0)
            {
                DialogResult deleteResult = MessageBox.Show("Are you sure to cancel the selected Appointment? This operation cannot be returned!", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteResult == DialogResult.Yes)
                {
                    OracleCommand cmd = new OracleCommand
                    {
                        Connection = OrclDatabase.conn,
                        CommandText = "CancelAppointment",
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add("userID", onlineUser.ID);
                    cmd.Parameters.Add("appID", appointmentsDataGridView.CurrentCell.OwningRow.Cells[0].Value);

                    int result = cmd.ExecuteNonQuery();

                    if (result == -1)
                    {
                        appointmentsDataGridView.Rows.RemoveAt(appointmentsDataGridView.CurrentCell.OwningRow.Index);
                        MessageBox.Show("Appointment Canceled", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a row first to cancel", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
