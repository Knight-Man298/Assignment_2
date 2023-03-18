using Assignment_2.Pages;
using Microsoft.Extensions.FileSystemGlobbing;

namespace Assignment_2.Data;
public class FlightsCode
{
    public string flightCode;
    public string airlineName;
    public string originAirport;
    public string destination;
    public string day;
    public string time;
    public int availableSeats;
    public int totalSeats;
    public double price;

    public FlightsCode(string flightcode, string airlinename, string originairport, string destination, string day, string time, int availableSeats, double price)
    {
        FlightCode = flightcode;
        AirlineName = airlinename;
        OriginAirport = originairport;
        Destination = destination;
        Day = day;
        Time = time;
		AvailableSeats = availableSeats;
        Price = price;
    }

    public string FlightCode { get => flightCode; set => flightCode = value; }
    public string AirlineName { get => airlineName; set => airlineName = value; }
    public string OriginAirport { get => originAirport; set => originAirport = value; }
    public string Destination { get => destination; set => destination = value; }
    public string Day { get => day; set => day = value; }
    public string Time { get => time; set => time = value; }
    public int AvailableSeats { get => availableSeats; set => availableSeats = value; }
    public int TotalSeats { get => totalSeats; set => totalSeats = value; }
    public double Price { get => price; set => price = value; }



    public static void findFlight(string originairport, string destination, string day)
    {
        
    }
}