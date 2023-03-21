using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_2.Data
{
	internal class FlightManager
	{
		public const string FLIGHTS_PATH = "C:\\Users\\msimm\\Desktop\\Semester 2\\OOP2\\Assignments\\Assignment_2\\Assignment_2\\Resources\\Project Data\\flights.csv";
		//public const string FLIGHTS_PATH = "C:\\Users\\Anton\\OneDrive\\Desktop\\OOP2\\Assignment2\\Resources\\Project Data\flights.csv";
		public static List<Flight> flights = new List<Flight>();
		public FlightManager() 
		{
			AddFlight();
		}

		public void AddFlight()
		{
			foreach (string line in File.ReadLines(FLIGHTS_PATH))
			{
				string[] parameter = line.Split(",");

				Flight flight = new Flight();
				flight.FlightCode = parameter[0];
				flight.AirlineName = parameter[1];
				flight.OriginAirport = parameter[2];
				flight.Destination = parameter[3];
				flight.Day = parameter[4];
				flight.Time = parameter[5];
				flight.AvailableSeats = int.Parse(parameter[6]);
				flight.Price = double.Parse(parameter[7]);

				flights.Add(flight);
			}
		}

		public static List<Flight> GetFlights()
		{
			return flights;
		}
	}
}
