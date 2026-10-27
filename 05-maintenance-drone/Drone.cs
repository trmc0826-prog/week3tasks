using System.Reflection.Metadata.Ecma335;

public class Drone
{
    public string Name { get; set; }
    public int FlightHours { get; set; }

    public Drone(string name, int flightHours)
    {
        Name = name;
        FlightHours = flightHours;
    }

    public string Describe()
    {
        // TODO
        return $"{Name} has {FlightHours}";
    }

    public bool NeedsService()
    {
        // TODO
        return FlightHours >= 100;
    }
}
