using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace WindowsFormsApplication1
{
    public partial class SearchFor : Form
    {
        string ordb = "Data Source =ORCL;User Id=scott;Password=tiger;";
        OracleConnection conn;
        
        public SearchFor()
        {
            InitializeComponent();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
           // Operations obj=new Operations();
            conn = new OracleConnection("ordb");
            conn.Open();
            if(Volunteer_rbtn.Checked)
            {
                string ID = ID_txt.Text;
                string Name = Name_txt.Text;
                OracleCommand cmd= new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from volunteer";
                this.Hide();
               // obj.Show();

               
            }
            if (Donor_rbtn.Checked)
            {
            }
            if (Person_rbtn.Checked)
            {
            }
        }

        private void SearchFor_Load(object sender, EventArgs e)
        {
            

        }
    }
}
