using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            if (Search_rbtn.Checked) 
            {
                SearchFor obj =new  SearchFor();
                this.Close();
                obj.Show();


            }
            if (Insert_rbtn.Checked)
            {
                VolunteerOp obj = new VolunteerOp();
                this.Close();
                obj.Show();
            }
            if (Update_rbtn.Checked)
            {
                //go to menu
            }
            if (Delete_rbtn.Checked)
            {
                //go to menu
            }
            if (Report_rbtn.Checked)
            {
                //go to menu
            }

        }
    }
}
