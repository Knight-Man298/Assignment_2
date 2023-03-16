using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Data
{
    public class Reservations 
    {
        private string reservationCode;
        private string flightCode;
        private string airlineName;
        private int cost;
        private string name;
        private string citizenship;
        private bool status;

        public Reservations(string reservationCode, string flightCode, string airlineName, int cost, string name, string citizenship, bool status)
        {
            this.reservationCode = reservationCode;
            this.flightCode = flightCode;
            this.airlineName = airlineName;
            this.cost = cost;
            this.name = name;
            this.citizenship = citizenship;
            this.status = status;
        }

        public string ReservationCode { get => reservationCode; set => reservationCode = value; }
        public string FlightCode { get => flightCode; set => flightCode = value; }
        public string AirlineName { get => airlineName; set => airlineName = value; }
        public int Cost { get => cost; set => cost = value; }
        public string Name { get => name; set => name = value; }
        public string Citizenship { get => citizenship; set => citizenship = value; }
        public bool Status { get => status; set => status = value; } 




    }

}
