using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.EntityClient;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Hospital_Management_System.ProjectAssignments
{
    public partial class Form2 : Form
    {
        Entities entities;

        public Form2()
        {
            InitializeComponent();
            entities = new Entities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int patientID = int.Parse(ID_txt.Text);
            var query = from IDs in entities.PATIENTs where IDs.ID == patientID select IDs;
            PATIENT p = query.Single();

            name_txt.Text = p.NAME;
            username_txt.Text = p.USERNAME;
            contact_txt.Text = p.CONTACT_NO;
            age_txt.Text = p.AGE.ToString();
            gender_txt.Text = p.GENDER;
        }
    }
}
