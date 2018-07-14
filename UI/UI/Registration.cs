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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            loadComboBox();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            this.Hide();
            lg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check = DBcon.EventHandler.addNewUser(nameBox.Text, userNameBox.Text, passwordBox.Text, phnBox.Text, emailBox.Text, passportBox.Text, streetBox.Text, cityBox.Text, countryComboBox.SelectedValue.ToString());

            if(check)
            {
                clearTextBoxes();
                MessageBox.Show("Registration Successful");
            }
            else
            {
                MessageBox.Show("Registration Failed");
            }
        }
        private void clearTextBoxes()
        {
            nameBox.Clear();
            userNameBox.Clear();
            passwordBox.Clear();
            phnBox.Clear();
            emailBox.Clear();
            passportBox.Clear();
            streetBox.Clear();
            cityBox.Clear();
        }


        private void countryComboBoxClicked(object sender, EventArgs e)
        {
            //loadComboBox();
        }
        private void loadComboBox()
        {
            DBcon.DBCON cn = new DBcon.DBCON();
            try
            {
                countryComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                countryComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

                String sql1 = "select * from countries";
                OracleDataAdapter countryAdapter = new OracleDataAdapter(sql1, cn.thisCon);
                DataTable countryDt = new DataTable();
                countryAdapter.Fill(countryDt);

                countryComboBox.DataSource = countryDt;
                countryComboBox.DisplayMember = "country_name";
                countryComboBox.ValueMember = "country_id";

            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
