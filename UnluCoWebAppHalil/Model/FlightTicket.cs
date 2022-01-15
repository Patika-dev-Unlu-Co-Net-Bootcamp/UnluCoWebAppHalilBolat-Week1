using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCoWebAppHalil.Model
{
    public class FlightTicket
    {
        public FlightTicket(string name, string surname, int id, string flightCode, DateTime flightDate,bool isActive)
        {
            this.Name = name;
            this.Surname = surname;
            this.Id = id;
            this.FlightCode = flightCode;
            this.FlightDate = flightDate;
            this.IsActive = isActive;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }
        public string FlightCode { get; set; }
        public bool IsActive { get; set; }
        public DateTime FlightDate { get; set; }

    }
}
