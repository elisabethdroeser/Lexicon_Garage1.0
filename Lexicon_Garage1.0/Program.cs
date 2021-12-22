using LexiconGarage1.Vehicles;

//var garageManager = new GarageManager();
//garageManager.Run();
//garageManager.PrintAllVehicles();

namespace Lexicon_Garage1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car test1 = new Car("ABC123", "Ford", "Fiesta", "red", 4, "diesel");
            Motorcycle test2 = new Motorcycle("QWERTY123", "HD", "Explorer", "red", 2, 70);

            Console.WriteLine(test1);
            Console.WriteLine(test2);
            Console.ReadLine();
        }
    }
}

