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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        //sql connection and variable 
        SqlConnection Con = new SqlConnection("Data Source=sql.itiohub.com;Initial Catalog=atmSystem;Persist Security Info=True;User ID=sa;Password=Adamson.edu.ph");
        String AccountNumber = formLogin.AccNumber;

        //btnBack
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            DashMain back = new DashMain();
            back.Show();
            this.Close();
        }

    
        //populate method  is populate data into data grid viewer
        private void populate()
        { 
            Con.Open();

            string query = "SELECT * FROM HistoryTbl WHERE AccNum='" + AccountNumber + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            var ds = new DataSet();
            sda.Fill(ds);
            dataViewerDGV.DataSource = ds.Tables[0];

            Con.Close();
        }

        //when the form load ,  execute  populate method
        private void History_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
