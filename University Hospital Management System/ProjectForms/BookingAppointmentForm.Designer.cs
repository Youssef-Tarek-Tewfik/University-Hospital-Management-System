namespace University_Hospital_Management_System.ProjectForms
{
    partial class BookingAppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.appointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.specialtyComboBox = new System.Windows.Forms.ComboBox();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.bookAppointment_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fees_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Specialty :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Doctor :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select time :";
            // 
            // appointmentDatePicker
            // 
            this.appointmentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.appointmentDatePicker.Location = new System.Drawing.Point(159, 201);
            this.appointmentDatePicker.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.appointmentDatePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.appointmentDatePicker.Name = "appointmentDatePicker";
            this.appointmentDatePicker.Size = new System.Drawing.Size(95, 20);
            this.appointmentDatePicker.TabIndex = 3;
            // 
            // specialtyComboBox
            // 
            this.specialtyComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialtyComboBox.FormattingEnabled = true;
            this.specialtyComboBox.Items.AddRange(new object[] {
            "Surgery",
            "Radiology",
            "Dermatology",
            "Neurology",
            "Cardiology",
            "Pediatrics"});
            this.specialtyComboBox.Location = new System.Drawing.Point(17, 40);
            this.specialtyComboBox.Name = "specialtyComboBox";
            this.specialtyComboBox.Size = new System.Drawing.Size(183, 29);
            this.specialtyComboBox.TabIndex = 4;
            this.specialtyComboBox.SelectedIndexChanged += new System.EventHandler(this.specialtyComboBox_SelectedIndexChanged);
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(17, 134);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(183, 29);
            this.doctorComboBox.TabIndex = 5;
            this.doctorComboBox.SelectedIndexChanged += new System.EventHandler(this.doctorComboBox_SelectedIndexChanged);
            // 
            // bookAppointment_btn
            // 
            this.bookAppointment_btn.Location = new System.Drawing.Point(39, 409);
            this.bookAppointment_btn.Name = "bookAppointment_btn";
            this.bookAppointment_btn.Size = new System.Drawing.Size(126, 45);
            this.bookAppointment_btn.TabIndex = 6;
            this.bookAppointment_btn.Text = "Book Appointment";
            this.bookAppointment_btn.UseVisualStyleBackColor = true;
            this.bookAppointment_btn.Click += new System.EventHandler(this.bookAppointment_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fees :";
            // 
            // fees_txt
            // 
            this.fees_txt.Enabled = false;
            this.fees_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fees_txt.Location = new System.Drawing.Point(88, 258);
            this.fees_txt.Name = "fees_txt";
            this.fees_txt.Size = new System.Drawing.Size(112, 32);
            this.fees_txt.TabIndex = 8;
            // 
            // BookingAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 568);
            this.Controls.Add(this.fees_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bookAppointment_btn);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.specialtyComboBox);
            this.Controls.Add(this.appointmentDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "BookingAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Hospital Management System - Book new Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker appointmentDatePicker;
        private System.Windows.Forms.ComboBox specialtyComboBox;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.Button bookAppointment_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fees_txt;
    }
}