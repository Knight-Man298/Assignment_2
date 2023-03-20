using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Windows.Media.AppBroadcasting;
namespace Assignment_2.Data
{
    public partial class Reservations 
    {
        public string reservationCode;
        public string flightCode;
        public string airlineName;
        public double cost;
        public string name;
        public string citizenship;
        public bool status;

        public Reservations(string reservationCode, string flightCode, string airlineName, double cost, string name, string citizenship, bool status)
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
        public double Cost { get => cost; set => cost = value; }
        public string Name { get => name; set => name = value; }
        public string Citizenship { get => citizenship; set => citizenship = value; }
        public bool Status { get => status; set => status = value; }


        public static void FindReservation(string rescode, string airline, string name, Reservations y)
        {          
                if (rescode == y.ReservationCode || airline == y.AirlineName || name == y.Name)
                {
                    // display reservation// 
                }
                else
            {
                Console.WriteLine( "error");
                //expecption
            }  
        }

        private static readonly Random random = new Random();

        private static string ReservationCodeGenerator()
        {
            char randomletter = (char)random.Next('A', 'Z' + 1);
            int randomnumber = random.Next(1000,10000);
            return string.Format("{0}{1:D4}", randomletter, randomnumber); 
        }

    }


    

}
