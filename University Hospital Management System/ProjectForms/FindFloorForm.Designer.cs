namespace University_Hospital_Management_System.ProjectForms
{
    partial class FindFloorForm
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
            this.roomID_txt = new System.Windows.Forms.TextBox();
            this.floorNo_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room ID :";
            // 
            // roomID_txt
            // 
            this.roomID_txt.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.roomID_txt.Location = new System.Drawing.Point(104, 16);
            this.roomID_txt.MaxLength = 5;
            this.roomID_txt.Name = "roomID_txt";
            this.roomID_txt.Size = new System.Drawing.Size(141, 29);
            this.roomID_txt.TabIndex = 1;
            // 
            // floorNo_txt
            // 
            this.floorNo_txt.Enabled = false;
            this.floorNo_txt.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.floorNo_txt.Location = new System.Drawing.Point(104, 70);
            this.floorNo_txt.MaxLength = 5;
            this.floorNo_txt.Name = "floorNo_txt";
            this.floorNo_txt.ReadOnly = true;
            this.floorNo_txt.Size = new System.Drawing.Size(141, 29);
            this.floorNo_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Floor # :";
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(88, 121);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(103, 43);
            this.search_btn.TabIndex = 4;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // FindFloorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 171);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.floorNo_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomID_txt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FindFloorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Floor number of room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roomID_txt;
        private System.Windows.Forms.TextBox floorNo_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search_btn;
    }
}