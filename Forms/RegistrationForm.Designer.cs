namespace MilitaryOffenseAutomation.Forms
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtPersonalNumber;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblPersonalNumber;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtPersonalNumber = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblPersonalNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(150, 20);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(150, 50);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(150, 80);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(200, 20);
            this.txtConfirmPassword.TabIndex = 2;
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(150, 110);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(200, 20);
            this.txtRank.TabIndex = 3;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(150, 140);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(200, 20);
            this.txtPosition.TabIndex = 4;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(150, 170);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(200, 20);
            this.txtUnit.TabIndex = 5;
            // 
            // txtPersonalNumber
            // 
            this.txtPersonalNumber.Location = new System.Drawing.Point(150, 200);
            this.txtPersonalNumber.Name = "txtPersonalNumber";
            this.txtPersonalNumber.Size = new System.Drawing.Size(200, 20);
            this.txtPersonalNumber.TabIndex = 6;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(150, 240);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(95, 23);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Зареєструвати";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(255, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 23);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(37, 13);
            this.lblUsername.Text = "Логін:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 53);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(48, 13);
            this.lblPassword.Text = "Пароль:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(20, 83);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(100, 13);
            this.lblConfirmPassword.Text = "Повторіть пароль:";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(20, 113);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(47, 13);
            this.lblRank.Text = "Звання:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(20, 143);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(45, 13);
            this.lblPosition.Text = "Посада:";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(20, 173);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(58, 13);
            this.lblUnit.Text = "Підрозділ:";
            // 
            // lblPersonalNumber
            // 
            this.lblPersonalNumber.AutoSize = true;
            this.lblPersonalNumber.Location = new System.Drawing.Point(20, 203);
            this.lblPersonalNumber.Name = "lblPersonalNumber";
            this.lblPersonalNumber.Size = new System.Drawing.Size(93, 13);
            this.lblPersonalNumber.Text = "Особистий номер:";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.lblPersonalNumber);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPersonalNumber);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtRank);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Реєстрація військовослужбовця";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
