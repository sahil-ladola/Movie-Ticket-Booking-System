using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (Seates.invoice.ToString() == txtInvoice.Text)
            {
                txtMovie.Text = Home.MovieName;
                if (Screen3.Time != null)
                {
                    txtScreen.Text = "3";
                    txtTime.Text = Screen3.Time;
                }
                else if (Screen2.Time != null)
                {
                    txtScreen.Text = "2";
                    txtTime.Text = Screen2.Time;
                }
                else if (Screen1.Time != null)
                {
                    txtScreen.Text = "1";
                    txtTime.Text = Screen1.Time;
                }
                if (Screen3.date != null)
                {
                    txtDate.Text = Screen3.date;
                }
                else if (Screen2.date != null)
                {
                    txtDate.Text = Screen2.date;
                }
                else if (Screen1.date != null)
                {
                    txtDate.Text = Screen1.date;
                }
                txtTotal.Text = Seates.total.ToString();
            }
            
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Tickets are Booked successfully");
            this.Hide();
            Home Hm = new Home();
            Hm.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HBMGQQD\\SQLEXPRESS;Initial Catalog=Booking_master;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            String query = "delete from Booking_Details where Invoice_Id=" + txtInvoice.Text + ";";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your Tickets are Cancelled successfully");
            Home Hm = new Home();
            Hm.Show();
            this.Hide();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            txtInvoice.Text = Seates.invoice.ToString();
        }
    }
}
