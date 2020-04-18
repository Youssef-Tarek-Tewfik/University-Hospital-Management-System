namespace University_Hospital_Management_System.ProjectForms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.viewUserData_btn = new System.Windows.Forms.Button();
            this.showPatientsData_btn = new System.Windows.Forms.Button();
            this.patientsDataPanel = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.saveChanges_btn = new System.Windows.Forms.Button();
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchPatientsData_btn = new System.Windows.Forms.Button();
            this.patientID_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.patientName_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookAppointment_btn = new System.Windows.Forms.Button();
            this.showRoomsData_btn = new System.Windows.Forms.Button();
            this.roomsDataPanel = new System.Windows.Forms.Panel();
            this.addRoomData_btn = new System.Windows.Forms.Button();
            this.roomType_txt = new System.Windows.Forms.TextBox();
            this.roomFloorNumber_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.roomsDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.userDataPanel = new System.Windows.Forms.Panel();
            this.saveNewUserChanges_btn = new System.Windows.Forms.Button();
            this.userConfirmNewPassword_txt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.userNewPassword_txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.userUsername_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.userName_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.userID_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.showAppointments_btn = new System.Windows.Forms.Button();
            this.viewReports_btn = new System.Windows.Forms.Button();
            this.reportsComboBox = new System.Windows.Forms.ComboBox();
            this.findFloorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.patientsDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            this.roomsDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).BeginInit();
            this.userDataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.findFloorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem1,
            this.deleteAccountToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.optionsToolStripMenuItem1.Text = "Sign Out";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.optionsToolStripMenuItem1_Click);
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteAccountToolStripMenuItem.Text = "Delete Account";
            this.deleteAccountToolStripMenuItem.Click += new System.EventHandler(this.deleteAccountToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome, ";
            // 
            // viewUserData_btn
            // 
            this.viewUserData_btn.Location = new System.Drawing.Point(17, 105);
            this.viewUserData_btn.Name = "viewUserData_btn";
            this.viewUserData_btn.Size = new System.Drawing.Size(128, 58);
            this.viewUserData_btn.TabIndex = 2;
            this.viewUserData_btn.Text = "View my Data";
            this.viewUserData_btn.UseVisualStyleBackColor = true;
            this.viewUserData_btn.Click += new System.EventHandler(this.viewUserData_btn_Click);
            // 
            // showPatientsData_btn
            // 
            this.showPatientsData_btn.Location = new System.Drawing.Point(17, 349);
            this.showPatientsData_btn.Name = "showPatientsData_btn";
            this.showPatientsData_btn.Size = new System.Drawing.Size(128, 58);
            this.showPatientsData_btn.TabIndex = 0;
            this.showPatientsData_btn.Text = "Show Patients Data";
            this.showPatientsData_btn.UseVisualStyleBackColor = true;
            this.showPatientsData_btn.Click += new System.EventHandler(this.showPatientsData_btn_Click);
            // 
            // patientsDataPanel
            // 
            this.patientsDataPanel.Controls.Add(this.radioButton3);
            this.patientsDataPanel.Controls.Add(this.radioButton2);
            this.patientsDataPanel.Controls.Add(this.radioButton1);
            this.patientsDataPanel.Controls.Add(this.saveChanges_btn);
            this.patientsDataPanel.Controls.Add(this.patientsDataGridView);
            this.patientsDataPanel.Controls.Add(this.searchPatientsData_btn);
            this.patientsDataPanel.Controls.Add(this.patientID_txt);
            this.patientsDataPanel.Controls.Add(this.label4);
            this.patientsDataPanel.Controls.Add(this.patientName_txt);
            this.patientsDataPanel.Controls.Add(this.label3);
            this.patientsDataPanel.Controls.Add(this.label2);
            this.patientsDataPanel.Location = new System.Drawing.Point(420, 27);
            this.patientsDataPanel.Name = "patientsDataPanel";
            this.patientsDataPanel.Size = new System.Drawing.Size(506, 538);
            this.patientsDataPanel.TabIndex = 4;
            this.patientsDataPanel.Visible = false;
            this.patientsDataPanel.VisibleChanged += new System.EventHandler(this.patientsDataPanel_VisibleChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(286, 137);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(132, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "PreExisting_Conditions";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(156, 137);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Drug_History";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 137);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Patient_History";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // saveChanges_btn
            // 
            this.saveChanges_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChanges_btn.Location = new System.Drawing.Point(325, 497);
            this.saveChanges_btn.Name = "saveChanges_btn";
            this.saveChanges_btn.Size = new System.Drawing.Size(169, 38);
            this.saveChanges_btn.TabIndex = 3;
            this.saveChanges_btn.Text = "Save Changes";
            this.saveChanges_btn.UseVisualStyleBackColor = true;
            this.saveChanges_btn.Click += new System.EventHandler(this.saveChanges_btn_Click);
            // 
            // patientsDataGridView
            // 
            this.patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGridView.Location = new System.Drawing.Point(3, 160);
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.Size = new System.Drawing.Size(500, 334);
            this.patientsDataGridView.TabIndex = 6;
            // 
            // searchPatientsData_btn
            // 
            this.searchPatientsData_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPatientsData_btn.Location = new System.Drawing.Point(311, 90);
            this.searchPatientsData_btn.Name = "searchPatientsData_btn";
            this.searchPatientsData_btn.Size = new System.Drawing.Size(102, 31);
            this.searchPatientsData_btn.TabIndex = 2;
            this.searchPatientsData_btn.Text = "Search";
            this.searchPatientsData_btn.UseVisualStyleBackColor = true;
            this.searchPatientsData_btn.Click += new System.EventHandler(this.searchPatientsData_btn_Click);
            // 
            // patientID_txt
            // 
            this.patientID_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.patientID_txt.Location = new System.Drawing.Point(124, 90);
            this.patientID_txt.MaxLength = 10;
            this.patientID_txt.Name = "patientID_txt";
            this.patientID_txt.Size = new System.Drawing.Size(62, 29);
            this.patientID_txt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Patient ID :";
            // 
            // patientName_txt
            // 
            this.patientName_txt.Enabled = false;
            this.patientName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.patientName_txt.Location = new System.Drawing.Point(97, 49);
            this.patientName_txt.MaxLength = 70;
            this.patientName_txt.Name = "patientName_txt";
            this.patientName_txt.Size = new System.Drawing.Size(397, 29);
            this.patientName_txt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Patients Data History :";
            // 
            // bookAppointment_btn
            // 
            this.bookAppointment_btn.Location = new System.Drawing.Point(17, 230);
            this.bookAppointment_btn.Name = "bookAppointment_btn";
            this.bookAppointment_btn.Size = new System.Drawing.Size(128, 58);
            this.bookAppointment_btn.TabIndex = 5;
            this.bookAppointment_btn.Text = "Book an Appointment";
            this.bookAppointment_btn.UseVisualStyleBackColor = true;
            this.bookAppointment_btn.Click += new System.EventHandler(this.bookAppointment_btn_Click);
            // 
            // showRoomsData_btn
            // 
            this.showRoomsData_btn.Location = new System.Drawing.Point(17, 290);
            this.showRoomsData_btn.Name = "showRoomsData_btn";
            this.showRoomsData_btn.Size = new System.Drawing.Size(128, 58);
            this.showRoomsData_btn.TabIndex = 6;
            this.showRoomsData_btn.Text = "Show Rooms Data";
            this.showRoomsData_btn.UseVisualStyleBackColor = true;
            this.showRoomsData_btn.Click += new System.EventHandler(this.showRoomsData_btn_Click);
            // 
            // roomsDataPanel
            // 
            this.roomsDataPanel.Controls.Add(this.addRoomData_btn);
            this.roomsDataPanel.Controls.Add(this.roomType_txt);
            this.roomsDataPanel.Controls.Add(this.roomFloorNumber_txt);
            this.roomsDataPanel.Controls.Add(this.label9);
            this.roomsDataPanel.Controls.Add(this.label8);
            this.roomsDataPanel.Controls.Add(this.label6);
            this.roomsDataPanel.Controls.Add(this.roomsDataGridView);
            this.roomsDataPanel.Controls.Add(this.label5);
            this.roomsDataPanel.Location = new System.Drawing.Point(420, 27);
            this.roomsDataPanel.Name = "roomsDataPanel";
            this.roomsDataPanel.Size = new System.Drawing.Size(506, 538);
            this.roomsDataPanel.TabIndex = 7;
            this.roomsDataPanel.Visible = false;
            this.roomsDataPanel.VisibleChanged += new System.EventHandler(this.roomsDataPanel_VisibleChanged);
            // 
            // addRoomData_btn
            // 
            this.addRoomData_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoomData_btn.Location = new System.Drawing.Point(325, 452);
            this.addRoomData_btn.Name = "addRoomData_btn";
            this.addRoomData_btn.Size = new System.Drawing.Size(118, 72);
            this.addRoomData_btn.TabIndex = 10;
            this.addRoomData_btn.Text = "Add Room Data";
            this.addRoomData_btn.UseVisualStyleBackColor = true;
            this.addRoomData_btn.Click += new System.EventHandler(this.addRoomData_btn_Click);
            // 
            // roomType_txt
            // 
            this.roomType_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomType_txt.Location = new System.Drawing.Point(134, 471);
            this.roomType_txt.MaxLength = 20;
            this.roomType_txt.Name = "roomType_txt";
            this.roomType_txt.Size = new System.Drawing.Size(155, 29);
            this.roomType_txt.TabIndex = 9;
            // 
            // roomFloorNumber_txt
            // 
            this.roomFloorNumber_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomFloorNumber_txt.Location = new System.Drawing.Point(134, 504);
            this.roomFloorNumber_txt.MaxLength = 2;
            this.roomFloorNumber_txt.Name = "roomFloorNumber_txt";
            this.roomFloorNumber_txt.Size = new System.Drawing.Size(88, 29);
            this.roomFloorNumber_txt.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Room Type :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Floor # :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Add new Room :";
            // 
            // roomsDataGridView
            // 
            this.roomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Floor,
            this.Type,
            this.Status});
            this.roomsDataGridView.Location = new System.Drawing.Point(8, 69);
            this.roomsDataGridView.Name = "roomsDataGridView";
            this.roomsDataGridView.Size = new System.Drawing.Size(486, 368);
            this.roomsDataGridView.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Floor
            // 
            this.Floor.HeaderText = "Floor";
            this.Floor.Name = "Floor";
            this.Floor.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Rooms Data :";
            // 
            // userDataPanel
            // 
            this.userDataPanel.Controls.Add(this.saveNewUserChanges_btn);
            this.userDataPanel.Controls.Add(this.userConfirmNewPassword_txt);
            this.userDataPanel.Controls.Add(this.label14);
            this.userDataPanel.Controls.Add(this.userNewPassword_txt);
            this.userDataPanel.Controls.Add(this.label13);
            this.userDataPanel.Controls.Add(this.userUsername_txt);
            this.userDataPanel.Controls.Add(this.label12);
            this.userDataPanel.Controls.Add(this.userName_txt);
            this.userDataPanel.Controls.Add(this.label11);
            this.userDataPanel.Controls.Add(this.userID_txt);
            this.userDataPanel.Controls.Add(this.label10);
            this.userDataPanel.Controls.Add(this.label7);
            this.userDataPanel.Location = new System.Drawing.Point(313, 27);
            this.userDataPanel.Name = "userDataPanel";
            this.userDataPanel.Size = new System.Drawing.Size(506, 538);
            this.userDataPanel.TabIndex = 8;
            this.userDataPanel.Visible = false;
            // 
            // saveNewUserChanges_btn
            // 
            this.saveNewUserChanges_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNewUserChanges_btn.Location = new System.Drawing.Point(167, 256);
            this.saveNewUserChanges_btn.Name = "saveNewUserChanges_btn";
            this.saveNewUserChanges_btn.Size = new System.Drawing.Size(135, 49);
            this.saveNewUserChanges_btn.TabIndex = 13;
            this.saveNewUserChanges_btn.Text = "Save Changes";
            this.saveNewUserChanges_btn.UseVisualStyleBackColor = true;
            this.saveNewUserChanges_btn.Click += new System.EventHandler(this.saveNewUserChanges_btn_Click);
            // 
            // userConfirmNewPassword_txt
            // 
            this.userConfirmNewPassword_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.userConfirmNewPassword_txt.Location = new System.Drawing.Point(211, 201);
            this.userConfirmNewPassword_txt.MaxLength = 30;
            this.userConfirmNewPassword_txt.Name = "userConfirmNewPassword_txt";
            this.userConfirmNewPassword_txt.Size = new System.Drawing.Size(199, 27);
            this.userConfirmNewPassword_txt.TabIndex = 12;
            this.userConfirmNewPassword_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userConfirmNewPassword_txt.UseSystemPasswordChar = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(185, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "Confirm New Password :";
            // 
            // userNewPassword_txt
            // 
            this.userNewPassword_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.userNewPassword_txt.Location = new System.Drawing.Point(211, 164);
            this.userNewPassword_txt.MaxLength = 30;
            this.userNewPassword_txt.Name = "userNewPassword_txt";
            this.userNewPassword_txt.Size = new System.Drawing.Size(199, 27);
            this.userNewPassword_txt.TabIndex = 10;
            this.userNewPassword_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNewPassword_txt.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "New Password :";
            // 
            // userUsername_txt
            // 
            this.userUsername_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.userUsername_txt.Location = new System.Drawing.Point(115, 120);
            this.userUsername_txt.Name = "userUsername_txt";
            this.userUsername_txt.Size = new System.Drawing.Size(174, 27);
            this.userUsername_txt.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Username :";
            // 
            // userName_txt
            // 
            this.userName_txt.Enabled = false;
            this.userName_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.userName_txt.Location = new System.Drawing.Point(86, 82);
            this.userName_txt.MaxLength = 50;
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.ReadOnly = true;
            this.userName_txt.Size = new System.Drawing.Size(291, 27);
            this.userName_txt.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Name :";
            // 
            // userID_txt
            // 
            this.userID_txt.Enabled = false;
            this.userID_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.userID_txt.Location = new System.Drawing.Point(57, 49);
            this.userID_txt.MaxLength = 5;
            this.userID_txt.Name = "userID_txt";
            this.userID_txt.ReadOnly = true;
            this.userID_txt.Size = new System.Drawing.Size(71, 27);
            this.userID_txt.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "My Personal Data :";
            // 
            // showAppointments_btn
            // 
            this.showAppointments_btn.Location = new System.Drawing.Point(17, 169);
            this.showAppointments_btn.Name = "showAppointments_btn";
            this.showAppointments_btn.Size = new System.Drawing.Size(128, 58);
            this.showAppointments_btn.TabIndex = 9;
            this.showAppointments_btn.Text = "Show Appointments";
            this.showAppointments_btn.UseVisualStyleBackColor = true;
            this.showAppointments_btn.Click += new System.EventHandler(this.showAppointments_btn_Click);
            // 
            // viewReports_btn
            // 
            this.viewReports_btn.Location = new System.Drawing.Point(17, 413);
            this.viewReports_btn.Name = "viewReports_btn";
            this.viewReports_btn.Size = new System.Drawing.Size(128, 58);
            this.viewReports_btn.TabIndex = 10;
            this.viewReports_btn.Text = "View Reports";
            this.viewReports_btn.UseVisualStyleBackColor = true;
            this.viewReports_btn.Click += new System.EventHandler(this.viewReports_btn_Click);
            // 
            // reportsComboBox
            // 
            this.reportsComboBox.FormattingEnabled = true;
            this.reportsComboBox.Items.AddRange(new object[] {
            "Appointments"});
            this.reportsComboBox.Location = new System.Drawing.Point(17, 479);
            this.reportsComboBox.Name = "reportsComboBox";
            this.reportsComboBox.Size = new System.Drawing.Size(148, 21);
            this.reportsComboBox.TabIndex = 11;
            // 
            // findFloorToolStripMenuItem
            // 
            this.findFloorToolStripMenuItem.Name = "findFloorToolStripMenuItem";
            this.findFloorToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.findFloorToolStripMenuItem.Text = "Find Floor #";
            this.findFloorToolStripMenuItem.Click += new System.EventHandler(this.findFloorToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 568);
            this.Controls.Add(this.reportsComboBox);
            this.Controls.Add(this.viewReports_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showAppointments_btn);
            this.Controls.Add(this.showRoomsData_btn);
            this.Controls.Add(this.bookAppointment_btn);
            this.Controls.Add(this.showPatientsData_btn);
            this.Controls.Add(this.viewUserData_btn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userDataPanel);
            this.Controls.Add(this.patientsDataPanel);
            this.Controls.Add(this.roomsDataPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Hospital Management System - Main Page";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.patientsDataPanel.ResumeLayout(false);
            this.patientsDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            this.roomsDataPanel.ResumeLayout(false);
            this.roomsDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).EndInit();
            this.userDataPanel.ResumeLayout(false);
            this.userDataPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewUserData_btn;
        private System.Windows.Forms.Button showPatientsData_btn;
        private System.Windows.Forms.Panel patientsDataPanel;
        private System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.Button searchPatientsData_btn;
        private System.Windows.Forms.TextBox patientID_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox patientName_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveChanges_btn;
        private System.Windows.Forms.Button bookAppointment_btn;
        private System.Windows.Forms.Button showRoomsData_btn;
        private System.Windows.Forms.Panel roomsDataPanel;
        private System.Windows.Forms.DataGridView roomsDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox roomType_txt;
        private System.Windows.Forms.TextBox roomFloorNumber_txt;
        private System.Windows.Forms.Button addRoomData_btn;
        private System.Windows.Forms.Panel userDataPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userNewPassword_txt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox userUsername_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox userName_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox userID_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveNewUserChanges_btn;
        private System.Windows.Forms.TextBox userConfirmNewPassword_txt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button showAppointments_btn;
        private System.Windows.Forms.Button viewReports_btn;
        private System.Windows.Forms.ComboBox reportsComboBox;
        private System.Windows.Forms.ToolStripMenuItem findFloorToolStripMenuItem;
    }
}