namespace MilitaryOffenseAutomation.Forms
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvViolations;
        private System.Windows.Forms.TextBox txtServicemanId;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtPunishment;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAddViolation;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblServicemanId;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPunishment;

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
            this.dgvViolations = new System.Windows.Forms.DataGridView();
            this.txtServicemanId = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtPunishment = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddViolation = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblServicemanId = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPunishment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViolations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViolations
            // 
            this.dgvViolations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViolations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViolations.Location = new System.Drawing.Point(12, 200);
            this.dgvViolations.Name = "dgvViolations";
            this.dgvViolations.Size = new System.Drawing.Size(760, 249);
            this.dgvViolations.TabIndex = 0;
            // 
            // txtServicemanId
            // 
            this.txtServicemanId.Location = new System.Drawing.Point(120, 12);
            this.txtServicemanId.Name = "txtServicemanId";
            this.txtServicemanId.Size = new System.Drawing.Size(100, 20);
            this.txtServicemanId.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(120, 38);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(300, 60);
            this.txtDescription.TabIndex = 2;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(120, 130);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(200, 20);
            this.txtType.TabIndex = 4;
            // 
            // txtPunishment
            // 
            this.txtPunishment.Location = new System.Drawing.Point(120, 156);
            this.txtPunishment.Name = "txtPunishment";
            this.txtPunishment.Size = new System.Drawing.Size(200, 20);
            this.txtPunishment.TabIndex = 5;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(120, 104);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // btnAddViolation
            // 
            this.btnAddViolation.Location = new System.Drawing.Point(450, 156);
            this.btnAddViolation.Name = "btnAddViolation";
            this.btnAddViolation.Size = new System.Drawing.Size(150, 23);
            this.btnAddViolation.TabIndex = 6;
            this.btnAddViolation.Text = "Додати правопорушення";
            this.btnAddViolation.Click += new System.EventHandler(this.btnAddViolation_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(697, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Вихід";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblServicemanId
            // 
            this.lblServicemanId.AutoSize = true;
            this.lblServicemanId.Location = new System.Drawing.Point(12, 15);
            this.lblServicemanId.Name = "lblServicemanId";
            this.lblServicemanId.Size = new System.Drawing.Size(102, 13);
            this.lblServicemanId.Text = "ID військовослужбовця:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 41);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(36, 13);
            this.lblDescription.Text = "Опис:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 110);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.Text = "Дата:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 133);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(29, 13);
            this.lblType.Text = "Тип:";
            // 
            // lblPunishment
            // 
            this.lblPunishment.AutoSize = true;
            this.lblPunishment.Location = new System.Drawing.Point(12, 159);
            this.lblPunishment.Name = "lblPunishment";
            this.lblPunishment.Size = new System.Drawing.Size(64, 13);
            this.lblPunishment.Text = "Покарання:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblPunishment);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblServicemanId);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAddViolation);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtPunishment);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtServicemanId);
            this.Controls.Add(this.dgvViolations);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель адміністратора";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViolations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
