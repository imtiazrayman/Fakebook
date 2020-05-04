using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fakebook
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnGoAmazon_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignupForm signup = new SignupForm();
            signup.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user newuser = new user();
            //int passwordEntered = Convert.ToInt32(txtPassword.Text);
            /*if(passwordEntered == newuser.getPass())
            {
                txtUsername.Text = newuser.getPass().ToString();
            }
            txtUsername.Text = newuser.getPass().ToString();*/

            Form1 home = new Form1();
            home.ShowDialog();
        }
    }
}
