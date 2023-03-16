using Microsoft.Extensions.FileSystemGlobbing;

namespace Assignment_2.Data;
public class Flight
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

    public Flight(string flightcode, string airlinename, string originairport, string destination, string day, string time, int seats, int totalseats, double price)
    {
        flightCode = flightcode;
        airlineName = airlinename;
        originAirport = originairport;
        this.destination = destination;
        this.day = day;
        this.time = time;
        availableSeats = seats;
        totalSeats = totalseats;
        this.price = price;
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

      //  foreach (Flight flight in Flights.flights)
        {
       //     if (flight.OriginAirport == originairport);
       //     if (flight.Destination == destination) ;
       //     if (flight.Day == day) ;
            //Flights.flights.Add(flight);
        }
    }
}