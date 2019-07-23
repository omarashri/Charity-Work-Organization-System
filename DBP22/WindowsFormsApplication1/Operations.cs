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
    public partial class Operations : Form
    {
        string ordb = "Data Source =orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public Operations()
        {
            InitializeComponent();
        }

        private void Operations_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection("ordb");
            conn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Volunteer values (:id,:Fname,:Minit,:Lname,:Gender,:Address,:Zip_code,:Super_SSN,:Jname)";
            cmd.Parameters.Add("id",Convert.ToInt32(SSN_txt.Text));
            cmd.Parameters.Add("Fname",FN_txt.Text);
            cmd.Parameters.Add("Minit",Minit_txt.Text);
            cmd.Parameters.Add("Lname",LN_txt.Text);
            cmd.Parameters.Add("Gender",Gender_txt.Text);
            cmd.Parameters.Add("Address",Address_txt.Text);
            cmd.Parameters.Add("Zip_code",Convert.ToInt32(Zipcode_txt.Text));
            cmd.Parameters.Add("Super_SSN", Convert.ToInt32(SuperSSN_txt.Text));
            int r = cmd.ExecuteNonQuery();
            if (r != -1) 
            {
                Job_combobox.Items.Add(Job_combobox.Text);
                MessageBox.Show("Done!");
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update Volunteer set FirstName=:Fname,LastName=:Lname,Minit=:minit,Gender=:Gender,Address=:address,Super_ssn=:Super_SSN,Zip_code=:zipcode where V_ssn=:id";
            cmd.Parameters.Add("id", Convert.ToInt32(SSN_txt.Text));
            cmd.Parameters.Add("Fname", FN_txt.Text);
            cmd.Parameters.Add("Lname", LN_txt.Text);
            cmd.Parameters.Add("minit", Minit_txt.Text);
            cmd.Parameters.Add("Gender", Gender_txt.Text);
            cmd.Parameters.Add("address", Address_txt.Text);
            cmd.Parameters.Add("Super_SSN", Convert.ToInt32(SuperSSN_txt.Text));
            cmd.Parameters.Add("zipcode", Convert.ToInt32(Zipcode_txt.Text));
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {                
                MessageBox.Show("Done!");
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Delete from Volunteer where v_ssn=:id";
            cmd.Parameters.Add("id",Convert.ToInt32(SSN_txt.Text));
        }
    }
}
