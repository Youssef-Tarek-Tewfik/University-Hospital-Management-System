using System;
using System.Windows.Forms;
using University_Hospital_Management_System.ProjectClasses;

namespace University_Hospital_Management_System.ProjectForms
{
    public partial class RegistrationForm : Form
    {
        string selectedGender;
        string userType;
        string isPractitionerOrResident;

        public RegistrationForm()
        {
            selectedGender = string.Empty;
            userType = string.Empty;
            //isPractitionerOrResident = string.Empty;
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (CheckIfTextValid())
            {
                if (doctor_radio.Checked || nurse_radio.Checked)
                {
                    OrclDatabase.RegisterNewStaffUser(newName_txt.Text, newUserName_txt.Text, newPassword_txt.Text, specialty_comboBox.SelectedItem.ToString(), selectedGender, userType, isPractitionerOrResident);
                }
                else if (patient_radio.Checked)
                {
                    OrclDatabase.RegisterNewPatientUser(newName_txt.Text, newUserName_txt.Text, newPassword_txt.Text, contactNumber_txt.Text, age_txt.Text, selectedGender);
                }

                this.Dispose();
                this.Close();
                MessageBox.Show("New user registered in Database", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Gender_CheckedChanged(object sender, EventArgs e)
        {
            selectedGender = ((RadioButton)sender).Text;
        }

        private void IsPractitionerOrResident_CheckedChanged(object sender, EventArgs e)
        {
            isPractitionerOrResident = ((RadioButton)sender).Text.Substring(0, 1);
        }

        private void UserType_CheckedChanged(object sender, EventArgs e)
        {
            userType = ((RadioButton)sender).Text;

            switch (userType)
            {
                case "Doctor":
                    label6.Visible = true;
                    specialty_comboBox.Visible = true;
                    contactNumber_txt.Enabled = false;
                    age_txt.Enabled = false;
                    groupBox3.Visible = true;
                    groupBox3.Text = "Resident?"; break;

                case "Nurse":
                    label6.Visible = true;
                    specialty_comboBox.Visible = true;
                    contactNumber_txt.Enabled = false;
                    age_txt.Enabled = false;
                    groupBox3.Visible = true;
                    groupBox3.Text = "Practitioner?"; break;

                default:
                    label6.Visible = false;
                    specialty_comboBox.Visible = false;
                    contactNumber_txt.Enabled = true;
                    age_txt.Enabled = true;
                    groupBox3.Visible = false; break;
            }
        }

        private bool CheckIfTextValid()
        {
            if (patient_radio.Checked)
            {
                if (string.IsNullOrEmpty(selectedGender) ||
                    string.IsNullOrEmpty(newName_txt.Text) || string.IsNullOrWhiteSpace(newName_txt.Text) ||
                    string.IsNullOrEmpty(newUserName_txt.Text) || string.IsNullOrWhiteSpace(newUserName_txt.Text) ||
                    string.IsNullOrEmpty(newPassword_txt.Text) || string.IsNullOrWhiteSpace(newPassword_txt.Text) ||
                    string.IsNullOrEmpty(newConfirmedPassword_txt.Text) || string.IsNullOrWhiteSpace(newConfirmedPassword_txt.Text) ||
                    string.IsNullOrEmpty(contactNumber_txt.Text) || string.IsNullOrWhiteSpace(contactNumber_txt.Text) ||
                    string.IsNullOrEmpty(age_txt.Text) || string.IsNullOrWhiteSpace(age_txt.Text))
                {
                    MessageBox.Show("Data is missing.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else if (doctor_radio.Checked || nurse_radio.Checked)
            {
                if (string.IsNullOrEmpty(selectedGender) || string.IsNullOrEmpty(userType) ||
                    string.IsNullOrEmpty(newName_txt.Text) || string.IsNullOrWhiteSpace(newName_txt.Text) ||
                    string.IsNullOrEmpty(newUserName_txt.Text) || string.IsNullOrWhiteSpace(newUserName_txt.Text) ||
                    string.IsNullOrEmpty(newPassword_txt.Text) || string.IsNullOrWhiteSpace(newPassword_txt.Text) ||
                    string.IsNullOrEmpty(newConfirmedPassword_txt.Text) || string.IsNullOrWhiteSpace(newConfirmedPassword_txt.Text) ||
                    specialty_comboBox.SelectedItem == null)
                {
                    MessageBox.Show("Data is missing.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (newPassword_txt.Text != newConfirmedPassword_txt.Text)
            {
                MessageBox.Show("Check password again", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
