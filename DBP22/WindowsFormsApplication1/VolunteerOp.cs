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
    public partial class VolunteerOp : Form
    {
        string ordb = "Data Source =orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        
        public VolunteerOp()
        {
            InitializeComponent();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Delete from Volunteer where v_ssn=:V_ssn";
            cmd.Parameters.Add("v_ssn", Convert.ToInt32(SSN_txt.Text));
            int r = cmd.ExecuteNonQuery();
            if(r!=-1)
            {
                MessageBox.Show("Done!");
            }
            conn.Close();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update Volunteer set FirstName=:fname,Minit=:minit,LastName=:lname,Gender=:gender,Address=:address,Job_name=:jobname,Super_ssn=:superssn,Zip_code=:zipcode where V_ssn =:v_ssn";
            
            cmd.Parameters.Add("fname", FN_txt.Text); 
            cmd.Parameters.Add("minit", Minit_txt.Text);
            cmd.Parameters.Add("lname", LN_txt.Text);
            cmd.Parameters.Add("gender", Gender_txt.Text);
            cmd.Parameters.Add("address", Address_txt.Text);
            cmd.Parameters.Add("jobname", textBox1.Text);
            cmd.Parameters.Add("superssn", Convert.ToInt32(SuperSSN_txt.Text));
            cmd.Parameters.Add("zipcode", Convert.ToInt32(Zipcode_txt.Text));
            cmd.Parameters.Add("v_ssn", Convert.ToInt32(SSN_txt.Text));
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Done!");
            }
            conn.Close();
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Volunteer values (:V_ssn,:FirstName,:Minit,:LastName,:Gender,:Address,:Job_name,:Super_ssn,:Zip_code)";
            cmd.Parameters.Add("V_ssn", Convert.ToInt32(SSN_txt.Text));
            cmd.Parameters.Add("FirstName", FN_txt.Text);
            cmd.Parameters.Add("Minit", Minit_txt.Text);
            cmd.Parameters.Add("LastName", LN_txt.Text);
            cmd.Parameters.Add("Gender", Gender_txt.Text);
            cmd.Parameters.Add("Address", Address_txt.Text);
            cmd.Parameters.Add("Job_name", textBox1.Text);
            cmd.Parameters.Add("Super_ssn", Convert.ToInt32(SuperSSN_txt.Text));
            cmd.Parameters.Add("Zip_code", Convert.ToInt32(Zipcode_txt.Text));
            int r = cmd.ExecuteNonQuery();
             MessageBox.Show("Done!");
            conn.Close();}
        

        private void VolunteerOp_Load(object sender, EventArgs e)
        {
            
        }
    }
}
