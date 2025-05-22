namespace MilitaryOffenseAutomation.Forms
{
    partial class ServicemanForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblPersonalNumber;
        private System.Windows.Forms.DataGridView dgvViolations;
        private System.Windows.Forms.Button btnLogout;

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
            this.lblRank = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblPersonalNumber = new System.Windows.Forms.Label();
            this.dgvViolations = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViolations)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(12, 15);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(50, 13);
            this.lblRank.TabIndex = 0;
            this.lblRank.Text = "Звання:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(12, 35);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(50, 13);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Посада:";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(12, 55);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(58, 13);
            this.lblUnit.TabIndex = 2;
            this.lblUnit.Text = "Підрозділ:";
            // 
            // lblPersonalNumber
            // 
            this.lblPersonalNumber.AutoSize = true;
            this.lblPersonalNumber.Location = new System.Drawing.Point(12, 75);
            this.lblPersonalNumber.Name = "lblPersonalNumber";
            this.lblPersonalNumber.Size = new System.Drawing.Size(93, 13);
            this.lblPersonalNumber.TabIndex = 3;
            this.lblPersonalNumber.Text = "Особистий номер:";
            // 
            // dgvViolations
            // 
            this.dgvViolations.AllowUserToAddRows = false;
            this.dgvViolations.AllowUserToDeleteRows = false;
            this.dgvViolations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViolations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViolations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViolations.Location = new System.Drawing.Point(12, 100);
            this.dgvViolations.Name = "dgvViolations";
            this.dgvViolations.ReadOnly = true;
            this.dgvViolations.Size = new System.Drawing.Size(560, 249);
            this.dgvViolations.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(497, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Вихід";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ServicemanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dgvViolations);
            this.Controls.Add(this.lblPersonalNumber);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblRank);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "ServicemanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Особистий кабінет військовослужбовця";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViolations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
