using System;
using System.Windows.Forms;
using MilitaryOffenseAutomation.Forms;

namespace MilitaryOffenseAutomation
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                // Initialize database on startup
                Database.DatabaseHelper.InitializeDatabase();
                
                // Start with login form
                Application.Run(new LoginForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Критична помилка: {ex.Message}", 
                              "Помилка", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Error);
            }
        }
    }
}
