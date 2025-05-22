using System;
using System.Windows.Forms;
using MilitaryOffenseAutomation.Models;
using MilitaryOffenseAutomation.Database;

namespace MilitaryOffenseAutomation.Forms
{
    public partial class ServicemanForm : Form
    {
        private readonly Serviceman _currentUser;

        public ServicemanForm(Serviceman serviceman)
        {
            InitializeComponent();
            _currentUser = serviceman;
            this.Text = $"Особистий кабінет - {_currentUser.Rank} {_currentUser.Username}";
            LoadUserInfo();
            LoadViolations();
        }

        private void LoadUserInfo()
        {
            lblRank.Text = $"Звання: {_currentUser.Rank}";
            lblPosition.Text = $"Посада: {_currentUser.Position}";
            lblUnit.Text = $"Підрозділ: {_currentUser.Unit}";
            lblPersonalNumber.Text = $"Особистий номер: {_currentUser.PersonalNumber}";
        }

        private void LoadViolations()
        {
            dgvViolations.DataSource = DatabaseHelper.GetViolations(_currentUser.Id);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }
    }
}
