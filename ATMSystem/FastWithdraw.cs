using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSystem
{
    internal class FastWithdraw
    {
        //SqlConnection
        SqlConnection Con = new SqlConnection("Data Source=sql.itiohub.com;Initial Catalog=atmSystem;Persist Security Info=True;User ID=sa;Password=Adamson.edu.ph");

        string AccountNumber = formLogin.AccNumber;

        int balance;

        //getbanlance method
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT balance FROM userInfo WHERE id='" + AccountNumber + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balance = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }

        //for quikwithdraw btn 500
        public void Withdraw500()
        {
            getBalance();

            try
            {
                int withdrawAmount = 500;
                int newbalance = balance - withdrawAmount;

                try
                {
                    //update database
                    Con.Open();
                    String query = "UPDATE userInfo SET balance=" + newbalance + " WHERE id='" + AccountNumber + "'";

                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Success Withdraw!");

                    Con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Withdraw failed! Pleas contact managerment!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //for quikwithdraw btn 1000
        public void Withdraw1000()
        {
            getBalance();

            try
            {
                int withdrawAmount = 1000;
                int newbalance = balance - withdrawAmount;

                try
                {
                    //update database
                    Con.Open();
                    String query = "UPDATE userInfo SET balance=" + newbalance + " WHERE id='" + AccountNumber + "'";

                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Success Withdraw!");

                    Con.Close();

                }
                catch (Exception)
                {

                    MessageBox.Show("Withdraw failed! Pleas contact managerment!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //for quikwithdraw btn 2000
        public void Withdraw2000()
        {
            getBalance();

            try
            {
                int withdrawAmount = 2000;
                int newbalance = balance - withdrawAmount;

                try
                {
                    //update database
                    Con.Open();
                    String query = "UPDATE userInfo SET balance=" + newbalance + " WHERE id='" + AccountNumber + "'";

                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Success Withdraw!");

                    Con.Close();

                }
                catch (Exception)
                {

                    MessageBox.Show("Withdraw failed! Pleas contact managerment!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //for quikwithdraw btn 3000
        public void Withdraw3000()
        {
            getBalance();

            try
            {
                int withdrawAmount = 3000;
                int newbalance = balance - withdrawAmount;

                try
                {
                    //update database
                    Con.Open();
                    String query = "UPDATE userInfo SET balance=" + newbalance + " WHERE id='" + AccountNumber + "'";

                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Success Withdraw!");

                    Con.Close();

                }
                catch (Exception)
                {

                    MessageBox.Show("Withdraw failed! Pleas contact managerment!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //for quikwithdraw btn 4000
        public void Withdraw4000()
        {
            getBalance();

            try
            {
                int withdrawAmount = 4000;
                int newbalance = balance - withdrawAmount;

                try
                {
                    //update database
                    Con.Open();
                    String query = "UPDATE userInfo SET balance=" + newbalance + " WHERE id='" + AccountNumber + "'";

                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Success Withdraw!");

                    Con.Close();

                }
                catch (Exception)
                {

                    MessageBox.Show("Withdraw failed! Pleas contact managerment!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //for quikwithdraw btn 5000
        public void Withdraw5000()
        {
            getBalance();

            try
            {
                int withdrawAmount = 5000;
                int newbalance = balance - withdrawAmount;

                try
                {
                    //update database
                    Con.Open();
                    String query = "UPDATE userInfo SET balance=" + newbalance + " WHERE id='" + AccountNumber + "'";

                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Success Withdraw!");

                    Con.Close();

                }
                catch (Exception)
                {

                    MessageBox.Show("Withdraw failed! Pleas contact managerment!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //for quikwithdraw btn 6000
        public void Withdraw6000()
        {
            getBalance();

            try
            {
                int withdrawAmount = 6000;
                int newbalance = balance - withdrawAmount;

                try
                {
                    //update database
                    Con.Open();
                    String query = "UPDATE userInfo SET balance=" + newbalance + " WHERE id='" + AccountNumber + "'";

                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Success Withdraw!");

                    Con.Close();

                }
                catch (Exception)
                {

                    MessageBox.Show("Withdraw failed! Pleas contact managerment!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        } 
        
        
        //for quikwithdraw btn 10000
        public void Withdraw10000()
        {
            getBalance();

            try
            {
                int withdrawAmount = 10000;
                int newbalance = balance - withdrawAmount;

                try
                {
                    //update database
                    Con.Open();
                    String query = "UPDATE userInfo SET balance=" + newbalance + " WHERE id='" + AccountNumber + "'";

                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Success Withdraw!");

                    Con.Close();

                }
                catch (Exception)
                {

                    MessageBox.Show("Withdraw failed! Pleas contact managerment!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
