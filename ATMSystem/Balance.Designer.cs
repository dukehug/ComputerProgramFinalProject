namespace ATMSystem
{
    partial class Balance
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
            this.panelBalance = new Sunny.UI.UITitlePanel();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.labelBalanceAmount = new Sunny.UI.UIMarkLabel();
            this.sybollabelAccountNumber = new Sunny.UI.UIMarkLabel();
            this.labelBalanceAccount = new System.Windows.Forms.Label();
            this.labelBanlance = new System.Windows.Forms.Label();
            this.panelBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBalance
            // 
            this.panelBalance.Controls.Add(this.uiSymbolButton1);
            this.panelBalance.Controls.Add(this.labelBalanceAmount);
            this.panelBalance.Controls.Add(this.sybollabelAccountNumber);
            this.panelBalance.Controls.Add(this.labelBalanceAccount);
            this.panelBalance.Controls.Add(this.labelBanlance);
            this.panelBalance.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelBalance.Location = new System.Drawing.Point(17, 16);
            this.panelBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBalance.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelBalance.Name = "panelBalance";
            this.panelBalance.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.panelBalance.ShowText = false;
            this.panelBalance.Size = new System.Drawing.Size(1046, 614);
            this.panelBalance.TabIndex = 0;
            this.panelBalance.Text = "Balance";
            this.panelBalance.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelBalance.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Location = new System.Drawing.Point(290, 301);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(176, 52);
            this.uiSymbolButton1.Symbol = 61584;
            this.uiSymbolButton1.TabIndex = 23;
            this.uiSymbolButton1.Text = "BACK";
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // labelBalanceAmount
            // 
            this.labelBalanceAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelBalanceAmount.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBalanceAmount.Location = new System.Drawing.Point(268, 180);
            this.labelBalanceAmount.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.labelBalanceAmount.Name = "labelBalanceAmount";
            this.labelBalanceAmount.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.labelBalanceAmount.Size = new System.Drawing.Size(268, 62);
            this.labelBalanceAmount.TabIndex = 6;
            this.labelBalanceAmount.Text = "labelBalanceAmount";
            this.labelBalanceAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBalanceAmount.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // sybollabelAccountNumber
            // 
            this.sybollabelAccountNumber.BackColor = System.Drawing.Color.Transparent;
            this.sybollabelAccountNumber.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sybollabelAccountNumber.Location = new System.Drawing.Point(271, 87);
            this.sybollabelAccountNumber.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.sybollabelAccountNumber.Name = "sybollabelAccountNumber";
            this.sybollabelAccountNumber.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.sybollabelAccountNumber.Size = new System.Drawing.Size(265, 62);
            this.sybollabelAccountNumber.TabIndex = 5;
            this.sybollabelAccountNumber.Text = "labelBalanceAccountNum";
            this.sybollabelAccountNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sybollabelAccountNumber.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // labelBalanceAccount
            // 
            this.labelBalanceAccount.AutoSize = true;
            this.labelBalanceAccount.BackColor = System.Drawing.Color.Transparent;
            this.labelBalanceAccount.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBalanceAccount.Location = new System.Drawing.Point(30, 118);
            this.labelBalanceAccount.Name = "labelBalanceAccount";
            this.labelBalanceAccount.Size = new System.Drawing.Size(235, 31);
            this.labelBalanceAccount.TabIndex = 3;
            this.labelBalanceAccount.Text = "Account Number: ";
            // 
            // labelBanlance
            // 
            this.labelBanlance.AutoSize = true;
            this.labelBanlance.BackColor = System.Drawing.Color.Transparent;
            this.labelBanlance.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBanlance.Location = new System.Drawing.Point(79, 211);
            this.labelBanlance.Name = "labelBanlance";
            this.labelBanlance.Size = new System.Drawing.Size(186, 31);
            this.labelBanlance.TabIndex = 4;
            this.labelBanlance.Text = "Your Balance: ";
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.ControlBox = false;
            this.Controls.Add(this.panelBalance);
            this.Name = "Balance";
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.panelBalance.ResumeLayout(false);
            this.panelBalance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITitlePanel panelBalance;
        private System.Windows.Forms.Label labelBalanceTitle;
        private System.Windows.Forms.Label labelBanlance;
        private System.Windows.Forms.Label labelBalanceAccount;
        private Sunny.UI.UIMarkLabel labelBalanceAmount;
        private Sunny.UI.UIMarkLabel sybollabelAccountNumber;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
    }
}