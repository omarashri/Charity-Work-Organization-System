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
    public partial class SearchFor : MetroFramework.Forms.MetroForm
    {

        string ordb = "Data Source=xe;User Id=scott;Password=tiger;";
        OracleConnection conn;

        public SearchFor()
        {
            InitializeComponent();
        }

        private void SearchFor_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();
            

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            OracleDataAdapter adapter;
            DataSet ds;
            string cmd = "";
            bool ssn = false;

            if (txtSSN.Text != "")
                ssn = true;


            if (rbtn_Donor.Checked)
            {
                if (ssn == true)
                {
                    cmd = "SELECT * FROM donor WHERE d_ssn=:ssn";
                }
                else
                    cmd = "SELECT * FROM donor";
                adapter = new OracleDataAdapter(cmd, ordb);
                adapter.SelectCommand.Parameters.Add("ssn", txtSSN.Text);
                ds = new DataSet();
                adapter.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];
            }
            else if (rbtn_Volunteer.Checked)
            {
                if (ssn == true)
                {
                    cmd = "SELECT * FROM volunteer WHERE v_ssn=:ssn";
                }
                else
                    cmd = "SELECT * FROM volunteer";
                adapter = new OracleDataAdapter(cmd, ordb);
                adapter.SelectCommand.Parameters.Add("ssn", txtSSN.Text);
                ds = new DataSet();
                adapter.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];
            }
            else if (rbtn_Person.Checked)
            {
                if (ssn == true)
                {
                    cmd = "SELECT * FROM in_need_person WHERE p_ssn=:ssn";
                }
                else
                    cmd = "SELECT * FROM in_need_person";
                adapter = new OracleDataAdapter(cmd, ordb);
                adapter.SelectCommand.Parameters.Add("ssn", txtSSN.Text);
                ds = new DataSet();
                adapter.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];
            }
            else
                MetroFramework.MetroMessageBox.Show(ActiveForm, "Please select a table first !!");
        }

        private void SearchFor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
