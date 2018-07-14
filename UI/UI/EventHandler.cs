using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace DBcon
{
    class EventHandler
    {
        public static DataTable getUserId(String userName, String pass)
        {
            DBCON cn = new DBCON();
            cn.thisCon.Open();

            String sql = "select * from user_login where user_name = '" + userName + "' and password = '" + pass + "'";
            OracleDataAdapter adapter = new OracleDataAdapter(sql, cn.thisCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.thisCon.Close();

            return dt;
        }
        public static bool addNewUser(String name, String userName, String pass, String phnNo, String Email, String Passport, String Street, String City, String countryId)
        {
            DBCON cn = new DBCON();

            try
            {
                String addCustomerSql = "begin add_new_user('" + name + "', '" + userName + "', '" + pass + "', '" + phnNo + "', '" + Email + "', '" + Passport + "', '" + Street + "', '" + City + "', " + int.Parse(countryId) + "); end;";
                OracleCommand cmd = new OracleCommand(addCustomerSql, cn.thisCon);

                cn.thisCon.Open();
                cmd.ExecuteNonQuery();
                cn.thisCon.Close();

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public static void makeUserOnline()
        {
            DBCON cn = new DBCON();
            String addCustomerSql = "begin user_online(" + Customer.CustomerInfo.UserId + "); end;";
            OracleCommand cmd = new OracleCommand(addCustomerSql, cn.thisCon);

            cn.thisCon.Open();
            cmd.ExecuteNonQuery();
            cn.thisCon.Close();
        }

        public static void makeUserOffline()
        {
            DBCON cn = new DBCON();
            String addCustomerSql = "begin user_offline(" + Customer.CustomerInfo.UserId + "); end;";
            OracleCommand cmd = new OracleCommand(addCustomerSql, cn.thisCon);

            cn.thisCon.Open();
            cmd.ExecuteNonQuery();
            cn.thisCon.Close();
        }
        public static DataTable getUserList()
        {
            DBCON cn = new DBCON();
            cn.thisCon.Open();

            String sql = "select customers.customer_name as Name, customers.phone_number as Phone,"
                         + " customers.email as Mail, customer_address.street as Street, customer_address.city as City," 
                         + " countries.country_name as Country from customers left join customer_address" 
                         + " on customers.customer_id = customer_address.customer_id join" 
                         + " countries on customer_address.country_id = countries.country_id";
            OracleDataAdapter adapter = new OracleDataAdapter(sql, cn.thisCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.thisCon.Close();

            return dt;
        }
        public static DataTable getHotelList()
        {
            DBCON cn = new DBCON();
            cn.thisCon.Open();

            String sql = "select hotel_info.hotel_name as Name, hotel_info.hotel_type as Type, locations.location_name as Location from hotel_info join locations on hotel_info.location_id = locations.location_id";
            OracleDataAdapter adapter = new OracleDataAdapter(sql, cn.thisCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.thisCon.Close();

            return dt;
        }
        public static DataTable searchHotel(String searchItem)
        {
            DBCON cn = new DBCON();
            cn.thisCon.Open();

            String sql = "select hotel_info.hotel_name as Name, hotel_info.hotel_type as Type, locations.location_name as Location"
                         + " from hotel_info join locations"
                         + " on hotel_info.location_id = locations.location_id"
                         + " where lower(hotel_name) like '%" + searchItem + "%' or lower(location_name) like '%" + searchItem + "%'";
            OracleDataAdapter adapter = new OracleDataAdapter(sql, cn.thisCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.thisCon.Close();

            return dt;
        }
        public static DataTable searchCustomer(String searchString)
        {
            DBCON cn = new DBCON();
            cn.thisCon.Open();

            String sql = "select customers.customer_name as Name, customers.phone_number as Phone,"
                          + " customers.email as Mail, customer_address.street as Street, customer_address.city as City,"
                          + " countries.country_name as Country from customers left join customer_address"
                          + " on customers.customer_id = customer_address.customer_id join countries"
                          + " on customer_address.country_id = countries.country_id where"
                          + " lower(customer_name) like '%" + searchString + "%' or lower(email) like '&" + searchString + "&' or"
                          + " lower(city) like '%" + searchString + "%' or lower(country_name) like '%" + searchString + "%'";

            OracleDataAdapter adapter = new OracleDataAdapter(sql, cn.thisCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.thisCon.Close();

            return dt;
        }
        public static DataTable getLoginHistory()
        {
            DBCON cn = new DBCON();
            cn.thisCon.Open();

            String sql = "select user_login.user_name, log_in_history.login_time,"
                          + " log_in_history.logout_time from user_login join log_in_history on"
                          + " user_login.user_id = log_in_history.customer_id";

            OracleDataAdapter adapter = new OracleDataAdapter(sql, cn.thisCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.thisCon.Close();

            return dt;
        }
        public static DataTable searchLoginHistory(String searchText)
        {
            DBCON cn = new DBCON();
            cn.thisCon.Open();

            String sql = "select user_login.user_name, log_in_history.login_time,"
                          + " log_in_history.logout_time from user_login join log_in_history on"
                          + " user_login.user_id = log_in_history.customer_id"
                          + " where TO_CHAR(login_time, 'dd/mm/yyyy') like '%"+searchText+"%' or"
                          + " TO_CHAR(logout_time, 'dd/mm/yyyy') like '%"+searchText+"%' or "
                           + " lower(user_name) like '%"+searchText+"%'";

            OracleDataAdapter adapter = new OracleDataAdapter(sql, cn.thisCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.thisCon.Close();

            return dt;
        }
        public static bool addNewHotel(String hotelName, String hotelType, String rooFare, String suiteFare, String locationId)
        {
            try
            {
                DBCON cn = new DBCON();
                String addnewHotel = "begin add_new_hotel('" + hotelName + "', '" + hotelType + "', " + float.Parse(rooFare) + ", " + float.Parse(suiteFare) + ", " + int.Parse(locationId) + "); end;";
                OracleCommand cmd = new OracleCommand(addnewHotel, cn.thisCon);

                cn.thisCon.Open();
                cmd.ExecuteNonQuery();
                cn.thisCon.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool addNewLocation(String countryId, String locationName)
        {
            try
            {
                DBCON cn = new DBCON();
                String addnewHotel = "begin add_new_location(" + int.Parse(countryId) + ", '" + locationName + "'); end;";
                OracleCommand cmd = new OracleCommand(addnewHotel, cn.thisCon);

                cn.thisCon.Open();
                cmd.ExecuteNonQuery();
                cn.thisCon.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void createNewBooking(String hotelId, String rooms, String suites, String checkIn, String checkOut)
        {
            //try
            //{
                DBCON cn = new DBCON();
                String createBookingSql = "begin create_new_booking(" + int.Parse(hotelId) + ", " + Customer.CustomerInfo.UserId + ", " + int.Parse(rooms) + ", " + int.Parse(suites) + ", '" + checkIn + "', '" + checkOut + "'); end;";
                OracleCommand cmd = new OracleCommand(createBookingSql, cn.thisCon);

                cn.thisCon.Open();
                cmd.ExecuteNonQuery();
                cn.thisCon.Close();
                
            /*}
            catch
            {
                return false;
            }*/
        }
        public static DataTable getLastBookingInfo()
        {
            DBCON cn = new DBCON();
            cn.thisCon.Open();

            String sql = "select * from hotel_book where customer_id = " + Customer.CustomerInfo.UserId + " and book_id = (select max(book_id) from hotel_book where customer_id = " + Customer.CustomerInfo.UserId + ")";

            OracleDataAdapter adapter = new OracleDataAdapter(sql, cn.thisCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.thisCon.Close();

            return dt;
        }
        public static DataTable getCurrentBookings()
        {
            DBCON cn = new DBCON();
            cn.thisCon.Open();

            String sql = "select hotel_book.book_id as ID, hotel_info.hotel_name as Hotel,"
                          + " hotel_book.rooms, hotel_book.suites, hotel_book.book_date, hotel_book.check_in,"
                          + " hotel_book.check_out, hotel_book.total_cost from hotel_book join hotel_info"
                          + " on hotel_book.hotel_id = hotel_info.hotel_id where customer_id = " + Customer.CustomerInfo.UserId + "";

            OracleDataAdapter adapter = new OracleDataAdapter(sql, cn.thisCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.thisCon.Close();

            return dt;
        }
        public static DataTable searchCurrentBookings(String searchText)
        {
            DBCON cn = new DBCON();
            cn.thisCon.Open();

            String sql = "select hotel_book.book_id as ID, hotel_info.hotel_name as Hotel,"
                         + " hotel_book.rooms, hotel_book.suites, hotel_book.book_date, hotel_book.check_in,"
                         + " hotel_book.check_out, hotel_book.total_cost from hotel_book join hotel_info on"
                         + " hotel_book.hotel_id = hotel_info.hotel_id where customer_id = 1 and check_in"
                         + " like '%" + searchText + "%' or check_out like '%" + searchText + "%'";

            OracleDataAdapter adapter = new OracleDataAdapter(sql, cn.thisCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.thisCon.Close();

            return dt;
        }
        public static void deleteBooking(String bookId)
        {
            DBCON cn = new DBCON();
            String deleteBookingSql = "delete from hotel_book where customer_id = " + Customer.CustomerInfo.UserId + " and book_id = " + int.Parse(bookId) + "";
            OracleCommand cmd = new OracleCommand(deleteBookingSql, cn.thisCon);

            cn.thisCon.Open();
            cmd.ExecuteNonQuery();
            cn.thisCon.Close();
        }
        public static void updateBooking(String bookId, String rooms, String suites, String checkIn, String checkOut)
        {
            DBCON cn = new DBCON();
            cn.thisCon.Open();

            String sql = "begin update_booking(" + int.Parse(bookId) + ", " + Customer.CustomerInfo.UserId + ", " + int.Parse(rooms) + ", " + int.Parse(suites) + ", '" + checkIn + "', '" + checkOut + "'); end;";

            OracleCommand cmd = new OracleCommand(sql, cn.thisCon);

            cmd.ExecuteNonQuery();
            cn.thisCon.Close();
        }
        public static DataTable searchBookIdWise(String bookId)
        {
            DBCON cn = new DBCON();
            cn.thisCon.Open();

            String sql = "select * from hotel_book where customer_id = " + Customer.CustomerInfo.UserId + " and to_char(book_id) = '" + bookId + "'";

            OracleDataAdapter adapter = new OracleDataAdapter(sql, cn.thisCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.thisCon.Close();

            return dt;
        }
        public static DataTable viewBookings()
        {
            DBCON cn = new DBCON();
            cn.thisCon.Open();

            String sql = "select customers.customer_name as Name, hotel_info.hotel_name as Hotel,"
                         + " hotel_book.rooms, hotel_book.suites, hotel_book.book_date, hotel_book.check_in,"
                         + " hotel_book.check_out, hotel_book.total_cost from hotel_book join hotel_info"
                         + " on hotel_book.hotel_id = hotel_info.hotel_id join customers on"
                         + " hotel_book.customer_id = customers.customer_id";

            OracleDataAdapter adapter = new OracleDataAdapter(sql, cn.thisCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.thisCon.Close();

            return dt;
        }
        public static DataTable adminSearchBooking(String searchText)
        {
            DBCON cn = new DBCON();
            cn.thisCon.Open();

            String sql = "select customers.customer_name as Name, hotel_info.hotel_name as Hotel,"
                         + " hotel_book.rooms, hotel_book.suites, hotel_book.book_date, hotel_book.check_in,"
                         + " hotel_book.check_out, hotel_book.total_cost from hotel_book join hotel_info"
                         + " on hotel_book.hotel_id = hotel_info.hotel_id join customers on"
                         + " hotel_book.customer_id = customers.customer_id where lower(customer_name)"
                         + " like '%" + searchText + "%' and lower(hotel_name) like '%" + searchText + "%'";
            OracleDataAdapter adapter = new OracleDataAdapter(sql, cn.thisCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.thisCon.Close();

            return dt;
        }
    }
}
