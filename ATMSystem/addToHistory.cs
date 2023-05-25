using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSystem
{
    internal class addToHistory
    {
        SqlConnection Con = new SqlConnection("Data Source=sql.itiohub.com;Initial Catalog=atmSystem;Persist Security Info=True;User ID=sa;Password=Adamson.edu.ph");

        //set account number = login account
        String AccNumber = formLogin.AccNumber;

        public void addToHistory500()
        {
            string type = "Withdraw";
            try
            {
                Con.Open();

                //sql insert data           table                 colum name
                string query = "INSERT INTO HistoryTbl VALUES('" + AccNumber + "','" + type + "','" + 500 + "','" + DateTime.Now.ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();

                Con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        public void addToHistory1000()
        {
            string type = "Withdraw";
            try
            {
                Con.Open();
                string query = "INSERT INTO HistoryTbl VALUES('" + AccNumber + "','" + type + "','" + 1000 + "','" + DateTime.Now.ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();

                Con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        public void addToHistory2000()
        {
            string type = "Withdraw";
            try
            {
                
                Con.Open();
                string query = "INSERT INTO HistoryTbl VALUES('" + AccNumber + "','" + type + "','" + 2000 + "','" + DateTime.Now.ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();

                Con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        public void addToHistory3000()
        {
            string type = "Withdraw";
            try
            {
                Con.Open();
                string query = "INSERT INTO HistoryTbl VALUES('" + AccNumber + "','" + type + "','" + 3000 + "','" + DateTime.Now.ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();

                Con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        public void addToHistory4000()
        {
            string type = "Withdraw";
            try
            {
                Con.Open();
                string query = "INSERT INTO HistoryTbl VALUES('" + AccNumber + "','" + type + "','" + 4000 + "','" + DateTime.Now.ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();

                Con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        public void addToHistory5000()
        {
            string type = "Withdraw";
            try
            {
                Con.Open();
                string query = "INSERT INTO HistoryTbl VALUES('" + AccNumber + "','" + type + "','" + 5000 + "','" + DateTime.Now.ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();

                Con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        public void addToHistory6000()
        {
            string type = "Withdraw";
            try
            {
                Con.Open();
                string query = "INSERT INTO HistoryTbl VALUES('" + AccNumber + "','" + type + "','" + 6000 + "','" + DateTime.Now.ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();

                Con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        public void addToHistory10000()
        {
            string type = "Withdraw";
            try
            {
                Con.Open();
                string query = "INSERT INTO HistoryTbl VALUES('" + AccNumber + "','" + type + "','" + 10000 + "','" + DateTime.Now.ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();

                Con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}
