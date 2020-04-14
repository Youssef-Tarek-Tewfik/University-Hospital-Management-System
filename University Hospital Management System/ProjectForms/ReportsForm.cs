using System;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using University_Hospital_Management_System.ProjectReports;

namespace University_Hospital_Management_System.ProjectForms
{
    public partial class ReportsForm : Form
    {
        string ReportName;
        AppointmentsReport appointmentsReport;

        public ReportsForm(string reportName)
        {
            InitializeComponent();
            ReportName = reportName;
            this.Text += reportName;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            switch (ReportName)
            {
                case "Appointments":
                    appointmentsReport = new AppointmentsReport();
                    panel1.Visible = true;

                    foreach (ParameterDiscreteValue v in appointmentsReport.ParameterFields[0].DefaultValues)
                    {
                        appointmentTypeComboBox.Items.Add(v.Value);
                    }

                    break;

                //case "":
                //    panel1.Visible = true; break;

                //case "":
                //    panel1.Visible = true; break;

                default: break;
            }

        }

        private void generateReport_btn_Click(object sender, EventArgs e)
        {
            switch (ReportName)
            {
                case "Appointments":
                    appointmentsReport.SetParameterValue(0, appointmentTypeComboBox.SelectedItem.ToString());
                    crystalReportViewer.ReportSource = appointmentsReport; break;

                //case "":
                //    panel1.Visible = true; break;

                //case "":
                //    panel1.Visible = true; break;

                default:
                    break;
            }
        }

    }
}
