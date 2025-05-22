using System;

namespace MilitaryOffenseAutomation.Models
{
    public class Violation
    {
        public int Id { get; set; }
        public int ServicemanId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }        // Тип правопорушення
        public string Punishment { get; set; }   // Покарання
    }
}
