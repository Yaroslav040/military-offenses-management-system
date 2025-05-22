using System;
using System.Windows.Forms;
using MilitaryOffenseAutomation.Models;
using MilitaryOffenseAutomation.Database;

namespace MilitaryOffenseAutomation.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || 
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtRank.Text) ||
                string.IsNullOrWhiteSpace(txtPosition.Text) ||
                string.IsNullOrWhiteSpace(txtUnit.Text) ||
                string.IsNullOrWhiteSpace(txtPersonalNumber.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля!", 
                              "Помилка", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Паролі не співпадають!", 
                              "Помилка", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Warning);
                return;
            }

            var serviceman = new Serviceman
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Role = "Serviceman",
                Rank = txtRank.Text,
                Position = txtPosition.Text,
                Unit = txtUnit.Text,
                PersonalNumber = txtPersonalNumber.Text
            };

            if (DatabaseHelper.RegisterServiceman(serviceman))
            {
                MessageBox.Show("Реєстрація успішна!", 
                              "Успіх", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Помилка при реєстрації. Можливо, такий користувач вже існує.", 
                              "Помилка", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
