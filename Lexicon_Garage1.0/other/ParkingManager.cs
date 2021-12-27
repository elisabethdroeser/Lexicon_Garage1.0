
/*using LexiconGarage.Vehicles;
using System.Collections.Generic;

namespace LexiconGarage1;
public class ParkingManager <T>
{
    //private UI ui;

    //private GarageHandler garageHandler;

    protected readonly List<T> _vehicles = new();
    public void Add(T vehicle)
    {
        _vehicles.Add(vehicle);
    }

    public void Save()
    {
        foreach (var vehicle in _vehicles)
        {
            Console.WriteLine(vehicle);
        }
    }

    public class ParkingHandler<T> : ParkingManager<T>
    {
        public void Remove(T vehicle)
        {
            _vehicles.Remove(vehicle);
        }
    }

}
    /*
    public GarageManager()
    {
        ui = new UI();
        garageHandler = new GarageHandler(10);

    }

        //show main metod som kallar på ui menyn
        //funktioner, parkera fordon, fråga om vissa saker. input
        //vilken typ av fordon
    
    private static void AddToGarage(string regNo, int numberOfWheel, string name, string model, string color) //private static void AddToList(string value,List<string> list)
    {
        //ta emot input (regnr, fordonstyp etc)
        //skicka info till GarageHandler.Park => Garage
        // skriv ut att allt gått bra
        var list = new List<string>();
        var input = Console.ReadLine();
        var value = input?.Substring(1);

        Console.WriteLine("Welcome to LexiGarage." +
                "Please fill in the following details:" +
                "registration number, type of vehicle, model,color, number of wheels etc. "); //skriv ut instruktioner (från UI-klassen)

        list.Add(value);
        Console.WriteLine($"\"{value}\" has been added to the list");

    }

    static void Unpark()
    {
        ////skriv ut instruktioner (från UI-klassen)
        // ta emot regnr på fordonen som man vill upark
        // skicka info in till GarageHandler.Unpark => Garage
        // skriv ut att allt gått bra
    }

    static void SeedData()
    {
        //kalla på GarageHandler.SeedData
        //skriv ut att allt gått bra
    }

    static void Search()
    {
        //skriv ut instruktioner (från UI-klassen)
        //.. 
    }

    static void PrintAllVehicles()
    {
        //garageHandler.PrintAllVehicles();
    }
    */


