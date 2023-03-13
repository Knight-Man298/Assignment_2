namespace Assignment_2.Data;

public class Flights
{
    public string flightCode;
	public string airlineName;
	public string startingPoint;
    public string destination;
    public string day;
	public string time;
	public int availableSeats;
	public int price;

    public Flights(string flightcode, string airlinename, string startingpoint, string destination, string day, string time, int seats, int price)
    {
        this.flightCode = flightcode;
        this.airlineName = airlinename;
        this.startingPoint = startingpoint;
        this.destination = destination;
        this.day = day;
        this.time = time;
        this.availableSeats = seats;
        this.price = price;
    }

    public string Flightcode { get => flightCode; set => flightCode = value; }
    public string AirLineName { get=> airlineName; set=> airlineName = value; }
    public string StartingPoint { get => startingPoint; set => startingPoint = value; }
    public string Destination { get => destination; set => destination = value; }
    public string Day { get => day; set => day = value; }
    public string Time { get => time; set => time = value; }
    public int AvailableSeats { get => availableSeats; set => availableSeats = value; }
    public int Price { get => price; set => price = value; }

    public void FindFlight()
    {
        Console.WriteLine("spacefiller");
    }
}