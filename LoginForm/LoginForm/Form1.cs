using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, password;
            user = Username.Text;
            password = Password.Text;
            if (user == "admin" && password == "p@ss123")
            {
                message.Text = "Successfully logged in as Admin";
                message.ForeColor = System.Drawing.Color.Green;
            }
            else if(user != "admin" && password != "p@ss123")
            {
               alert1.Text = "User not Registered. Please Register !";
                alert1.ForeColor = System.Drawing.Color.Red;
                message.Visible = false;
            }
            else if(password.Length < 6)
            {
                alert1.Text = "Password must be atleast 6 characters !";
                alert1.ForeColor = System.Drawing.Color.Red;
                message.Visible = false;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
