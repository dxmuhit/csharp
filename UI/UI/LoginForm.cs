using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void RegisterLabelClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginCheck();
        }
        private void loginCheck()
        {
            Customer.CustomerInfo.UserName = userNameBox.Text;
            Customer.CustomerInfo.Password = passBox.Text;

            DataTable dt = DBcon.EventHandler.getUserId(Customer.CustomerInfo.UserName, Customer.CustomerInfo.Password);

            if (dt.Rows.Count == 1 && dt.Rows[0][3].ToString() == "user")
            {
                UserHomePage pg = new UserHomePage();
                pg.Show();
                //MessageBox.Show("User Login Successful");
                Customer.CustomerInfo.UserId = int.Parse(dt.Rows[0][0].ToString());
                this.Hide();
                DBcon.EventHandler.makeUserOnline();
                //MessageBox.Show("User id : " + Customer.CustomerInfo.UserId.ToString());
            }
            else if (dt.Rows.Count == 1 && dt.Rows[0][3].ToString() == "admin")
            {
                AdminHomePage ag = new AdminHomePage();
                ag.Show();
                MessageBox.Show("Admin Login Successful");
                Customer.CustomerInfo.UserId = int.Parse(dt.Rows[0][0].ToString());
                this.Hide();
                DBcon.EventHandler.makeUserOnline();
                //MessageBox.Show("Admin - id : " + Customer.CustomerInfo.UserId.ToString());
            }
            else
            {
                MessageBox.Show("Invalid Login credential");
            }
        }

        private void registerButtonClick(object sender, EventArgs e)
        {
            Registration rg = new Registration();
            this.Hide();
            rg.Show();
        }

        private void exitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
