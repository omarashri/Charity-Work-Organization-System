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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            volunteeropsp obj = new volunteeropsp();
         
            if (ID_Txt.Text == "Admin")
            {
                if (Password_Txt.Text == "123")
                {
                    this.Hide();
                    obj.Show();
                    
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                    
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                
            }
    
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
    
}
