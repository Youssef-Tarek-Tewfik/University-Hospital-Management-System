namespace University_Hospital_Management_System.ProjectForms
{
    partial class RegistrationForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.male_radio = new System.Windows.Forms.RadioButton();
            this.female_radio = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.specialty_comboBox = new System.Windows.Forms.ComboBox();
            this.newConfirmedPassword_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newPassword_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newUserName_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newName_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.patient_radio = new System.Windows.Forms.RadioButton();
            this.nurse_radio = new System.Windows.Forms.RadioButton();
            this.doctor_radio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.specialty_comboBox);
            this.groupBox1.Controls.Add(this.newConfirmedPassword_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.newPassword_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.newUserName_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.newName_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.register_btn);
            this.groupBox1.Controls.Add(this.patient_radio);
            this.groupBox1.Controls.Add(this.nurse_radio);
            this.groupBox1.Controls.Add(this.doctor_radio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(48, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 455);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign Up";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Underline);
            this.groupBox3.Location = new System.Drawing.Point(281, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 76);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Practitioner?";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.radioButton2.Location = new System.Drawing.Point(90, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.IsPractitionerOrResident_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.radioButton1.Location = new System.Drawing.Point(18, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.IsPractitionerOrResident_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.male_radio);
            this.groupBox2.Controls.Add(this.female_radio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Underline);
            this.groupBox2.Location = new System.Drawing.Point(281, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 59);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // male_radio
            // 
            this.male_radio.AutoSize = true;
            this.male_radio.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.male_radio.Location = new System.Drawing.Point(18, 34);
            this.male_radio.Name = "male_radio";
            this.male_radio.Size = new System.Drawing.Size(55, 21);
            this.male_radio.TabIndex = 16;
            this.male_radio.TabStop = true;
            this.male_radio.Text = "Male";
            this.male_radio.UseVisualStyleBackColor = true;
            this.male_radio.CheckedChanged += new System.EventHandler(this.Gender_CheckedChanged);
            // 
            // female_radio
            // 
            this.female_radio.AutoSize = true;
            this.female_radio.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.female_radio.Location = new System.Drawing.Point(90, 34);
            this.female_radio.Name = "female_radio";
            this.female_radio.Size = new System.Drawing.Size(67, 21);
            this.female_radio.TabIndex = 17;
            this.female_radio.TabStop = true;
            this.female_radio.Text = "Female";
            this.female_radio.UseVisualStyleBackColor = true;
            this.female_radio.CheckedChanged += new System.EventHandler(this.Gender_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Specialty";
            // 
            // specialty_comboBox
            // 
            this.specialty_comboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialty_comboBox.FormattingEnabled = true;
            this.specialty_comboBox.Items.AddRange(new object[] {
            "Surgery",
            "Radiology",
            "Dermatology",
            "Neurology",
            "Cardiology",
            "Pediatrics"});
            this.specialty_comboBox.Location = new System.Drawing.Point(46, 134);
            this.specialty_comboBox.Name = "specialty_comboBox";
            this.specialty_comboBox.Size = new System.Drawing.Size(156, 28);
            this.specialty_comboBox.TabIndex = 13;
            // 
            // newConfirmedPassword_txt
            // 
            this.newConfirmedPassword_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newConfirmedPassword_txt.Location = new System.Drawing.Point(221, 356);
            this.newConfirmedPassword_txt.MaxLength = 50;
            this.newConfirmedPassword_txt.Name = "newConfirmedPassword_txt";
            this.newConfirmedPassword_txt.Size = new System.Drawing.Size(319, 28);
            this.newConfirmedPassword_txt.TabIndex = 12;
            this.newConfirmedPassword_txt.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Confirm password :";
            // 
            // newPassword_txt
            // 
            this.newPassword_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword_txt.Location = new System.Drawing.Point(221, 305);
            this.newPassword_txt.MaxLength = 50;
            this.newPassword_txt.Name = "newPassword_txt";
            this.newPassword_txt.Size = new System.Drawing.Size(319, 28);
            this.newPassword_txt.TabIndex = 10;
            this.newPassword_txt.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password :";
            // 
            // newUserName_txt
            // 
            this.newUserName_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserName_txt.Location = new System.Drawing.Point(221, 251);
            this.newUserName_txt.MaxLength = 50;
            this.newUserName_txt.Name = "newUserName_txt";
            this.newUserName_txt.Size = new System.Drawing.Size(319, 28);
            this.newUserName_txt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username :";
            // 
            // newName_txt
            // 
            this.newName_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newName_txt.Location = new System.Drawing.Point(221, 202);
            this.newName_txt.MaxLength = 50;
            this.newName_txt.Name = "newName_txt";
            this.newName_txt.Size = new System.Drawing.Size(319, 28);
            this.newName_txt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name :";
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(231, 398);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(119, 51);
            this.register_btn.TabIndex = 4;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // patient_radio
            // 
            this.patient_radio.AutoSize = true;
            this.patient_radio.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_radio.Location = new System.Drawing.Point(185, 76);
            this.patient_radio.Name = "patient_radio";
            this.patient_radio.Size = new System.Drawing.Size(65, 21);
            this.patient_radio.TabIndex = 3;
            this.patient_radio.TabStop = true;
            this.patient_radio.Text = "Patient";
            this.patient_radio.UseVisualStyleBackColor = true;
            this.patient_radio.CheckedChanged += new System.EventHandler(this.UserType_CheckedChanged);
            // 
            // nurse_radio
            // 
            this.nurse_radio.AutoSize = true;
            this.nurse_radio.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurse_radio.Location = new System.Drawing.Point(118, 76);
            this.nurse_radio.Name = "nurse_radio";
            this.nurse_radio.Size = new System.Drawing.Size(61, 21);
            this.nurse_radio.TabIndex = 2;
            this.nurse_radio.TabStop = true;
            this.nurse_radio.Text = "Nurse";
            this.nurse_radio.UseVisualStyleBackColor = true;
            this.nurse_radio.CheckedChanged += new System.EventHandler(this.UserType_CheckedChanged);
            // 
            // doctor_radio
            // 
            this.doctor_radio.AutoSize = true;
            this.doctor_radio.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor_radio.Location = new System.Drawing.Point(46, 76);
            this.doctor_radio.Name = "doctor_radio";
            this.doctor_radio.Size = new System.Drawing.Size(66, 21);
            this.doctor_radio.TabIndex = 1;
            this.doctor_radio.TabStop = true;
            this.doctor_radio.Text = "Doctor";
            this.doctor_radio.UseVisualStyleBackColor = true;
            this.doctor_radio.CheckedChanged += new System.EventHandler(this.UserType_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register as";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 519);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegistrationForm";
            this.Text = "University Hospital Management System - Registration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton patient_radio;
        private System.Windows.Forms.RadioButton nurse_radio;
        private System.Windows.Forms.RadioButton doctor_radio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox newConfirmedPassword_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newPassword_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newUserName_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newName_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox specialty_comboBox;
        private System.Windows.Forms.RadioButton female_radio;
        private System.Windows.Forms.RadioButton male_radio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}