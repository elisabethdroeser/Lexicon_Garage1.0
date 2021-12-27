//using LexiconGarage1.Vehicles;
using LexiconGarage1;
using LexiconGarage1.Vehicles;
using System.Collections.Generic;
using static LexiconGarage1.ParkingManager<T>; //TODO:varför får jag detta felmeddelande?


//var garageManager = new GarageManager();
//garageManager.Run();
//garageManager.PrintAllVehicles();


var parkingManager = new ParkingHandler<Vehicle>();
parkingManager.Add(new Vehicle("ABC123", 4, "Ford", "Fiesta", "red"));
parkingManager.Save();

Console.ReadLine();

/* 
Parking();

 static void Parking()
{
    var park = new Parking<string>();
    park.Push("ABC123");
    park.Push("QWE124");
    park.Push("SYNTH");

    while (park.Count > 0)
    {
        var vehicle = park.Pop();
        Console.WriteLine($"Vehicle: {vehicle}");
    }
}


park.Push("ABC123", 4, "Ford", "Fiesta", "red"); 
park.Push("QWE124", 4, "BMW", "X5", "silver");
park.Push("SYNTH", 4, "Ford", "Fiesta", "red");
*/


//string regNo, int numberOfWheel, string name, string model, string color)
