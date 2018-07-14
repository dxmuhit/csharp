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
    public partial class BookingConfirmation : Form
    {
        public BookingConfirmation()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BookingConfirmation_Load(object sender, EventArgs e)
        {
            DataTable dt = DBcon.EventHandler.getLastBookingInfo();
            bookIdLabel.Text = dt.Rows[0][0].ToString();
            totalCostLabel.Text = dt.Rows[0][8].ToString();
        }
    }
}
