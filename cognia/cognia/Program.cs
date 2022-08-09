using System.Data.SqlClient;
using System.Text.Json;
using System.Text.RegularExpressions;
using cognia;

// reading Json file.
var parkingAreasJson = File.ReadAllText("parkeringsomraade.json"); 
var parkingAreas = JsonSerializer.Deserialize<ParkingArea[]>(parkingAreasJson);

// Create local server.
var builder = WebApplication.CreateBuilder();
var app = builder.Build();
app.UseHttpsRedirection();
//Getting the information.
app.MapGet("/FindParking", () => 
{
    List<ParkingArea> areas = new List<ParkingArea>();
    foreach (var parkingArea in parkingAreas) 
    {
        //if (facility == null) Continue to next)
        if (parkingArea.facility == null) continue;
        // if (facility has shower and facility has parking for trucks) add to areas list.
        if (parkingArea.facility.shower && parkingArea.parkingForTrucks)
        {
            areas.Add(parkingArea);
        }
    }
    return areas; // return list
});
app.Run();