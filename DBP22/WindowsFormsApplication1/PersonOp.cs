﻿using System;
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
    public partial class PersonOp : Form
    {
        string ordb = "Data Source =orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public PersonOp()
        {
            InitializeComponent();
        }

        private void PersonOp_Load(object sender, EventArgs e)
        {

        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into IN_Need_Person  values (:P_ssn,:FirstName,:Minit,:LastName,:Gender,:Address,:Zip_code)";
            cmd.Parameters.Add("P_ssn", Convert.ToInt32(SSN_txt.Text));
            cmd.Parameters.Add("FirstName", FN_txt.Text);
            cmd.Parameters.Add("Minit", Minit_txt.Text);
            cmd.Parameters.Add("LastName", LN_txt.Text);
            cmd.Parameters.Add("Gender", Gender_txt.Text);
            cmd.Parameters.Add("Address", Address_txt.Text);
            cmd.Parameters.Add("Zip_code", Convert.ToInt32(Zipcode_txt.Text));
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                //// Job_combobox.Items.Add(Job_combobox.Text);
                MessageBox.Show("Done!");
            }
            // MessageBox.Show("Done!");
            conn.Close();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update IN_Need_Person  set FirstName=:fname,Minit=:minit,LastName=:lname,Gender=:gender,Address=:address,Zip_code=:zipcode where P_ssn =:p_ssn";

            cmd.Parameters.Add("fname", FN_txt.Text);
            cmd.Parameters.Add("minit", Minit_txt.Text);
            cmd.Parameters.Add("lname", LN_txt.Text);
            cmd.Parameters.Add("gender", Gender_txt.Text);
            cmd.Parameters.Add("address", Address_txt.Text);
            cmd.Parameters.Add("zipcode", Convert.ToInt32(Zipcode_txt.Text));
            cmd.Parameters.Add("p_ssn", Convert.ToInt32(SSN_txt.Text));
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
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
            cmd.CommandText = "Delete from IN_Need_Person  where P_ssn=:P_ssn";
            cmd.Parameters.Add("P_ssn", Convert.ToInt32(SSN_txt.Text));
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Done!");
            }
            conn.Close();
        }
    }
}
