using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Services.Client;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sunny.UI.Win32;

namespace ATMSystem
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=sql.itiohub.com;Initial Catalog=atmSystem;Persist Security Info=True;User ID=sa;Password=Adamson.edu.ph");

        //set account number = login account
        String AccNumber = formLogin.AccNumber;

        // new balance = deposit amount + oldbalance
        int oldbalance, newbalance;


        // addToHistory method is store this operation in the history table
        private void addToHistory()
        {
            string type = "Deposit";
            try
            {
                Con.Open();
                string query = "INSERT INTO HistoryTbl VALUES('"+ AccNumber + "','"+ type + "','"+ txtDeposit.Text + "','"+ DateTime.Now.ToString() + "')";
                
                SqlCommand cmd = new SqlCommand(query,Con);

                cmd.ExecuteNonQuery();

                Con.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        //btn deposit
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string userInput = txtDeposit.Text;
            int IntValue;

            //validate user input
            if (txtDeposit.Text == "")
            {
                MessageBox.Show("Enter the amount to deposit!");
            }
            else if (!int.TryParse(userInput, out IntValue))
            {
                MessageBox.Show("Please Enter a valid amount");
            }
            else
            {
                //new balance 
                newbalance = oldbalance + Convert.ToInt32(txtDeposit.Text);

                try
                {
                    //update database
                    Con.Open();
                    String query = "UPDATE userInfo SET balance=" + newbalance + " WHERE id='" + AccNumber + "'";

                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Deposit Success!");

                    Con.Close();

                    addToHistory();

                }
                catch (Exception)
                {

                    MessageBox.Show("Deposit failed! Pleas contact managerment!");

                }

            }
        }

        //button back
        private void btnBack_Click(object sender, EventArgs e)
        {
            DashMain back = new DashMain();
            back.Show();
            this.Close();

        }

        //get balance method
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT balance FROM userInfo WHERE id='" + AccNumber + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldbalance =  Convert.ToInt32 (dt.Rows[0][0].ToString());
            Con.Close();
        }

        //when deposit form load , call getBalance();
        private void Deposit_Load(object sender, EventArgs e)
        {
            getBalance();
        }
    }
}
