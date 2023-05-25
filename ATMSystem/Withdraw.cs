using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSystem
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        //create a fasterwithdraw and addtohistory object
        FastWithdraw fastWithdraw = new FastWithdraw();
        addToHistory addTo = new addToHistory();

        //SqlConnection
        SqlConnection Con = new SqlConnection("Data Source=sql.itiohub.com;Initial Catalog=atmSystem;Persist Security Info=True;User ID=sa;Password=Adamson.edu.ph");

        string AccountNumber = formLogin.AccNumber;
        int balance , newbalance;


        //get balance method
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT balance FROM userInfo WHERE id='" + AccountNumber + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            labelAvailableBalance.Text = "Your current balance is:  ₱  " + dt.Rows[0][0].ToString();
            balance = Convert.ToInt32(dt.Rows[0][0].ToString());

            Con.Close();
        }


        //execute getbalance first  
        private void Withdraw_Load(object sender, EventArgs e)
        {
            getBalance();
        }

        // addToHistory method is store this operation in the history table
        private void addToHistory()
        {
            string type = "Withdraw";

            try
            {
                Con.Open();
                string query = "INSERT INTO HistoryTbl VALUES('" + AccountNumber + "','" + type + "','" + txtWithdrawAmount.Text + "','" + DateTime.Now.ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        //btn winthdraw
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            string userInput = txtWithdrawAmount.Text;
            int IntValue;


            if (txtWithdrawAmount.Text == "")
            {

                MessageBox.Show("Enter the amount to withdraw");

            }
            else if (!int.TryParse(userInput, out IntValue))
            {

                MessageBox.Show("Enter a valid amount");

            }
            else if (Convert.ToInt32(txtWithdrawAmount.Text) > balance)
            {

                MessageBox.Show("Your balance is not enough");

            }
            else
            {
                try 
                {
                    newbalance = balance - Convert.ToInt32(txtWithdrawAmount.Text);

                    try
                    {
                        //update database
                        Con.Open();
                        String query = "UPDATE userInfo SET balance=" + newbalance + " WHERE id='" + AccountNumber + "'";

                        SqlCommand cmd = new SqlCommand(query, Con);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Success Withdraw!");

                        Con.Close();

                        addToHistory();

                        getBalance();

                        txtWithdrawAmount.Text = string.Empty;


                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Deposit failed! Pleas contact managerment!");

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            }
        }

        //btn back
        private void sybolbtnBack_Click(object sender, EventArgs e)
        {
            DashMain back = new DashMain();
            back.Show();
            this.Close();
        }


        private void btn500_Click(object sender, EventArgs e)
        {
            if (balance < 500)
            {
                MessageBox.Show("Balance not enough!");

            }
            else
            { 
                fastWithdraw.Withdraw500();
                addTo.addToHistory500();
                getBalance();
            }
        }

        private void labelAvailableBalance_Click(object sender, EventArgs e)
        {
            getBalance();
        }


        private void btn1000_Click(object sender, EventArgs e)
        {
            if (balance < 1000)
            {
                MessageBox.Show("Balance not enough!");

            }
            else
            {
                fastWithdraw.Withdraw1000();
                addTo.addToHistory1000();
                getBalance();
            }
        }

        private void btn2000_Click(object sender, EventArgs e)
        {
            if (balance < 2000)
            {
                MessageBox.Show("Balance not enough!");

            }
            else
            {
                fastWithdraw.Withdraw2000();
                addTo.addToHistory2000();
                getBalance();
            }
        }

        private void btn3000_Click(object sender, EventArgs e)
        {
            if (balance < 3000)
            {
                MessageBox.Show("Balance not enough!");

            }
            else
            {
                fastWithdraw.Withdraw3000();
                addTo.addToHistory3000();
                getBalance();
            }
        }

        private void btn4000_Click(object sender, EventArgs e)
        {
            if (balance < 4000)
            {
                MessageBox.Show("Balance not enough!");

            }
            else
            {
                fastWithdraw.Withdraw4000();
                addTo.addToHistory4000();
                getBalance();
            }
        }

        private void btn5000_Click(object sender, EventArgs e)
        {
            if (balance < 5000)
            {
                MessageBox.Show("Balance not enough!");

            }
            else
            {
                fastWithdraw.Withdraw5000();
                addTo.addToHistory5000();
                getBalance();
            }
        }

        private void btn6000_Click(object sender, EventArgs e)
        {
            if (balance < 6000)
            {
                MessageBox.Show("Balance not enough!");

            }
            else
            {
                fastWithdraw.Withdraw6000();
                addTo.addToHistory6000();
                getBalance();
            }
        }

        private void btn10000_Click(object sender, EventArgs e)
        {
            if (balance < 10000)
            {
                MessageBox.Show("Balance not enough!");

            }
            else
            {
                fastWithdraw.Withdraw10000();
                addTo.addToHistory10000();
                getBalance();
            }
        }
    }
}
