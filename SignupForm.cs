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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user newUser = new user();
            newUser.setUser(txtUsernameNew.Text);
            newUser.setUser(txtPasswordNew.Text);

            this.Close();
        }
    }
}
