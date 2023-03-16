using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.AppBroadcasting;

namespace Assignment_2.Data
{
    public class Reservations 
    {
        public string reservationCode;
        public string flightCode;
        public string airlineName;
        public int cost;
        public string name;
        public string citizenship;
        public bool status;

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

       public static void MakeReservation( object Flights,  string xnames,  string xcitizenship )

        {
            if (Flights != null && xnames != null && xcitizenship != null)  {
                // make reservation code before // 
                Reservations new = Reservations(Flights.FlightCode, Flights.AirlineName, Flights.Cost, xnames, xcitizenship, status);
                    //add this into a reservations list and possibly new txt file // 
            }
        
            else if (Flights.availableSeats == 0)
            {
                throw new Exception("UNAVAIBLE");
            }
            else {
                throw new Exception("fill all fields");
                    };
        }

        public static void FindReservation(string rescode, string airline, string name)
        {          
                if (rescode == Reservations.ReservationCode || airline == Reservations.AirlineName || name == Reservations.Name)
                {
                    // display reservation// 
                }
                else throw new Exception();    
        }

    
    }


    

}
