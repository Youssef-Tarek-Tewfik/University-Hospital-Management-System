using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using University_Hospital_Management_System.ProjectForms;

namespace University_Hospital_Management_System.ProjectClasses
{
    public class OrclDatabase
    {
        private string oracleConnectionString = "Data Source=orcl; User ID=scott; Password=tiger;";
        public static OracleConnection conn;

        public OrclDatabase()
        {
            conn = new OracleConnection(oracleConnectionString);
            conn.Open();
        }

        /// <summary>
        /// Sign in functionality
        /// </summary>
        /// <param name="usernameEntered"> The username entered in textbox </param>
        /// <param name="passwordEntered"> The password entered in textbox </param>
        /// <param name="userType"> Current User Type entering the system </param>
        public static void SignInUser(string usernameEntered, string passwordEntered, string userType)
        {
            OracleCommand cmd = new OracleCommand
            {
                Connection = conn,
                CommandText = $"SELECT Username, Password FROM {userType} WHERE Username=:usrname AND Password=:pass",
                CommandType = CommandType.Text,
            };
            
            cmd.Parameters.Add("usrname", usernameEntered);
            cmd.Parameters.Add("pass", passwordEntered);
            OracleDataReader reader = cmd.ExecuteReader();

            // Check if only 1 user is found
            if (reader.Read())
            {
                MessageBox.Show($"{userType} User found, Signing in...");
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("No user found.");
            }

            reader.Dispose();
            reader.Close();
        }

        // 3. Insert rows (without procedures)
        public static void RegisterNewUser(string name, string username, string password, string specialty, string gender, string type, string isPractitionerOrResident)
        {
            OracleCommand cmd = new OracleCommand
            {
                Connection = conn,
                CommandText = "Insert INTO Staff VALUES (StaffIDSeq.nextval, :name, :username, :password, :specialty, :gender)",
                CommandType = CommandType.Text,
            };

            cmd.Parameters.Add("name", name);
            cmd.Parameters.Add("username", username);
            cmd.Parameters.Add("password", password);
            cmd.Parameters.Add("specialty", specialty);
            cmd.Parameters.Add("gender", gender);

            int registerQueryResult = cmd.ExecuteNonQuery();
            int setTypeQueryResult = SetUserType(type, isPractitionerOrResident);

            if (registerQueryResult != -1 && setTypeQueryResult != -1)
            {
                MessageBox.Show($"New {type} registered.");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        /// <summary>
        /// Sets the user as Doctor, Patient or Nurse
        /// </summary>
        /// <param name="type"> The type of new registered user </param>
        /// <param name="isPractitionerOrResident"> Is the Doctor or Nurse a Practitioner or Resident or not respectively </param>
        /// <returns></returns>
        private static int SetUserType(string type, string isPractitionerOrResident)
        {
            OracleCommand cmd = new OracleCommand
            {
                Connection = conn,
                CommandText = $"Insert INTO {type} VALUES (StaffIDSeq.currval, :YesOrNo);",
                CommandType = CommandType.Text,
            };

            cmd.Parameters.Add("YesOrNo", isPractitionerOrResident);

            int queryResult = cmd.ExecuteNonQuery();
            return queryResult;
        }
    }
}
