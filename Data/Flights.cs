namespace Assignment_2.Data;
public class Flights
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

    public Flights(string flightcode, string airlinename, string originairport, string destination, string day, string time, int seats,int totalseats ,double price)
    {
        this.flightCode = flightcode;
        this.airlineName = airlinename;
        this.originAirport = originairport;
        this.destination = destination;
        this.day = day;
        this.time = time;
        this.availableSeats = seats;
        this.totalSeats = totalseats;
        this.price = price;
    }

    public string Flightcode { get => flightCode; set => flightCode = value; }
    public string AirLineName { get=> airlineName; set=> airlineName = value; }
    public string OriginAirport{ get => originAirport; set => originAirport = value; }
    public string Destination { get => destination; set => destination = value; }
    public string Day { get => day; set => day = value; }
    public string Time { get => time; set => time = value; }
    public int AvailableSeats { get => availableSeats; set => availableSeats = value; }
    public int TotalSeats { get => totalSeats; set => totalSeats = value; }
    public double Price { get => price; set => price = value; }

    public static void findFlight( string OriginAirport , string destination, string day)
    {
        
    }
}