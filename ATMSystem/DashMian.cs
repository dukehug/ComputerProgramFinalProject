using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSystem
{
    public partial class DashMain : Form
    {
       
        public DashMain()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();
            this.Hide();
        }

        private void btnLoginOut_Click(object sender, EventArgs e)
        {
            formLogin loginout = new formLogin();
            loginout.Show();
            this.Hide();


        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            balance.Show();
            this.Hide();

        }

        private void WI_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
            this.Hide();
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            this.Hide();

        }

        private void DashMain_Load(object sender, EventArgs e)
        {
            labelCustomerNum.Text = "Your account number is:  " + formLogin.AccNumber;
        }

        private void symbtnLoginout_Click(object sender, EventArgs e)
        {
            formLogin loginout = new formLogin();
            loginout.Show();
            this.Hide();
        }
    }
}
