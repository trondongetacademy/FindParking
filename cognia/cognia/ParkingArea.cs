using System.Reflection.Metadata.Ecma335;
using Microsoft.SqlServer.Server;

namespace cognia;

public class ParkingArea
{
    public int id { get; set; }
    public string parkeringstilbyderNavn { get; set; }
    public float breddegrad { get; set; }
    public float lengdegrad { get; set; }
    public object deaktivert { get; set; }
    public int versjonsnummer { get; set; }
    public string navn { get; set; }
    public string adresse { get; set; }
    public string postnummer { get; set; }
    public string poststed { get; set; }
    public DateTime aktiveringstidspunkt { get; set; }
    public bool parkingForTrucks { get; set; }
    public bool fuelStationForTrucks { get; set; }
    public Facility facility { get; set; }
    public OpeningTime openingTime { get; set; }
    public bool has { get; set; }
}

public class OpeningTime
{
    public Day monday { get; set; }
    public Day tuesday { get; set; }
    public Day wednesday { get; set; }
    public Day thursday { get; set; }
    public Day friday { get; set; }
    public Day saturday { get; set; }
    public Day sunday { get; set; }

}

public class Day
{
    public string open { get; set; }

    public string close { get; set; }
}


public class Facility
{
    public bool restaurant { get; set; }
    public DateTime openingTime { get; set; }
    public DateTime closingTime { get; set; }
    public bool toilet { get; set; }
    public bool shower { get; set; }
}


