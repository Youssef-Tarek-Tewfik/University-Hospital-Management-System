using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using University_Hospital_Management_System.ProjectClasses;

namespace University_Hospital_Management_System.ProjectForms
{
    public partial class FindFloorForm : Form
    {
        public FindFloorForm()
        {
            InitializeComponent();
        }

        // 4. Select ONE row from DB using stored Procedures (without using sysRefCursor [use out parameters of number data type only])
        private void search_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand
            {
                Connection = OrclDatabase.conn,
                CommandText = "GetFloorNumber",
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("roomID", roomID_txt.Text);
            OracleParameter floorNoParam = cmd.Parameters.Add("floorNo", OracleDbType.Int32, ParameterDirection.Output);
            int result = cmd.ExecuteNonQuery();

            if (result == -1)
            {
                floorNo_txt.Text = floorNoParam.Value.ToString();
            }
            else
            {
                MessageBox.Show("No room found. Enter an existing ID", "Nothing found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
