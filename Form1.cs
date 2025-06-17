using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text=="SAHIL" && txtUsername.Text=="Sahil")
            {
                Home obj = new Home();
                obj.Show();
                this.Hide();
            }
            if(txtUsername.Text != "Sahil" || txtPassword.Text != "SAHIL")
            {
                lblError.Visible = true;
                lblError.Text = "Invalid Username and Password";
                txtPassword.Clear();
                txtUsername.Clear();

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
