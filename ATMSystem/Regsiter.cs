using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATMSystem
{
    public partial class Regsiter : Form
    {
        public Regsiter()
        {
            InitializeComponent();
            //when register form load  get a random account number
            RandomMethod randomNum = new RandomMethod();

            labelAccount.Text = randomNum.RandomMeth();

        }

        //btnSubmit   
        private void sybolbtnSubmit_Click(object sender, EventArgs e)
        {

            //validate user input format and data type
            string phoneNum = textBoxPhoneNumber.Text;
            string email = textBoxEmail.Text;
            int number;


            //regular expression   (using System.Text.RegularExpressions;)
            string phonePattern = @"^\d{11}$";
            string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

            if (!Regex.IsMatch(phoneNum, phonePattern) || !Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Phone number and Email address incorrect format ");


            }
            else if (int.TryParse(phoneNum, out number))
            {

                MessageBox.Show("Please enter a number for phone number ");

            }
            else if (textBoxPassword.TextLength < 1)
            {
                MessageBox.Show("Do you forget to enter password??");

            }
            else
            {
                string message = "Please remember your Account number! The registration information has been submitted, please click OK to return to the login interface to log in.";
                string title = "Information";

                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result = MessageBox.Show(message, title, buttons, icon);

                if (result == DialogResult.OK)
                {
                    SqlConnection conn = new SqlConnection("Data Source=sql.itiohub.com;Initial Catalog=atmSystem;User ID=sa;Password=Adamson.edu.ph");

                    conn.Open();
                    //sql insert data           table                               colum name
                    SqlCommand cmd = new SqlCommand("INSERT INTO userInfo VALUES(@id,@password,@phone,@address,@email,@name,@regdate,@balance)", conn);

                    cmd.Parameters.AddWithValue("@id", int.Parse(labelAccount.Text));
                    cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    cmd.Parameters.AddWithValue("@phone", textBoxPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@address", textBoxAddress.Text);
                    cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@regdate", dateTimePick.Value);
                    cmd.Parameters.AddWithValue("@balance", 0);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    formLogin back = new formLogin();
                    back.Show();
                    this.Close();

                }
                else
                {
                    textBoxPassword.Focus();
                }

            }
        }

        //back button 
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }
    }
}
