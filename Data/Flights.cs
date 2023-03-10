namespace Assignment_2.Data;

public class Flights
{
    public string flightcode;
	public string airlineName;
	public string startingPoint;
    public string destination;
    public string day;
	public string time;
	public int availableseats;
	public int price;

    public Flights(string flightcode, string airlinename, string startingpoint, string destination, string day, string time, int availableseats, int price)
    {
        this.flightcode = flightcode;
        this.airlineName = airlinename;
        this.startingPoint = startingpoint;
        this.destination = destination;
        this.day = day;
        this.time = time;
        this.availableseats = availableseats;
        this.price = price;
    }

    public string Flightcode { get => flightcode; set => flightcode = value; }
    public string AirLineName { get=> airlineName; set=> airlineName = value; }
    public string StartingPoint { get => startingPoint; set => startingPoint = value; }
    public string Destination { get => destination; set => destination = value; }
    public string Day { get => day; set => day = value; }
    public string Time { get => time; set => time = value; }
    public int AvailableSeats { get => availableseats; set => availableseats = value; }
    public int Price { get => price; set => price = value; }

    public void FindFlight()
    {
        Console.WriteLine("spacefiller");
    }
}