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
		//"C:\\Users\\msimm\\Desktop\\Semester 2\\OOP2\\Assignments\\Assignment_2\\Assignment_2\\Resources\\Project Data\\flights.csv"
		public const string FLIGHTS_PATH = "C:\\Users\\Anton\\OneDrive\\Desktop\\OOP2\\Assignment2\\Resources\\Project Data\flights.csv";
		public static List<FlightsCode> flights = new List<FlightsCode>();
		public FlightManager() 
		{
			AddFlight();
		}

		public void AddFlight()
		{
			FlightsCode flight;
			foreach (string line in File.ReadLines(FLIGHTS_PATH))
			{
				string[] parameter = FLIGHTS_PATH.Split(",");
				
				string code = parameter[0];
				string airport = parameter[1];
				string origin = parameter[2];
				string destination = parameter[3];
				string dayOfWeek = parameter[4];
				string departureTime = parameter[5];
				int seatsAvailable = int.Parse(parameter[6]);
				double price = double.Parse(parameter[7]);

				flight = new FlightsCode(code, airport, origin, destination, dayOfWeek, departureTime, seatsAvailable, price);

				flights.Add(flight);
			}
		}

		public static List<FlightsCode> GetFlights()
		{
			return flights;
		}
	}
}
