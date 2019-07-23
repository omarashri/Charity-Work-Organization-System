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
    public partial class volunteeropsp : Form
    {
        string ordb = "Data Source =orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public volunteeropsp()
        {
            InitializeComponent();
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT_VOLUNTEER";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("vssn",Convert.ToInt32(SSN_txt.Text));
            cmd.Parameters.Add("fname", FN_txt.Text);
            cmd.Parameters.Add("minit", Minit_txt.Text);
            cmd.Parameters.Add("lname",LN_txt.Text );
            cmd.Parameters.Add("gender", Gender_txt.Text);
            cmd.Parameters.Add("address", Address_txt.Text);
            cmd.Parameters.Add("jobname", textBox1.Text);
            cmd.Parameters.Add("superssn", Convert.ToInt32(SuperSSN_txt.Text));
            cmd.Parameters.Add("zipcode", Convert.ToInt32(Zipcode_txt.Text));
            int r = cmd.ExecuteNonQuery();
            if (r == -1)
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
            cmd.CommandText = "UPDATE_VOLUNTEER ";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("fname", FN_txt.Text);
            cmd.Parameters.Add("minit", Minit_txt.Text);
            cmd.Parameters.Add("lname", LN_txt.Text);
            cmd.Parameters.Add("gender", Gender_txt.Text);
            cmd.Parameters.Add("address", Address_txt.Text);
            cmd.Parameters.Add("jobname", textBox1.Text);
            cmd.Parameters.Add("superssn", Convert.ToInt32(SuperSSN_txt.Text));
            cmd.Parameters.Add("zipcode", Convert.ToInt32(Zipcode_txt.Text));
            cmd.Parameters.Add("vssn", Convert.ToInt32(SSN_txt.Text));
            int r = cmd.ExecuteNonQuery();
            if (r == -1)
            {
                MessageBox.Show("Done!");
            }
            conn.Close();
        
        }
        
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE_VOLUNTEER";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("vssn", Convert.ToInt32(SSN_txt.Text));
            int r = cmd.ExecuteNonQuery();
            if (r == -1)
            {
                MessageBox.Show("Done!");
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Volunteer where V_ssn = :vssn";
            c.Parameters.Add("vssn", Convert.ToInt32(SSN_txt.Text));
          
            c.CommandType = CommandType.Text;
            OracleDataReader r = c.ExecuteReader();
            if (r.Read())
            {
                FN_txt.Text = r[1].ToString();
                Minit_txt.Text = r[2].ToString();
                LN_txt.Text = r[3].ToString();
                Gender_txt.Text = r[4].ToString();
                Address_txt.Text = r[5].ToString();
                textBox1.Text = r[6].ToString();
                SuperSSN_txt.Text = r[7].ToString();
                Zipcode_txt.Text = r[8].ToString();
                
                MessageBox.Show("Done!");
            }
            conn.Close();
        }
    }
}

 
