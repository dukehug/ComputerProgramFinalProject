namespace ATMSystem
{
    partial class Regsiter
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
            Sunny.UI.UITitlePanel panelReg;
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.sybolbtnSubmit = new Sunny.UI.UISymbolButton();
            this.dateTimePick = new System.Windows.Forms.DateTimePicker();
            this.textBoxName = new Sunny.UI.UITextBox();
            this.textBoxAddress = new Sunny.UI.UITextBox();
            this.textBoxEmail = new Sunny.UI.UITextBox();
            this.uiMarkLabel3 = new Sunny.UI.UIMarkLabel();
            this.textBoxPhoneNumber = new Sunny.UI.UITextBox();
            this.uiMarkLabel4 = new Sunny.UI.UIMarkLabel();
            this.labelAddress = new Sunny.UI.UIMarkLabel();
            this.labelPhone = new Sunny.UI.UIMarkLabel();
            this.textBoxPassword = new Sunny.UI.UITextBox();
            this.labelPassword = new Sunny.UI.UIMarkLabel();
            this.labelTitleforReg = new Sunny.UI.UILabel();
            this.labelAccount = new Sunny.UI.UILabel();
            this.labelPinID = new Sunny.UI.UIMarkLabel();
            panelReg = new Sunny.UI.UITitlePanel();
            panelReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelReg
            // 
            panelReg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panelReg.Controls.Add(this.uiSymbolButton1);
            panelReg.Controls.Add(this.sybolbtnSubmit);
            panelReg.Controls.Add(this.dateTimePick);
            panelReg.Controls.Add(this.textBoxName);
            panelReg.Controls.Add(this.textBoxAddress);
            panelReg.Controls.Add(this.textBoxEmail);
            panelReg.Controls.Add(this.uiMarkLabel3);
            panelReg.Controls.Add(this.textBoxPhoneNumber);
            panelReg.Controls.Add(this.uiMarkLabel4);
            panelReg.Controls.Add(this.labelAddress);
            panelReg.Controls.Add(this.labelPhone);
            panelReg.Controls.Add(this.textBoxPassword);
            panelReg.Controls.Add(this.labelPassword);
            panelReg.Controls.Add(this.labelTitleforReg);
            panelReg.Controls.Add(this.labelAccount);
            panelReg.Controls.Add(this.labelPinID);
            panelReg.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            panelReg.Location = new System.Drawing.Point(12, 11);
            panelReg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panelReg.MinimumSize = new System.Drawing.Size(1, 1);
            panelReg.Name = "panelReg";
            panelReg.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            panelReg.ShowText = false;
            panelReg.Size = new System.Drawing.Size(597, 785);
            panelReg.TabIndex = 0;
            panelReg.Text = "Register form";
            panelReg.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            panelReg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Location = new System.Drawing.Point(364, 683);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(204, 59);
            this.uiSymbolButton1.Symbol = 61584;
            this.uiSymbolButton1.TabIndex = 22;
            this.uiSymbolButton1.Text = "BACK";
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // sybolbtnSubmit
            // 
            this.sybolbtnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sybolbtnSubmit.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sybolbtnSubmit.Location = new System.Drawing.Point(33, 683);
            this.sybolbtnSubmit.MinimumSize = new System.Drawing.Size(1, 1);
            this.sybolbtnSubmit.Name = "sybolbtnSubmit";
            this.sybolbtnSubmit.Size = new System.Drawing.Size(204, 59);
            this.sybolbtnSubmit.TabIndex = 21;
            this.sybolbtnSubmit.Text = "SUBMIT";
            this.sybolbtnSubmit.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sybolbtnSubmit.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.sybolbtnSubmit.Click += new System.EventHandler(this.sybolbtnSubmit_Click);
            // 
            // dateTimePick
            // 
            this.dateTimePick.CustomFormat = "MM/dd/yy H:mm:ss";
            this.dateTimePick.Enabled = false;
            this.dateTimePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePick.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePick.Location = new System.Drawing.Point(31, 48);
            this.dateTimePick.Name = "dateTimePick";
            this.dateTimePick.Size = new System.Drawing.Size(203, 39);
            this.dateTimePick.TabIndex = 19;
            // 
            // textBoxName
            // 
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxName.Location = new System.Drawing.Point(236, 585);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ShowText = false;
            this.textBoxName.Size = new System.Drawing.Size(332, 44);
            this.textBoxName.TabIndex = 16;
            this.textBoxName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxName.Watermark = "Enter your name";
            this.textBoxName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxAddress.Location = new System.Drawing.Point(236, 418);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAddress.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ShowText = false;
            this.textBoxAddress.Size = new System.Drawing.Size(332, 44);
            this.textBoxAddress.TabIndex = 12;
            this.textBoxAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxAddress.Watermark = "Enter your address";
            this.textBoxAddress.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxEmail.Location = new System.Drawing.Point(236, 501);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ShowText = false;
            this.textBoxEmail.Size = new System.Drawing.Size(332, 44);
            this.textBoxEmail.TabIndex = 14;
            this.textBoxEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxEmail.Watermark = "Enter your email address";
            this.textBoxEmail.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiMarkLabel3
            // 
            this.uiMarkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiMarkLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel3.Location = new System.Drawing.Point(28, 585);
            this.uiMarkLabel3.Name = "uiMarkLabel3";
            this.uiMarkLabel3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel3.Size = new System.Drawing.Size(153, 44);
            this.uiMarkLabel3.TabIndex = 15;
            this.uiMarkLabel3.Text = "Name:";
            this.uiMarkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(236, 338);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPhoneNumber.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.ShowText = false;
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(332, 44);
            this.textBoxPhoneNumber.TabIndex = 10;
            this.textBoxPhoneNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxPhoneNumber.Watermark = "Enter your phone number";
            this.textBoxPhoneNumber.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiMarkLabel4
            // 
            this.uiMarkLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiMarkLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel4.Location = new System.Drawing.Point(28, 501);
            this.uiMarkLabel4.Name = "uiMarkLabel4";
            this.uiMarkLabel4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel4.Size = new System.Drawing.Size(153, 44);
            this.uiMarkLabel4.TabIndex = 13;
            this.uiMarkLabel4.Text = "Email:";
            this.uiMarkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // labelAddress
            // 
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAddress.Location = new System.Drawing.Point(28, 418);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.labelAddress.Size = new System.Drawing.Size(153, 44);
            this.labelAddress.TabIndex = 11;
            this.labelAddress.Text = "Address:";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAddress.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // labelPhone
            // 
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPhone.Location = new System.Drawing.Point(27, 338);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.labelPhone.Size = new System.Drawing.Size(153, 44);
            this.labelPhone.TabIndex = 9;
            this.labelPhone.Text = "Phone:";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPhone.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPassword.Location = new System.Drawing.Point(236, 254);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.ShowText = false;
            this.textBoxPassword.Size = new System.Drawing.Size(332, 44);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxPassword.Watermark = "Set your own password";
            this.textBoxPassword.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // labelPassword
            // 
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPassword.Location = new System.Drawing.Point(28, 254);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.labelPassword.Size = new System.Drawing.Size(153, 44);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPassword.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // labelTitleforReg
            // 
            this.labelTitleforReg.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleforReg.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitleforReg.Location = new System.Drawing.Point(22, 81);
            this.labelTitleforReg.Name = "labelTitleforReg";
            this.labelTitleforReg.Size = new System.Drawing.Size(546, 75);
            this.labelTitleforReg.TabIndex = 2;
            this.labelTitleforReg.Text = "Please fill out the form";
            this.labelTitleforReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitleforReg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // labelAccount
            // 
            this.labelAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelAccount.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAccount.Location = new System.Drawing.Point(236, 174);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(332, 45);
            this.labelAccount.TabIndex = 1;
            this.labelAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAccount.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // labelPinID
            // 
            this.labelPinID.BackColor = System.Drawing.Color.Transparent;
            this.labelPinID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPinID.Location = new System.Drawing.Point(28, 174);
            this.labelPinID.Name = "labelPinID";
            this.labelPinID.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.labelPinID.Size = new System.Drawing.Size(153, 44);
            this.labelPinID.TabIndex = 0;
            this.labelPinID.Text = "Account";
            this.labelPinID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPinID.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Regsiter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(624, 810);
            this.ControlBox = false;
            this.Controls.Add(panelReg);
            this.Name = "Regsiter";
            this.Text = "Regsiter";
            panelReg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIMarkLabel labelPinID;
        private Sunny.UI.UITextBox textBoxName;
        private Sunny.UI.UITextBox textBoxAddress;
        private Sunny.UI.UITextBox textBoxEmail;
        private Sunny.UI.UIMarkLabel uiMarkLabel3;
        private Sunny.UI.UITextBox textBoxPhoneNumber;
        private Sunny.UI.UIMarkLabel uiMarkLabel4;
        private Sunny.UI.UIMarkLabel labelAddress;
        private Sunny.UI.UIMarkLabel labelPhone;
        private Sunny.UI.UITextBox textBoxPassword;
        private Sunny.UI.UIMarkLabel labelPassword;
        private Sunny.UI.UILabel labelTitleforReg;
        private Sunny.UI.UILabel labelAccount;
        private System.Windows.Forms.DateTimePicker dateTimePick;
        private Sunny.UI.UISymbolButton sybolbtnSubmit;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
    }
}