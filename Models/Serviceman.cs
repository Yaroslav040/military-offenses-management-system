using System;

namespace MilitaryOffenseAutomation.Models
{
    public class Serviceman : User
    {
        public string Rank { get; set; }        // Звання
        public string Position { get; set; }     // Посада
        public string Unit { get; set; }         // Підрозділ
        public string PersonalNumber { get; set; } // Особистий номер
    }
}
