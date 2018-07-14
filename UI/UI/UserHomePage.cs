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
    public partial class UserHomePage : Form
    {
        public UserHomePage()
        {
            InitializeComponent();
            loadCountryComboBox();
            loadLocationComboBox();
            loadHotelComboBox();
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
            //MessageBox.Show(countryComboBox.SelectedValue.ToString());
            //loadLocationComboBox();
            }
            catch (Exception)
            {
                //MessageBox.Show("Country Combobox can not be constructed cause {0}", exp.Message);
            }
        }
        private void loadLocationComboBox()
        {
            try
            {
                DBcon.DBCON cn = new DBcon.DBCON();

                locationComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                locationComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

                String sql = "select * from locations where country_id = " + countryComboBox.SelectedValue + "";
                //MessageBox.Show(countryComboBox.SelectedValue.ToString());
                OracleDataAdapter locationAdapter = new OracleDataAdapter(sql, cn.thisCon);
                DataTable locationDt = new DataTable();
                locationAdapter.Fill(locationDt);

                locationComboBox.DataSource = locationDt;
                locationComboBox.DisplayMember = "location_name";
                locationComboBox.ValueMember = "location_id";
                //loadHotelComboBox();
            }
            catch (Exception )
            {

            //    MessageBox.Show(exp.Message);
            }
            
        }

        private void loadHotelComboBox()
        {
            try
            {
                DBcon.DBCON cn = new DBcon.DBCON();

                hotelComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                hotelComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

                String sql = "select * from hotel_info where location_id = " + locationComboBox.SelectedValue + "";
                //MessageBox.Show(locationComboBox.SelectedValue.ToString());
                OracleDataAdapter hotelAdpater = new OracleDataAdapter(sql, cn.thisCon);
                DataTable dt = new DataTable();
                hotelAdpater.Fill(dt);

                hotelComboBox.DataSource = dt;
                hotelComboBox.DisplayMember = "hotel_name";
                hotelComboBox.ValueMember = "hotel_id";
            }
            catch (Exception)
            {
                
            }

        }

        private void UserHomePage_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goOffline();
            logout();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout()
        {
            this.Hide();
            LoginForm lg = new LoginForm();
            lg.Show();
        }
        private void goOffline()
        {
            DBcon.EventHandler.makeUserOffline();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void updateBookingSearchButton_Click(object sender, EventArgs e)
        {
            //checkInDateTimePicker.Value = DateTime.Parse("6th May 2018");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void newBookingOkButton_Click(object sender, EventArgs e)
        {
            String checkInDate = checkInDateTimePicker.Value.Date.ToShortDateString();
            String checkOutDate = checkOutDateTimePicker2.Value.Date.ToShortDateString();

            try
            {
                DBcon.EventHandler.createNewBooking(hotelComboBox.SelectedValue.ToString(), roombox.Text, suitesBox.Text, checkInDate, checkOutDate);
                suitesBox.Text = null;
                roombox.Text = null;
                BookingConfirmation bk = new BookingConfirmation();
                bk.ShowDialog();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            } 
            
        }

        private void countryComboBoxValueChanged(object sender, EventArgs e)
        {
            //loadLocationComboBox();           
        }

        private void locationComBoxValueChanged(object sender, EventArgs e)
        {
            //loadHotelComboBox();
        }

        private void locationComboBoxIndexChanged(object sender, EventArgs e)
        {
            loadHotelComboBox();
        }

        private void countryComboBoxIndexChanged(object sender, EventArgs e)
        {
            loadLocationComboBox();
        }

        private void locationComboBoxMouseClicked(object sender, MouseEventArgs e)
        {
            //loadLocationComboBox();
        }

        private void hotelComboBoxMouseClicked(object sender, MouseEventArgs e)
        {
            //loadHotelComboBox();
        }

        private void CurrentBookingRefreshButton_Click(object sender, EventArgs e)
        {
            DataTable dt = DBcon.EventHandler.getCurrentBookings();
            currentBookingsGridView.DataSource = dt;
        }

        private void currentBookingSearchTextChanged(object sender, EventArgs e)
        {
            String searchText = searchCurrentBooking.Text;
            DataTable dt = DBcon.EventHandler.searchCurrentBookings(searchText);
            currentBookingsGridView.DataSource = dt;
        }

        private void calcelBookingCancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                DBcon.EventHandler.deleteBooking(cancelBookingIdBox.Text);
                cancelBookingIdBox.Text = null;
                MessageBox.Show("Booking canceled");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void bookIdTextBoxTextXhanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = DBcon.EventHandler.searchBookIdWise(updateBookingIdBox.Text);

                MessageBox.Show(dt.Rows[0][0].ToString());
                if (dt.IsInitialized)
                {
                    updateRoomBox.Text = dt.Rows[0][3].ToString();
                    updateSuitesBox.Text = dt.Rows[0][4].ToString();
                    updateCheckInDateTimePicker.Value = DateTime.Parse(dt.Rows[0][6].ToString());
                    updateCheckOutTimePicker.Value = DateTime.Parse(dt.Rows[0][7].ToString());
                }
            }
            catch (Exception)
            {
                
            }
         }

        private void updateBookingUpdateButton_Click(object sender, EventArgs e)
        {
            String checkInDate = updateCheckInDateTimePicker.Value.Date.ToShortDateString();
            String checkOutDate = updateCheckOutTimePicker.Value.Date.ToShortDateString();

            try
            {
                DBcon.EventHandler.updateBooking(updateBookingIdBox.Text, updateRoomBox.Text, updateSuitesBox.Text, checkInDate, checkOutDate);
                updateSuitesBox.Text = null;
                updateRoomBox.Text = null;
                MessageBox.Show("Update Successful");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
