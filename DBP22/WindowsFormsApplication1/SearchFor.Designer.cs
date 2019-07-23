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
            this.Volunteer_rbtn = new System.Windows.Forms.RadioButton();
            this.Donor_rbtn = new System.Windows.Forms.RadioButton();
            this.Person_rbtn = new System.Windows.Forms.RadioButton();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Search_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Volunteer_rbtn
            // 
            this.Volunteer_rbtn.AutoSize = true;
            this.Volunteer_rbtn.Location = new System.Drawing.Point(53, 22);
            this.Volunteer_rbtn.Name = "Volunteer_rbtn";
            this.Volunteer_rbtn.Size = new System.Drawing.Size(70, 17);
            this.Volunteer_rbtn.TabIndex = 0;
            this.Volunteer_rbtn.TabStop = true;
            this.Volunteer_rbtn.Text = "Volunteer";
            this.Volunteer_rbtn.UseVisualStyleBackColor = true;
            // 
            // Donor_rbtn
            // 
            this.Donor_rbtn.AutoSize = true;
            this.Donor_rbtn.Location = new System.Drawing.Point(53, 60);
            this.Donor_rbtn.Name = "Donor_rbtn";
            this.Donor_rbtn.Size = new System.Drawing.Size(54, 17);
            this.Donor_rbtn.TabIndex = 1;
            this.Donor_rbtn.TabStop = true;
            this.Donor_rbtn.Text = "Donor";
            this.Donor_rbtn.UseVisualStyleBackColor = true;
            // 
            // Person_rbtn
            // 
            this.Person_rbtn.AutoSize = true;
            this.Person_rbtn.Location = new System.Drawing.Point(53, 95);
            this.Person_rbtn.Name = "Person_rbtn";
            this.Person_rbtn.Size = new System.Drawing.Size(99, 17);
            this.Person_rbtn.TabIndex = 2;
            this.Person_rbtn.TabStop = true;
            this.Person_rbtn.Text = "In Need Person";
            this.Person_rbtn.UseVisualStyleBackColor = true;
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(440, 26);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(100, 20);
            this.Name_txt.TabIndex = 3;
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(440, 81);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(100, 20);
            this.ID_txt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID :";
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(411, 328);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(129, 44);
            this.Search_btn.TabIndex = 7;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(528, 172);
            this.dataGridView1.TabIndex = 8;
            // 
            // SearchFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 384);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.Person_rbtn);
            this.Controls.Add(this.Donor_rbtn);
            this.Controls.Add(this.Volunteer_rbtn);
            this.Name = "SearchFor";
            this.Text = "SearchFor";
            this.Load += new System.EventHandler(this.SearchFor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Volunteer_rbtn;
        private System.Windows.Forms.RadioButton Donor_rbtn;
        private System.Windows.Forms.RadioButton Person_rbtn;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}