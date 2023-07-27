using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.pexels_pixabay_235985;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string user, pwd;
            user = usernametb.Text;
            pwd = passwordtb.Text;
            if (user == "" || pwd == "")
            {
                alert.Text = "Enter the User Name and Password";
                alert.ForeColor = System.Drawing.Color.Red;
                message.Visible = false;
            }

            else if (user == "admin" && pwd == "p@ss123")
            {
                message.Text = "Successfully logged in as Admin";
                message.ForeColor = System.Drawing.Color.Green;
            }
            else if (user != "admin" && pwd != "p@ss123")
            {
                alert.Text = "User not Registered. Please Register !";
                alert.ForeColor = System.Drawing.Color.Red;
                message.Visible = false;
            }
            else if (pwd.Length < 6)
            {
                alert.Text = "Password must be atleast 6 characters !";
                alert.ForeColor = System.Drawing.Color.Red;
                message.Visible = false;
            }
        }
    }
}
