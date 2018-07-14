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
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
            loadCountryComboBox();
            loadLocationComboBox();
            //loadTypeComboBox();
        }
        private void loadTypeComboBox()
        {
            DBcon.DBCON cn = new DBcon.DBCON();
            try
            {
                hotelTypeCombobox.AutoCompleteMode = AutoCompleteMode.Suggest;
                hotelTypeCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;


                String sql1 = "select hotel_type from hotel_info";
                OracleDataAdapter countryAdapter = new OracleDataAdapter(sql1, cn.thisCon);
                DataTable countryDt = new DataTable();
                countryAdapter.Fill(countryDt);
                hotelTypeCombobox.DataSource = countryDt;
                hotelTypeCombobox.DisplayMember = "hotel_type";
                hotelTypeCombobox.ValueMember = "hotel_type";

            }
            catch(Exception exp)
            {
                MessageBox.Show("Country Combobox can not be constructed cause {0}", exp.Message);
            }
        }

        private void loadCountryComboBox()
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
                MessageBox.Show("Country Combobox can not be constructed cause {0}", exp.Message);
            }
        }

        private void loadLocationComboBox()
        {
            try
            {

                DBcon.DBCON cn = new DBcon.DBCON();
                locationComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                locationComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

                String sql1 = "Select * from locations";
                OracleDataAdapter locationAdapter = new OracleDataAdapter(sql1, cn.thisCon);
                DataTable locationDt = new DataTable();
                locationAdapter.Fill(locationDt);

                locationComboBox.DataSource = locationDt;
                locationComboBox.DisplayMember = "location_name";
                locationComboBox.ValueMember = "location_id";
            }
            catch (Exception exp)
            {
                MessageBox.Show("location Combobox can not be constructed cause {0}", exp.Message);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lg = new LoginForm();
            lg.Show();
            DBcon.EventHandler.makeUserOffline();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {

        }

        private void countryInsertButton(object sender, EventArgs e)
        {
            bool check = DBcon.EventHandler.addNewLocation(countryComboBox.SelectedValue.ToString(), locationNameBox.Text);

            if(check)
            {
                locationNameBox.Text = null;
                MessageBox.Show("Locations Added");
                loadLocationComboBox();// updating locations
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.DataSource = DBcon.EventHandler.getUserList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridViewHotels.DataSource = DBcon.EventHandler.getHotelList();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            String searchString = textBox7.Text;
            dataGridViewHotels.DataSource = DBcon.EventHandler.searchHotel(searchString);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            String searchText = textBox6.Text;
            dataGridViewUsers.DataSource = DBcon.EventHandler.searchCustomer(searchText);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridViewLoginHistory.DataSource = DBcon.EventHandler.getLoginHistory();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            String searchText = textBox8.Text;
            dataGridViewLoginHistory.DataSource = DBcon.EventHandler.searchLoginHistory(searchText);
        }

        private void addNewHotelOkButton_Click(object sender, EventArgs e)
        {
            bool check = DBcon.EventHandler.addNewHotel(hotelNameBox.Text, hotelTypeCombobox.SelectedItem.ToString(), roomFareBox.Text, suiteFareBox.Text, locationComboBox.SelectedValue.ToString());
            
           if(check)
           {
               hotelNameBox.Text = "Enter Name";
               roomFareBox.Text = "Room Fare";
               suiteFareBox.Text = "Suite Fare";
               MessageBox.Show("Hotel/Resort Added");
           }
           else
           {
               MessageBox.Show("Operation Failed");
           }
        }

        private void locationBoxClicked(object sender, EventArgs e)
        {
            locationNameBox.Text = null;
        }

        private void hotelNameBoxClicked(object sender, EventArgs e)
        {
            hotelNameBox.Text = null;
        }

        private void roomFareBoxClicked(object sender, EventArgs e)
        {
            roomFareBox.Text = null;
        }

        private void suiteFareBoxClicked(object sender, EventArgs e)
        {
            suiteFareBox.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = DBcon.EventHandler.viewBookings();
            dataGridViewBookings.DataSource = dt;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = DBcon.EventHandler.adminSearchBooking(textBox5.Text);
            dataGridViewBookings.DataSource = dt;
        }
    }
}
