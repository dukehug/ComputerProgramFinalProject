namespace ATMSystem
{
    partial class DashMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDashmain = new Sunny.UI.UITitlePanel();
            this.labelCustomerNum = new Sunny.UI.UILabel();
            this.uiButton4 = new Sunny.UI.UIButton();
            this.btnBalance = new Sunny.UI.UIButton();
            this.WI = new Sunny.UI.UIButton();
            this.btnDeposit = new Sunny.UI.UIButton();
            this.labelWelcomeCustomer = new Sunny.UI.UILabel();
            this.symbtnLoginout = new Sunny.UI.UISymbolButton();
            this.panelDashmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDashmain
            // 
            this.panelDashmain.Controls.Add(this.symbtnLoginout);
            this.panelDashmain.Controls.Add(this.labelCustomerNum);
            this.panelDashmain.Controls.Add(this.labelWelcomeCustomer);
            this.panelDashmain.Controls.Add(this.uiButton4);
            this.panelDashmain.Controls.Add(this.btnDeposit);
            this.panelDashmain.Controls.Add(this.btnBalance);
            this.panelDashmain.Controls.Add(this.WI);
            this.panelDashmain.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelDashmain.Location = new System.Drawing.Point(31, 11);
            this.panelDashmain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDashmain.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelDashmain.Name = "panelDashmain";
            this.panelDashmain.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.panelDashmain.ShowText = false;
            this.panelDashmain.Size = new System.Drawing.Size(1008, 616);
            this.panelDashmain.TabIndex = 0;
            this.panelDashmain.Text = "Welcome";
            this.panelDashmain.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelDashmain.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // labelCustomerNum
            // 
            this.labelCustomerNum.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomerNum.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCustomerNum.Location = new System.Drawing.Point(266, 52);
            this.labelCustomerNum.Name = "labelCustomerNum";
            this.labelCustomerNum.Size = new System.Drawing.Size(286, 39);
            this.labelCustomerNum.TabIndex = 12;
            this.labelCustomerNum.Text = "customer accNumber";
            this.labelCustomerNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCustomerNum.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton4
            // 
            this.uiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton4.Location = new System.Drawing.Point(406, 220);
            this.uiButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton4.Name = "uiButton4";
            this.uiButton4.Size = new System.Drawing.Size(182, 69);
            this.uiButton4.TabIndex = 9;
            this.uiButton4.Text = "HISTORY";
            this.uiButton4.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton4.Click += new System.EventHandler(this.uiButton4_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBalance.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBalance.Location = new System.Drawing.Point(406, 116);
            this.btnBalance.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(182, 62);
            this.btnBalance.TabIndex = 8;
            this.btnBalance.Text = "BALANCE";
            this.btnBalance.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBalance.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // WI
            // 
            this.WI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WI.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WI.Location = new System.Drawing.Point(73, 220);
            this.WI.MinimumSize = new System.Drawing.Size(1, 1);
            this.WI.Name = "WI";
            this.WI.Size = new System.Drawing.Size(181, 69);
            this.WI.TabIndex = 7;
            this.WI.Text = "WITHDRAW";
            this.WI.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WI.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.WI.Click += new System.EventHandler(this.WI_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeposit.Location = new System.Drawing.Point(73, 116);
            this.btnDeposit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(181, 62);
            this.btnDeposit.TabIndex = 6;
            this.btnDeposit.Text = "DEPOSIT";
            this.btnDeposit.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeposit.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // labelWelcomeCustomer
            // 
            this.labelWelcomeCustomer.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcomeCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWelcomeCustomer.Location = new System.Drawing.Point(16, 49);
            this.labelWelcomeCustomer.Name = "labelWelcomeCustomer";
            this.labelWelcomeCustomer.Size = new System.Drawing.Size(400, 44);
            this.labelWelcomeCustomer.TabIndex = 0;
            this.labelWelcomeCustomer.Text = "WelcomeBack! Dear Csutomer!";
            this.labelWelcomeCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelWelcomeCustomer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // symbtnLoginout
            // 
            this.symbtnLoginout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.symbtnLoginout.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.symbtnLoginout.Location = new System.Drawing.Point(237, 323);
            this.symbtnLoginout.MinimumSize = new System.Drawing.Size(1, 1);
            this.symbtnLoginout.Name = "symbtnLoginout";
            this.symbtnLoginout.Size = new System.Drawing.Size(187, 59);
            this.symbtnLoginout.Symbol = 61540;
            this.symbtnLoginout.TabIndex = 13;
            this.symbtnLoginout.Text = "LOGIN OUT";
            this.symbtnLoginout.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.symbtnLoginout.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.symbtnLoginout.Click += new System.EventHandler(this.symbtnLoginout_Click);
            // 
            // DashMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.ControlBox = false;
            this.Controls.Add(this.panelDashmain);
            this.Name = "DashMain";
            this.Text = "DashMain";
            this.Load += new System.EventHandler(this.DashMain_Load);
            this.panelDashmain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITitlePanel panelDashmain;
        private Sunny.UI.UILabel labelWelcomeCustomer;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIButton btnBalance;
        private Sunny.UI.UIButton WI;
        private Sunny.UI.UIButton btnDeposit;
        private Sunny.UI.UILabel labelCustomerNum;
        private Sunny.UI.UISymbolButton symbtnLoginout;
    }
}