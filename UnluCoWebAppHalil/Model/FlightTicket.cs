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
            this.name = name;
            this.surname = surname;
            this.id = id;
            this.flightCode = flightCode;
            this.flightDate = flightDate;
            this.isActive = isActive;
        }

        public string name { get; set; }
        public string surname { get; set; }
        public int id { get; set; }
        public string flightCode { get; set; }
        public bool isActive { get; set; }
        public DateTime flightDate { get; set; }

    }
}
