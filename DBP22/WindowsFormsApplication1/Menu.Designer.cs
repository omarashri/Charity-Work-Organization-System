namespace WindowsFormsApplication1
{
    partial class Menu
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
            this.Search_rbtn = new System.Windows.Forms.RadioButton();
            this.Insert_rbtn = new System.Windows.Forms.RadioButton();
            this.Update_rbtn = new System.Windows.Forms.RadioButton();
            this.Delete_rbtn = new System.Windows.Forms.RadioButton();
            this.Next_btn = new System.Windows.Forms.Button();
            this.Report_rbtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Search_rbtn
            // 
            this.Search_rbtn.AutoSize = true;
            this.Search_rbtn.Location = new System.Drawing.Point(40, 33);
            this.Search_rbtn.Name = "Search_rbtn";
            this.Search_rbtn.Size = new System.Drawing.Size(77, 17);
            this.Search_rbtn.TabIndex = 0;
            this.Search_rbtn.TabStop = true;
            this.Search_rbtn.Text = "Search For";
            this.Search_rbtn.UseVisualStyleBackColor = true;
            // 
            // Insert_rbtn
            // 
            this.Insert_rbtn.AutoSize = true;
            this.Insert_rbtn.Location = new System.Drawing.Point(40, 67);
            this.Insert_rbtn.Name = "Insert_rbtn";
            this.Insert_rbtn.Size = new System.Drawing.Size(51, 17);
            this.Insert_rbtn.TabIndex = 1;
            this.Insert_rbtn.TabStop = true;
            this.Insert_rbtn.Text = "Insert";
            this.Insert_rbtn.UseVisualStyleBackColor = true;
            // 
            // Update_rbtn
            // 
            this.Update_rbtn.AutoSize = true;
            this.Update_rbtn.Location = new System.Drawing.Point(40, 102);
            this.Update_rbtn.Name = "Update_rbtn";
            this.Update_rbtn.Size = new System.Drawing.Size(60, 17);
            this.Update_rbtn.TabIndex = 2;
            this.Update_rbtn.TabStop = true;
            this.Update_rbtn.Text = "Update";
            this.Update_rbtn.UseVisualStyleBackColor = true;
            // 
            // Delete_rbtn
            // 
            this.Delete_rbtn.AutoSize = true;
            this.Delete_rbtn.Location = new System.Drawing.Point(40, 138);
            this.Delete_rbtn.Name = "Delete_rbtn";
            this.Delete_rbtn.Size = new System.Drawing.Size(56, 17);
            this.Delete_rbtn.TabIndex = 3;
            this.Delete_rbtn.TabStop = true;
            this.Delete_rbtn.Text = "Delete";
            this.Delete_rbtn.UseVisualStyleBackColor = true;
            // 
            // Next_btn
            // 
            this.Next_btn.Location = new System.Drawing.Point(94, 203);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(103, 45);
            this.Next_btn.TabIndex = 4;
            this.Next_btn.Text = "Next";
            this.Next_btn.UseVisualStyleBackColor = true;
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // Report_rbtn
            // 
            this.Report_rbtn.AutoSize = true;
            this.Report_rbtn.Location = new System.Drawing.Point(40, 170);
            this.Report_rbtn.Name = "Report_rbtn";
            this.Report_rbtn.Size = new System.Drawing.Size(83, 17);
            this.Report_rbtn.TabIndex = 5;
            this.Report_rbtn.TabStop = true;
            this.Report_rbtn.Text = "View Report";
            this.Report_rbtn.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AccessibleName = "Default";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.Report_rbtn);
            this.Controls.Add(this.Next_btn);
            this.Controls.Add(this.Delete_rbtn);
            this.Controls.Add(this.Update_rbtn);
            this.Controls.Add(this.Insert_rbtn);
            this.Controls.Add(this.Search_rbtn);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Search_rbtn;
        private System.Windows.Forms.RadioButton Insert_rbtn;
        private System.Windows.Forms.RadioButton Update_rbtn;
        private System.Windows.Forms.RadioButton Delete_rbtn;
        private System.Windows.Forms.Button Next_btn;
        private System.Windows.Forms.RadioButton Report_rbtn;
    }
}