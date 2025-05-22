using System;
using System.Data.SQLite;
using System.Collections.Generic;
using MilitaryOffenseAutomation.Models;

namespace MilitaryOffenseAutomation.Database
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Data Source=military.db;Version=3;";

        public static void InitializeDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                
                // Create Users table
                string createUsersTable = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT UNIQUE NOT NULL,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL,
                        Rank TEXT,
                        Position TEXT,
                        Unit TEXT,
                        PersonalNumber TEXT
                    )";

                // Create Violations table
                string createViolationsTable = @"
                    CREATE TABLE IF NOT EXISTS Violations (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        ServicemanId INTEGER NOT NULL,
                        Description TEXT NOT NULL,
                        Date TEXT NOT NULL,
                        Type TEXT NOT NULL,
                        Punishment TEXT,
                        FOREIGN KEY(ServicemanId) REFERENCES Users(Id)
                    )";

                using (SQLiteCommand cmd = new SQLiteCommand(createUsersTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                using (SQLiteCommand cmd = new SQLiteCommand(createViolationsTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static User AuthenticateUser(string username, string password)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["Role"].ToString() == "Admin")
                            {
                                return new User
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Username = reader["Username"].ToString(),
                                    Role = reader["Role"].ToString()
                                };
                            }
                            else
                            {
                                return new Serviceman
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Username = reader["Username"].ToString(),
                                    Role = reader["Role"].ToString(),
                                    Rank = reader["Rank"].ToString(),
                                    Position = reader["Position"].ToString(),
                                    Unit = reader["Unit"].ToString(),
                                    PersonalNumber = reader["PersonalNumber"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            return null;
        }

        public static bool RegisterServiceman(Serviceman serviceman)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Users (Username, Password, Role, Rank, Position, Unit, PersonalNumber) 
                               VALUES (@username, @password, @role, @rank, @position, @unit, @personalNumber)";
                
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", serviceman.Username);
                    cmd.Parameters.AddWithValue("@password", serviceman.Password);
                    cmd.Parameters.AddWithValue("@role", "Serviceman");
                    cmd.Parameters.AddWithValue("@rank", serviceman.Rank);
                    cmd.Parameters.AddWithValue("@position", serviceman.Position);
                    cmd.Parameters.AddWithValue("@unit", serviceman.Unit);
                    cmd.Parameters.AddWithValue("@personalNumber", serviceman.PersonalNumber);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static List<Violation> GetViolations(int? servicemanId = null)
        {
            List<Violation> violations = new List<Violation>();
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = servicemanId.HasValue ? 
                    "SELECT * FROM Violations WHERE ServicemanId = @servicemanId" :
                    "SELECT * FROM Violations";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    if (servicemanId.HasValue)
                        cmd.Parameters.AddWithValue("@servicemanId", servicemanId.Value);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            violations.Add(new Violation
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                ServicemanId = Convert.ToInt32(reader["ServicemanId"]),
                                Description = reader["Description"].ToString(),
                                Date = DateTime.Parse(reader["Date"].ToString()),
                                Type = reader["Type"].ToString(),
                                Punishment = reader["Punishment"].ToString()
                            });
                        }
                    }
                }
            }
            return violations;
        }

        public static bool AddViolation(Violation violation)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Violations (ServicemanId, Description, Date, Type, Punishment) 
                               VALUES (@servicemanId, @description, @date, @type, @punishment)";
                
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@servicemanId", violation.ServicemanId);
                    cmd.Parameters.AddWithValue("@description", violation.Description);
                    cmd.Parameters.AddWithValue("@date", violation.Date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@type", violation.Type);
                    cmd.Parameters.AddWithValue("@punishment", violation.Punishment);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
