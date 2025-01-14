using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_HMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = Txtpassword.Text;

            if(username=="hms" && password=="pass")
            {
                // MessageBox.Show("You have to enter correct username and password");
                this.Hide();
                Dashbord ds= new Dashbord();
                ds.Show();
            }
            else
            {
                MessageBox.Show("Wrong user id or password");
            }

        }

        private void Txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
