namespace ATMSystem
{
    partial class Deposit
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
            this.pannelDeposit = new Sunny.UI.UITitlePanel();
            this.labelTitle = new Sunny.UI.UILabel();
            this.btnBack = new Sunny.UI.UIButton();
            this.btnDeposit = new Sunny.UI.UIButton();
            this.txtDeposit = new Sunny.UI.UITextBox();
            this.pannelDeposit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pannelDeposit
            // 
            this.pannelDeposit.Controls.Add(this.labelTitle);
            this.pannelDeposit.Controls.Add(this.btnBack);
            this.pannelDeposit.Controls.Add(this.btnDeposit);
            this.pannelDeposit.Controls.Add(this.txtDeposit);
            this.pannelDeposit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pannelDeposit.Location = new System.Drawing.Point(16, 17);
            this.pannelDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pannelDeposit.MinimumSize = new System.Drawing.Size(1, 1);
            this.pannelDeposit.Name = "pannelDeposit";
            this.pannelDeposit.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.pannelDeposit.ShowText = false;
            this.pannelDeposit.Size = new System.Drawing.Size(1040, 613);
            this.pannelDeposit.TabIndex = 0;
            this.pannelDeposit.Text = "Deposit";
            this.pannelDeposit.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pannelDeposit.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(144, 62);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(418, 64);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Please enter the deposit amount below";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBack.Location = new System.Drawing.Point(292, 342);
            this.btnBack.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 40);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "BACK";
            this.btnBack.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBack.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeposit.Location = new System.Drawing.Point(266, 260);
            this.btnDeposit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(169, 59);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "D E P O S I T";
            this.btnDeposit.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeposit.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // txtDeposit
            // 
            this.txtDeposit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtDeposit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeposit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDeposit.Location = new System.Drawing.Point(149, 131);
            this.txtDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeposit.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.ShowText = false;
            this.txtDeposit.Size = new System.Drawing.Size(393, 58);
            this.txtDeposit.TabIndex = 0;
            this.txtDeposit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDeposit.Watermark = "Enter deposit amount";
            this.txtDeposit.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Deposit
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.ControlBox = false;
            this.Controls.Add(this.pannelDeposit);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.pannelDeposit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITitlePanel pannelDeposit;
        private Sunny.UI.UITextBox txtDeposit;
        private Sunny.UI.UIButton btnBack;
        private Sunny.UI.UIButton btnDeposit;
        private Sunny.UI.UILabel labelTitle;
    }
}