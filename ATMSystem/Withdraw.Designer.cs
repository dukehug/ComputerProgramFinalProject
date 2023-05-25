namespace ATMSystem
{
    partial class Withdraw
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
            this.panelWithdraw = new Sunny.UI.UITitlePanel();
            this.sybolbtnBack = new Sunny.UI.UISymbolButton();
            this.labelAvailableBalance = new Sunny.UI.UIMarkLabel();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.btnWithdraw = new Sunny.UI.UIButton();
            this.labelEnterAmount = new Sunny.UI.UILabel();
            this.txtWithdrawAmount = new Sunny.UI.UITextBox();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.btn10000 = new Sunny.UI.UIButton();
            this.btn5000 = new Sunny.UI.UIButton();
            this.btn3000 = new Sunny.UI.UIButton();
            this.btn6000 = new Sunny.UI.UIButton();
            this.btn4000 = new Sunny.UI.UIButton();
            this.btn2000 = new Sunny.UI.UIButton();
            this.btn1000 = new Sunny.UI.UIButton();
            this.btn500 = new Sunny.UI.UIButton();
            this.panelWithdraw.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWithdraw
            // 
            this.panelWithdraw.AutoSize = true;
            this.panelWithdraw.Controls.Add(this.sybolbtnBack);
            this.panelWithdraw.Controls.Add(this.labelAvailableBalance);
            this.panelWithdraw.Controls.Add(this.uiGroupBox2);
            this.panelWithdraw.Controls.Add(this.uiGroupBox1);
            this.panelWithdraw.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelWithdraw.Location = new System.Drawing.Point(8, 6);
            this.panelWithdraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelWithdraw.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelWithdraw.Name = "panelWithdraw";
            this.panelWithdraw.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.panelWithdraw.ShowText = false;
            this.panelWithdraw.Size = new System.Drawing.Size(1100, 700);
            this.panelWithdraw.TabIndex = 0;
            this.panelWithdraw.Text = "Withdraw";
            this.panelWithdraw.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelWithdraw.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // sybolbtnBack
            // 
            this.sybolbtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sybolbtnBack.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sybolbtnBack.Location = new System.Drawing.Point(845, 608);
            this.sybolbtnBack.MinimumSize = new System.Drawing.Size(1, 1);
            this.sybolbtnBack.Name = "sybolbtnBack";
            this.sybolbtnBack.Size = new System.Drawing.Size(196, 61);
            this.sybolbtnBack.Symbol = 61584;
            this.sybolbtnBack.TabIndex = 24;
            this.sybolbtnBack.Text = "BACK";
            this.sybolbtnBack.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sybolbtnBack.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.sybolbtnBack.Click += new System.EventHandler(this.sybolbtnBack_Click);
            // 
            // labelAvailableBalance
            // 
            this.labelAvailableBalance.BackColor = System.Drawing.Color.Transparent;
            this.labelAvailableBalance.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAvailableBalance.Location = new System.Drawing.Point(443, 70);
            this.labelAvailableBalance.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.labelAvailableBalance.Name = "labelAvailableBalance";
            this.labelAvailableBalance.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.labelAvailableBalance.Size = new System.Drawing.Size(598, 65);
            this.labelAvailableBalance.TabIndex = 4;
            this.labelAvailableBalance.Text = "AvailableBalance";
            this.labelAvailableBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAvailableBalance.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.labelAvailableBalance.Click += new System.EventHandler(this.labelAvailableBalance_Click);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.AutoSize = true;
            this.uiGroupBox2.Controls.Add(this.btnWithdraw);
            this.uiGroupBox2.Controls.Add(this.labelEnterAmount);
            this.uiGroupBox2.Controls.Add(this.txtWithdrawAmount);
            this.uiGroupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox2.Location = new System.Drawing.Point(452, 155);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(589, 445);
            this.uiGroupBox2.TabIndex = 1;
            this.uiGroupBox2.Text = "Other Amount";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWithdraw.Location = new System.Drawing.Point(126, 219);
            this.btnWithdraw.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(258, 87);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "WITHDRAW";
            this.btnWithdraw.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWithdraw.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // labelEnterAmount
            // 
            this.labelEnterAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelEnterAmount.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEnterAmount.Location = new System.Drawing.Point(85, 65);
            this.labelEnterAmount.Name = "labelEnterAmount";
            this.labelEnterAmount.Size = new System.Drawing.Size(367, 56);
            this.labelEnterAmount.TabIndex = 1;
            this.labelEnterAmount.Text = "Enter how much u need withdraw";
            this.labelEnterAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEnterAmount.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtWithdrawAmount
            // 
            this.txtWithdrawAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWithdrawAmount.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWithdrawAmount.Location = new System.Drawing.Point(77, 126);
            this.txtWithdrawAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWithdrawAmount.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtWithdrawAmount.Name = "txtWithdrawAmount";
            this.txtWithdrawAmount.ShowText = false;
            this.txtWithdrawAmount.Size = new System.Drawing.Size(375, 60);
            this.txtWithdrawAmount.TabIndex = 0;
            this.txtWithdrawAmount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtWithdrawAmount.Watermark = "";
            this.txtWithdrawAmount.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.btn10000);
            this.uiGroupBox1.Controls.Add(this.btn5000);
            this.uiGroupBox1.Controls.Add(this.btn3000);
            this.uiGroupBox1.Controls.Add(this.btn6000);
            this.uiGroupBox1.Controls.Add(this.btn4000);
            this.uiGroupBox1.Controls.Add(this.btn2000);
            this.uiGroupBox1.Controls.Add(this.btn1000);
            this.uiGroupBox1.Controls.Add(this.btn500);
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(17, 54);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(403, 546);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = "Quick Withdraw";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btn10000
            // 
            this.btn10000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn10000.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn10000.Location = new System.Drawing.Point(204, 451);
            this.btn10000.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn10000.Name = "btn10000";
            this.btn10000.Size = new System.Drawing.Size(149, 50);
            this.btn10000.TabIndex = 10;
            this.btn10000.Text = "10,000";
            this.btn10000.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn10000.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn10000.Click += new System.EventHandler(this.btn10000_Click);
            // 
            // btn5000
            // 
            this.btn5000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5000.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn5000.Location = new System.Drawing.Point(204, 320);
            this.btn5000.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn5000.Name = "btn5000";
            this.btn5000.Size = new System.Drawing.Size(149, 50);
            this.btn5000.TabIndex = 9;
            this.btn5000.Text = "5,000";
            this.btn5000.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn5000.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn5000.Click += new System.EventHandler(this.btn5000_Click);
            // 
            // btn3000
            // 
            this.btn3000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3000.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn3000.Location = new System.Drawing.Point(204, 194);
            this.btn3000.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn3000.Name = "btn3000";
            this.btn3000.Size = new System.Drawing.Size(149, 50);
            this.btn3000.TabIndex = 8;
            this.btn3000.Text = "3,000";
            this.btn3000.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn3000.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn3000.Click += new System.EventHandler(this.btn3000_Click);
            // 
            // btn6000
            // 
            this.btn6000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6000.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn6000.Location = new System.Drawing.Point(18, 451);
            this.btn6000.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn6000.Name = "btn6000";
            this.btn6000.Size = new System.Drawing.Size(149, 50);
            this.btn6000.TabIndex = 7;
            this.btn6000.Text = "6,000";
            this.btn6000.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn6000.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn6000.Click += new System.EventHandler(this.btn6000_Click);
            // 
            // btn4000
            // 
            this.btn4000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4000.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4000.Location = new System.Drawing.Point(18, 320);
            this.btn4000.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn4000.Name = "btn4000";
            this.btn4000.Size = new System.Drawing.Size(149, 50);
            this.btn4000.TabIndex = 6;
            this.btn4000.Text = "4,000";
            this.btn4000.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4000.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn4000.Click += new System.EventHandler(this.btn4000_Click);
            // 
            // btn2000
            // 
            this.btn2000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2000.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2000.Location = new System.Drawing.Point(18, 194);
            this.btn2000.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn2000.Name = "btn2000";
            this.btn2000.Size = new System.Drawing.Size(149, 50);
            this.btn2000.TabIndex = 5;
            this.btn2000.Text = "2,000";
            this.btn2000.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2000.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn2000.Click += new System.EventHandler(this.btn2000_Click);
            // 
            // btn1000
            // 
            this.btn1000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1000.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1000.Location = new System.Drawing.Point(204, 60);
            this.btn1000.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(149, 50);
            this.btn1000.TabIndex = 4;
            this.btn1000.Text = "1,000";
            this.btn1000.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1000.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn1000.Click += new System.EventHandler(this.btn1000_Click);
            // 
            // btn500
            // 
            this.btn500.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn500.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn500.Location = new System.Drawing.Point(18, 60);
            this.btn500.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(149, 50);
            this.btn500.TabIndex = 3;
            this.btn500.Text = "500";
            this.btn500.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn500.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn500.Click += new System.EventHandler(this.btn500_Click);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1119, 712);
            this.ControlBox = false;
            this.Controls.Add(this.panelWithdraw);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.panelWithdraw.ResumeLayout(false);
            this.panelWithdraw.PerformLayout();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITitlePanel panelWithdraw;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIButton btnWithdraw;
        private Sunny.UI.UILabel labelEnterAmount;
        private Sunny.UI.UITextBox txtWithdrawAmount;
        private Sunny.UI.UIButton btn10000;
        private Sunny.UI.UIButton btn5000;
        private Sunny.UI.UIButton btn3000;
        private Sunny.UI.UIButton btn6000;
        private Sunny.UI.UIButton btn4000;
        private Sunny.UI.UIButton btn2000;
        private Sunny.UI.UIButton btn1000;
        private Sunny.UI.UIButton btn500;
        private Sunny.UI.UIMarkLabel labelAvailableBalance;
        private Sunny.UI.UISymbolButton sybolbtnBack;
    }
}