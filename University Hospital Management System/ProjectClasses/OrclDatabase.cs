using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

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
        public static void SignInUser(string usernameEntered, string passwordEntered)
        {
            OracleCommand cmd = new OracleCommand
            {
                Connection = conn,
                CommandText = "SELECT Username, Password FROM Staff WHERE Username=:usrname AND Password=:pass",
                CommandType = CommandType.Text,
            };

            cmd.Parameters.Add("usrname", usernameEntered);
            cmd.Parameters.Add("pass", passwordEntered);
            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("User found, Signing in...");
            }
            else
            {
                MessageBox.Show("No user found.");
            }

            reader.Dispose();
            reader.Close();
        }


        public static void RegisterNewUser(string name, string username, string password, string specialty, string gender)
        {
            OracleCommand cmd = new OracleCommand
            {
                Connection = conn,
                CommandText = "Insert INTO Staff VALUES (9, :name, :username, :password, :specialty, :gender)",
                CommandType = CommandType.Text,
            };

            cmd.Parameters.Add("name", name);
            cmd.Parameters.Add("username", username);
            cmd.Parameters.Add("password", password);
            cmd.Parameters.Add("specialty", specialty);
            cmd.Parameters.Add("gender", gender);
            int r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show("New user registered.");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void SetUserType()
        {

        }
    }
}
