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

namespace ATMSystem
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=sql.itiohub.com;Initial Catalog=atmSystem;Persist Security Info=True;User ID=sa;Password=Adamson.edu.ph");

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            DashMain back = new DashMain();
            back.Show();
            this.Close();
        }
        

        //getbalance method
        private void getBalance()
        { 
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT balance FROM userInfo WHERE id='"+ sybollabelAccountNumber.Text+ "'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            labelBalanceAmount.Text = "₱ "+ dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            sybollabelAccountNumber.Text = formLogin.AccNumber;
            getBalance();
        }
    }
}
