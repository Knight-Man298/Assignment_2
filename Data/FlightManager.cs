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
		public List<Flight> flights = new List<Flight>();
		public FlightManager() 
		{
			AddFlight();
		}

		public void AddFlight()
		{
			foreach (string flight in File.ReadLines(FLIGHTS_PATH))
			{
				string[] parameter = flight.Split(",");
				
				string code = parameter[0];
				string airport = parameter[1];
				string origin = parameter[2];
				string destination = parameter[3];
				string dayOfWeek = parameter[4];
				string departureTime = parameter[5];
				double price = double.Parse(parameter[6]);
			}
		}

		public List<Flight> GetFlights()
		{
			return flights;
		}
	}
}
