using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ATMSystem
{
    public partial class formLogin : Form
    {
        // slide show
        private int currentImageIndex = 0;
        private Image[] images = new Image[3];

        //public variable  AccNumber, for banlance check , deposit , withdraw 
        public static String AccNumber;


        //SqlConnection
        private string connectionString = "Data Source=sql.itiohub.com;Initial Catalog=atmSystem;Persist Security Info=True;User ID=sa;Password=Adamson.edu.ph";
        public formLogin()
        {
            InitializeComponent();

            //loading image
            images[0] = Image.FromFile("E:/OneDrive/OneDrive - adamson.edu.ph/Pictures/Labactivity/final/1.jpg");
            images[1] = Image.FromFile("E:/OneDrive/OneDrive - adamson.edu.ph/Pictures/Labactivity/final/2.jpg");
            images[2] = Image.FromFile("E:/OneDrive/OneDrive - adamson.edu.ph/Pictures/Labactivity/final/3.jpg");

            //display first image
            pictureBox1.Image = images[0];

            //setup timer 
            timer1.Interval = 5000;
            timer1.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //timer for slideshow
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % images.Length;
            pictureBox1.Image = images[currentImageIndex];
        }

        //btnRegister
        private void btnReg_Click(object sender, EventArgs e)
        {
            Form register = new Regsiter();
            register.Show();
            this.Hide();
        }

        //btnLogin
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = txtUsername.Text;
            string password = txtPassword.Text;
            AccNumber =  txtUsername.Text;

            if (ValidateUser(userId, password))
            {
                MessageBox.Show("Login succeefull! Wlecome !");
                DashMain dashMain = new DashMain();  //main form 
                dashMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Account number or Password");
            }
        }

        //validate user  method
        private bool ValidateUser(string userId, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Use parameterized queries to prevent SQL injection attacks
                    string query = "SELECT COUNT(*) FROM userInfo WHERE id = @userId AND password = @password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userId", userId);
                        command.Parameters.AddWithValue("@password", password);
                        int count = (int)command.ExecuteScalar();//  that excuter  the result is int , 1 or 0;  1 means is true . 0 is false
                        connection.Close();
                        return count > 0; // If the record exists, the validation passes
                    }  
                }
            }
            catch (Exception ex)
            {
                // handle exception
                MessageBox.Show("Eorro：" + ex.Message);
                return false; // verification failed
            }
        }

        //exit button 
        private void sbolbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
