using System;
using System.Windows.Forms;
using MilitaryOffenseAutomation.Models;
using MilitaryOffenseAutomation.Database;

namespace MilitaryOffenseAutomation.Forms
{
    public partial class AdminForm : Form
    {
        private readonly User _currentUser;

        public AdminForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
            this.Text = $"Панель адміністратора - {_currentUser.Username}";
            LoadViolations();
        }

        private void LoadViolations()
        {
            dgvViolations.DataSource = DatabaseHelper.GetViolations();
            
            // Configure columns display
            if (dgvViolations.Columns.Contains("Id"))
                dgvViolations.Columns["Id"].HeaderText = "ID";
            if (dgvViolations.Columns.Contains("ServicemanId"))
                dgvViolations.Columns["ServicemanId"].HeaderText = "ID військовослужбовця";
            if (dgvViolations.Columns.Contains("Description"))
                dgvViolations.Columns["Description"].HeaderText = "Опис";
            if (dgvViolations.Columns.Contains("Date"))
                dgvViolations.Columns["Date"].HeaderText = "Дата";
            if (dgvViolations.Columns.Contains("Type"))
                dgvViolations.Columns["Type"].HeaderText = "Тип";
            if (dgvViolations.Columns.Contains("Punishment"))
                dgvViolations.Columns["Punishment"].HeaderText = "Покарання";
        }

        private void btnAddViolation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtServicemanId.Text) || 
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtType.Text))
            {
                MessageBox.Show("Будь ласка, заповніть обов'язкові поля (ID військовослужбовця, Опис, Тип)!", 
                              "Помилка", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtServicemanId.Text, out int servicemanId))
            {
                MessageBox.Show("ID військовослужбовця має бути числом!", 
                              "Помилка", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Warning);
                return;
            }

            var violation = new Violation
            {
                ServicemanId = servicemanId,
                Description = txtDescription.Text,
                Date = dtpDate.Value,
                Type = txtType.Text,
                Punishment = txtPunishment.Text
            };

            if (DatabaseHelper.AddViolation(violation))
            {
                MessageBox.Show("Правопорушення успішно додано!", 
                              "Успіх", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Information);
                LoadViolations();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Помилка при додаванні правопорушення!", 
                              "Помилка", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtServicemanId.Clear();
            txtDescription.Clear();
            txtType.Clear();
            txtPunishment.Clear();
            dtpDate.Value = DateTime.Now;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }
    }
}
