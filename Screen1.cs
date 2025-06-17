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
    public partial class Screen1 : Form
    {
        public Screen1()
        {
            InitializeComponent();
        }
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HBMGQQD\\SQLEXPRESS;Initial Catalog=Booking_master;Integrated Security=True");
        private void btnBack_Click(object sender, EventArgs e)
        {
            Home HM = new Home();
            HM.Show();
            this.Hide();
        }

        private void btnPlatinum_Click(object sender, EventArgs e)
        {
            Seates Sobj = new Seates();
            Sobj.Show();
            this.Hide();
        }
        public static String date;
        private void btnDate12_Click(object sender, EventArgs e)
        {
            date = btnDate12.Text;
            pnlTime.Visible = true;
        }

        private void btnDate13_Click(object sender, EventArgs e)
        {
            date = btnDate13.Text;
            pnlTime.Visible = true;
        }

        private void btnDate14_Click(object sender, EventArgs e)
        {
            date = btnDate14.Text;
            pnlTime.Visible = true;
        }

        private void btnDate15_Click(object sender, EventArgs e)
        {
            date = btnDate15.Text;
            pnlTime.Visible = true;
        }
        public static String Time;

        private void btn8am_Click(object sender, EventArgs e)
        {
            Time = btn8am.Text;
            Seates seat = new Seates();
            seat.Show();
            this.Hide();
        }

        private void btn10am_Click(object sender, EventArgs e)
        {
            Time = btn10am.Text;
            Seates seat = new Seates();
            seat.Show();
            this.Hide();
        }

        private void btn12pm_Click(object sender, EventArgs e)
        {
            Time = btn12pm.Text;
            Seates seat = new Seates();
            seat.Show();
            this.Hide();
        }

        private void btn2pm_Click(object sender, EventArgs e)
        {
            Time = btn2pm.Text;
            Seates seat = new Seates();
            seat.Show();
            this.Hide();
        }

        private void btn4pm_Click(object sender, EventArgs e)
        {
            Time = btn4pm.Text;
            Seates seat = new Seates();
            seat.Show();
            this.Hide();
        }

        private void btn6pm_Click(object sender, EventArgs e)
        {
            Time = btn6pm.Text;
            Seates seat = new Seates();
            seat.Show();
            this.Hide();
        }

        private void btn8pm_Click(object sender, EventArgs e)
        {
            Time = btn8pm.Text;
            Seates seat = new Seates();
            seat.Show();
            this.Hide();
        }

        private void btn10pm_Click(object sender, EventArgs e)
        {
            Time = btn10pm.Text;
            Seates seat = new Seates();
            seat.Show();
            this.Hide();
        }

        private void btn12am_Click(object sender, EventArgs e)
        {
            Time = btn12am.Text;
            Seates seat = new Seates();
            seat.Show();
            this.Hide();
        }
    }
}
