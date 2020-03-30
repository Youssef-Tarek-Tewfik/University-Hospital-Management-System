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
        private readonly string oracleConnectionString = "Data Source=orcl; User ID=scott; Password=tiger;";
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
            string staffType = string.Empty;
            string isPractitionerOrResident = string.Empty;

            OracleCommand cmd = new OracleCommand
            {
                Connection = conn,
                CommandText = $"SELECT * FROM {userType} WHERE Username=:usrname AND Password=:pass",
                CommandType = CommandType.Text,
            };
            
            cmd.Parameters.Add("usrname", usernameEntered);
            cmd.Parameters.Add("pass", passwordEntered);
            OracleDataReader dataReader = cmd.ExecuteReader();

            // Check if only 1 user is found
            if (dataReader.Read())
            {
                if (userType == "Staff")
                {
                    staffType = CheckIfUserIsDoctor((int)dataReader[0], out isPractitionerOrResident);
                }

                MessageBox.Show($"{(userType == "Staff" ? staffType : userType)} User found, Signing in...");
                SystemPersona onlineUser;

                switch (staffType)
                {
                    case "Doctor":
                        onlineUser = new Doctor((string)dataReader[1], (string)dataReader[2], (string)dataReader[3], dataReader[0].ToString(), (string)dataReader[5], (string)dataReader[4], isPractitionerOrResident == "Y" ? true : false);
                        break;

                    case "Nurse":
                        onlineUser = new Nurse((string)dataReader[1], (string)dataReader[2], (string)dataReader[3], dataReader[0].ToString(), (string)dataReader[5], (string)dataReader[4], isPractitionerOrResident == "Y" ? true : false);
                        break;

                    default:
                        onlineUser = new Patient((string)dataReader[2], (string)dataReader[3], (string)dataReader[4], dataReader[0].ToString(), (string)dataReader[7], (string)dataReader[6], (string)dataReader[5]);
                        break;
                }

                MainForm mainForm = new MainForm(onlineUser);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("No user found.");
            }

            cmd.Dispose();
            dataReader.Dispose();
            dataReader.Close();
        }

        // 3. Insert rows (without procedures)
        public static void RegisterNewUser(string name, string username, string password, string specialty, string gender, string type, string isPractitionerOrResident)
        {
            OracleCommand cmd = new OracleCommand
            {
                Connection = conn,
                CommandText = "INSERT INTO Staff VALUES (StaffIDSeq.nextval, :name, :username, :password, :specialty, :gender)",
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
                CommandText = $"INSERT INTO {type} VALUES (StaffIDSeq.currval, :YesOrNo)",
                CommandType = CommandType.Text,
            };

            cmd.Parameters.Add("YesOrNo", isPractitionerOrResident);

            int queryResult = cmd.ExecuteNonQuery();
            return queryResult;
        }

        private static string CheckIfUserIsDoctor(int ID, out string isPractitionerOrResident)
        {
            OracleCommand cmd = new OracleCommand
            {
                Connection = conn,
                CommandText = $"SELECT * FROM Doctor WHERE ID={ID}",
                CommandType = CommandType.Text,
            };

            OracleDataReader IDreader = cmd.ExecuteReader();

            // Check if only 1 user is found
            if (IDreader.Read())
            {
                isPractitionerOrResident = (string)IDreader[1];
                cmd.Dispose();
                IDreader.Dispose();
                IDreader.Close();
                return "Doctor";
            }

            isPractitionerOrResident = ""; //(string)IDreader[1];
            return "Nurse";
        }
    }
}
