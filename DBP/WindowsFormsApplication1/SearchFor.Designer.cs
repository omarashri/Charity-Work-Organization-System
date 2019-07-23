namespace WindowsFormsApplication1
{
    partial class SearchFor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnProceed = new MetroFramework.Controls.MetroButton();
            this.lblID = new MetroFramework.Controls.MetroLabel();
            this.txtSSN = new MetroFramework.Controls.MetroTextBox();
            this.rbtn_Person = new MetroFramework.Controls.MetroRadioButton();
            this.rbtn_Volunteer = new MetroFramework.Controls.MetroRadioButton();
            this.rbtn_Donor = new MetroFramework.Controls.MetroRadioButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(572, 379);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(147, 42);
            this.btnProceed.TabIndex = 8;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseSelectable = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(318, 113);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(36, 19);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "SSN:";
            // 
            // txtSSN
            // 
            // 
            // 
            // 
            this.txtSSN.CustomButton.Image = null;
            this.txtSSN.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtSSN.CustomButton.Name = "";
            this.txtSSN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSSN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSSN.CustomButton.TabIndex = 1;
            this.txtSSN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSSN.CustomButton.UseSelectable = true;
            this.txtSSN.CustomButton.Visible = false;
            this.txtSSN.Lines = new string[0];
            this.txtSSN.Location = new System.Drawing.Point(417, 113);
            this.txtSSN.MaxLength = 32767;
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.PasswordChar = '\0';
            this.txtSSN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSSN.SelectedText = "";
            this.txtSSN.SelectionLength = 0;
            this.txtSSN.SelectionStart = 0;
            this.txtSSN.ShortcutsEnabled = true;
            this.txtSSN.Size = new System.Drawing.Size(211, 23);
            this.txtSSN.TabIndex = 17;
            this.txtSSN.UseSelectable = true;
            this.txtSSN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSSN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbtn_Person
            // 
            this.rbtn_Person.AutoSize = true;
            this.rbtn_Person.Location = new System.Drawing.Point(51, 160);
            this.rbtn_Person.Name = "rbtn_Person";
            this.rbtn_Person.Size = new System.Drawing.Size(101, 15);
            this.rbtn_Person.TabIndex = 16;
            this.rbtn_Person.Text = "In need person";
            this.rbtn_Person.UseSelectable = true;
            // 
            // rbtn_Volunteer
            // 
            this.rbtn_Volunteer.AutoSize = true;
            this.rbtn_Volunteer.Location = new System.Drawing.Point(51, 113);
            this.rbtn_Volunteer.Name = "rbtn_Volunteer";
            this.rbtn_Volunteer.Size = new System.Drawing.Size(73, 15);
            this.rbtn_Volunteer.TabIndex = 15;
            this.rbtn_Volunteer.Text = "Volunteer";
            this.rbtn_Volunteer.UseSelectable = true;
            // 
            // rbtn_Donor
            // 
            this.rbtn_Donor.AutoSize = true;
            this.rbtn_Donor.Location = new System.Drawing.Point(51, 67);
            this.rbtn_Donor.Name = "rbtn_Donor";
            this.rbtn_Donor.Size = new System.Drawing.Size(56, 15);
            this.rbtn_Donor.TabIndex = 14;
            this.rbtn_Donor.Text = "Donor";
            this.rbtn_Donor.UseSelectable = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(13, 204);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(706, 150);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroGrid1.TabIndex = 21;
            // 
            // SearchFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 426);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.rbtn_Person);
            this.Controls.Add(this.rbtn_Volunteer);
            this.Controls.Add(this.rbtn_Donor);
            this.Controls.Add(this.btnProceed);
            this.Name = "SearchFor";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Search For";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchFor_FormClosing);
            this.Load += new System.EventHandler(this.SearchFor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnProceed;
        private MetroFramework.Controls.MetroLabel lblID;
        private MetroFramework.Controls.MetroTextBox txtSSN;
        private MetroFramework.Controls.MetroRadioButton rbtn_Person;
        private MetroFramework.Controls.MetroRadioButton rbtn_Volunteer;
        private MetroFramework.Controls.MetroRadioButton rbtn_Donor;
        private MetroFramework.Controls.MetroGrid metroGrid1;
    }
}