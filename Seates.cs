using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login
{
    public partial class Seates : Form
    {
        public Seates()
        {
            InitializeComponent();
        }
        String Date,time;
        
        private void Seates_Load(object sender, EventArgs e)
        {
            if (Screen3.date != null)
            {
                lblDate.Text = Screen3.date;
                Date = Screen3.date;
            }
            else if(Screen2.date != null)
            {
                lblDate.Text = Screen2.date;
                Date = Screen2.date;
            }
            else if(Screen1.date != null)
            {
                lblDate.Text = Screen1.date;
                Date = Screen1.date;
            }
            lblMovieName.Text=Home.MovieName;
            if (Screen3.Time != null)
            {
                lblScreen.Text = "3";
                lblTime.Text = Screen3.Time;
                time = Screen3.Time;
            }
            else if(Screen2.Time !=null)
            {
                lblScreen.Text = "2";
                lblTime.Text = Screen2.Time;
                time = Screen2.Time;
            }
            else if(Screen1.Time != null)
            {
                lblScreen.Text = "1";
                lblTime.Text = Screen1.Time;
                time = Screen1.Time;
            }
            grpPlatinum.Enabled = grpGold.Enabled = grpSilver.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(Screen1.date != null)
            {
                Screen1 S1 = new Screen1();
                S1.Show();
                this.Hide();
            }
            if (Screen2.date != null)
            {
                Screen2 S2 = new Screen2();
                S2.Show();
                this.Hide();
            }
            if (Screen3.date != null)
            {
                Screen3 S3 = new Screen3();
                S3.Show();
                this.Hide();
            }
        }
        public static int totalP = 0;
        public static int totalG = 0;
        public static int totalS = 0;
        private void calprice()
        {
            lblTotal.Text = (totalP + 300).ToString();
            totalP = Convert.ToInt32(lblTotal.Text);
        }
        public void calpriceG()
        {
            lblTotal.Text = (totalG + 170).ToString();
            totalG = Convert.ToInt32(lblTotal.Text);
         
        }
        public void calpriceS()
        {
            lblTotal.Text = (totalS + 110).ToString();
            totalS = Convert.ToInt32(lblTotal.Text);
        }
        private void A1_CheckedChanged(object sender, EventArgs e)
        {
            calprice();
        }

        private void A2_CheckedChanged(object sender, EventArgs e)
        {
            calprice();
        }

        private void A3_CheckedChanged(object sender, EventArgs e)
        {
            calprice();
        }

        private void A4_CheckedChanged(object sender, EventArgs e)
        {
            calprice();
        }

        private void A5_CheckedChanged(object sender, EventArgs e)
        {
            calprice();
        }

        private void A6_CheckedChanged(object sender, EventArgs e)
        {
            calprice();
        }

        private void A7_CheckedChanged(object sender, EventArgs e)
        {
            calprice();
        }

        private void A8_CheckedChanged(object sender, EventArgs e)
        {
            calprice();
        }

        private void A9_CheckedChanged(object sender, EventArgs e)
        {
            calprice();
        }

        private void A10_CheckedChanged(object sender, EventArgs e)
        {
            calprice();
        }

        private void A11_CheckedChanged(object sender, EventArgs e)
        {
            calprice();
        }

        private void A12_CheckedChanged(object sender, EventArgs e)
        {
            calprice();
        }

        private void A13_CheckedChanged(object sender, EventArgs e)
        {
            calprice();
        }

        private void A14_CheckedChanged(object sender, EventArgs e)
        {
            calprice();
        }
        
        private void B1_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void B2_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void B3_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void B4_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void B5_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void B6_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void B7_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void B8_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void B9_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void B10_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void B11_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void B12_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void B13_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void B14_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void C14_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void C13_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void C12_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void C11_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void C10_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void C9_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void C8_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void C7_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void C6_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void C5_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void C4_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void C3_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void C2_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void C1_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void D1_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void D2_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void D3_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void D4_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void D5_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void D6_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void D7_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void D8_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void D9_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void D10_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void D11_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void D12_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void D13_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void D14_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void E14_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void E13_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void E12_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void E11_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void E10_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void E9_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void E8_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void E7_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void E6_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void E5_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void E4_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void E3_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void E2_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void E1_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void F1_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void F2_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void F3_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void F4_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void F5_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void F6_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void F7_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void F8_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void F9_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void F10_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void F11_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void F12_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void F13_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }

        private void F14_CheckedChanged(object sender, EventArgs e)
        {
            calpriceG();
        }
        
        private void G14_CheckedChanged(object sender, EventArgs e)
        {
            calpriceS();
        }

        private void G13_CheckedChanged(object sender, EventArgs e)
        {
            calpriceS();
        }

        private void G12_CheckedChanged(object sender, EventArgs e)
        {
            calpriceS();
        }

        private void G11_CheckedChanged(object sender, EventArgs e)
        {
            calpriceS();
        }

        private void G10_CheckedChanged(object sender, EventArgs e)
        {
            calpriceS();
        }

        private void G9_CheckedChanged(object sender, EventArgs e)
        {
            calpriceS();
        }

        private void G8_CheckedChanged(object sender, EventArgs e)
        {
            calpriceS();
        }

        private void G7_CheckedChanged(object sender, EventArgs e)
        {
            calpriceS();
        }

        private void G6_CheckedChanged(object sender, EventArgs e)
        {
            calpriceS();
        }

        private void G5_CheckedChanged(object sender, EventArgs e)
        {
            calpriceS();
        }

        private void G4_CheckedChanged(object sender, EventArgs e)
        {
            calpriceS();
        }

        private void G3_CheckedChanged(object sender, EventArgs e)
        {
            calpriceS();
        }

        private void G2_CheckedChanged(object sender, EventArgs e)
        {
            calpriceS();
        }

        private void G1_CheckedChanged(object sender, EventArgs e)
        {
            calpriceS();
        }

        private void btnPlat_Click(object sender, EventArgs e)
        {
            totalG = totalP = totalS = 0;
            lblTotal.Text = "0";
            grpPlatinum.Enabled = true;
            grpGold.Enabled = grpSilver.Enabled = false;
            B1.Checked = B2.Checked = B3.Checked = B4.Checked = B5.Checked = B6.Checked = B7.Checked = B8.Checked = B9.Checked = B10.Checked = B11.Checked = B12.Checked = B13.Checked = B14.Checked = C1.Checked = C2.Checked = C3.Checked = C4.Checked = C5.Checked = C6.Checked = C7.Checked = C8.Checked = C9.Checked = C10.Checked = C11.Checked = C12.Checked = C13.Checked = C14.Checked = D1.Checked = D2.Checked = D3.Checked = D4.Checked = D5.Checked = D6.Checked = D7.Checked = D8.Checked = D9.Checked = D10.Checked = D11.Checked = D12.Checked = D13.Checked = D14.Checked = E1.Checked = E2.Checked = E3.Checked = E4.Checked = E5.Checked = E6.Checked = E7.Checked = E8.Checked = E9.Checked = E10.Checked = F11.Checked = E12.Checked = F13.Checked = E14.Checked = F1.Checked = F2.Checked = F3.Checked = F4.Checked = F5.Checked = F6.Checked = F7.Checked = F8.Checked = F9.Checked = F10.Checked = E11.Checked = F12.Checked = E13.Checked = F14.Checked = G1.Checked = G2.Checked = G3.Checked = G4.Checked = G5.Checked = G6.Checked = G7.Checked = G8.Checked = G9.Checked = G10.Checked = G11.Checked = G12.Checked = G13.Checked = G14.Checked = false;
        }

        private void btnGold_Click(object sender, EventArgs e)
        {
            totalG = totalP = totalS = 0;
            lblTotal.Text = "0";
            grpGold.Enabled = true;
            grpPlatinum.Enabled = grpSilver.Enabled = false;
            A1.Checked = A2.Checked = A3.Checked = A4.Checked = A5.Checked = A6.Checked = A7.Checked = A8.Checked = A9.Checked = A10.Checked = A11.Checked = A12.Checked = A13.Checked = A14.Checked = G1.Checked = G2.Checked = G3.Checked = G4.Checked = G5.Checked = G6.Checked = G7.Checked = G8.Checked = G9.Checked = G10.Checked = G11.Checked = G12.Checked = G13.Checked = G14.Checked = false;
        }

        private void btnSilver_Click(object sender, EventArgs e)
        {
            totalG = totalP = totalS = 0;
            lblTotal.Text = "0";
            grpSilver.Enabled = true;
            grpPlatinum.Enabled = grpGold.Enabled = false;
            A1.Checked = A2.Checked = A3.Checked = A4.Checked = A5.Checked = A6.Checked = A7.Checked = A8.Checked = A9.Checked = A10.Checked = A11.Checked = A12.Checked = A13.Checked = A14.Checked = B1.Checked = B2.Checked = B3.Checked = B4.Checked = B5.Checked = B6.Checked = B7.Checked = B8.Checked = B9.Checked = B10.Checked = B11.Checked = B12.Checked = B13.Checked = B14.Checked = C1.Checked = C2.Checked = C3.Checked = C4.Checked = C5.Checked = C6.Checked = C7.Checked = C8.Checked = C9.Checked = C10.Checked = C11.Checked = C12.Checked = C13.Checked = C14.Checked = D1.Checked = D2.Checked = D3.Checked = D4.Checked = D5.Checked = D6.Checked = D7.Checked = D8.Checked = D9.Checked = D10.Checked = D11.Checked = D12.Checked = D13.Checked = D14.Checked = E1.Checked = E2.Checked = E3.Checked = E4.Checked = E5.Checked = E6.Checked = E7.Checked = E8.Checked = E9.Checked = E10.Checked = F11.Checked = E12.Checked = F13.Checked = E14.Checked = F1.Checked = F2.Checked = F3.Checked = F4.Checked = F5.Checked = F6.Checked = F7.Checked = F8.Checked = F9.Checked = F10.Checked = E11.Checked = F12.Checked = E13.Checked = F14.Checked = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "0";
            grpPlatinum.Enabled = grpGold.Enabled = grpSilver.Enabled = false;
            A1.Checked = A2.Checked = A3.Checked = A4.Checked = A5.Checked = A6.Checked = A7.Checked = A8.Checked = A9.Checked = A10.Checked = A11.Checked = A12.Checked = A13.Checked = A14.Checked = B1.Checked = B2.Checked = B3.Checked = B4.Checked = B5.Checked = B6.Checked = B7.Checked = B8.Checked = B9.Checked = B10.Checked = B11.Checked = B12.Checked = B13.Checked = B14.Checked = C1.Checked = C2.Checked = C3.Checked = C4.Checked = C5.Checked = C6.Checked = C7.Checked = C8.Checked = C9.Checked = C10.Checked = C11.Checked = C12.Checked = C13.Checked = C14.Checked = D1.Checked = D2.Checked = D3.Checked = D4.Checked = D5.Checked = D6.Checked = D7.Checked = D8.Checked = D9.Checked = D10.Checked = D11.Checked = D12.Checked = D13.Checked = D14.Checked = E1.Checked = E2.Checked = E3.Checked = E4.Checked = E5.Checked = E6.Checked = E7.Checked = E8.Checked = E9.Checked = E10.Checked = F11.Checked = E12.Checked = F13.Checked = E14.Checked = F1.Checked = F2.Checked = F3.Checked = F4.Checked = F5.Checked = F6.Checked = F7.Checked = F8.Checked = F9.Checked = F10.Checked = E11.Checked = F12.Checked = E13.Checked = F14.Checked = G1.Checked = G2.Checked = G3.Checked = G4.Checked = G5.Checked = G6.Checked = G7.Checked = G8.Checked = G9.Checked = G10.Checked = G11.Checked = G12.Checked = G13.Checked = G14.Checked = false;
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HBMGQQD\\SQLEXPRESS;Initial Catalog=Booking_master;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public static int total;
        public static int invoice;
        private void btnBook_Click(object sender, EventArgs e)
        {
            total =Convert.ToInt32( lblTotal.Text);
            Random obj = new Random();
            invoice = obj.Next(1000);
            con.Open();
            String query = "insert into Booking_Details values('" + Home.MovieName + "','" + Date + "','" + time + "','" + lblTotal.Text + "','"+invoice+"');";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Tickets Book Successfully\n   Invoice Id : " + invoice);
            Invoice PIobj = new Invoice();
            PIobj.Show();
            this.Hide();
            con.Close();
        }
    }
}
