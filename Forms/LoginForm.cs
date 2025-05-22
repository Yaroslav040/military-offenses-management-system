using System;
using System.Windows.Forms;
using MilitaryOffenseAutomation.Models;
using MilitaryOffenseAutomation.Database;

namespace MilitaryOffenseAutomation.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            DatabaseHelper.InitializeDatabase();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Будь ласка, введіть логін та пароль!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = DatabaseHelper.AuthenticateUser(txtUsername.Text, txtPassword.Text);
            if (user != null)
            {
                this.Hide();
                if (user.Role == "Admin")
                {
                    new AdminForm(user).Show();
                }
                else
                {
                    new ServicemanForm((Serviceman)user).Show();
                }
            }
            else
            {
                MessageBox.Show("Невірний логін або пароль!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new RegistrationForm().ShowDialog();
        }
    }
}
