using LexiconGarage.Vehicles;

namespace LexiconGarage
{
    public class GarageHandler
    {
        private Garage<Vehicle> garage;

        //print all vehicles m egenskaper

        public GarageHandler(int size)
        {
            garage = new Garage<Vehicle>(size);
        }

        public void PrintAllVehicles()
        {
            foreach (var vehicle in garage)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }

        public void SeedData()
        {
            garage.Park(new Car("CAR111", "Volvo", "S40", "White", 4, "Petrol"));
            garage.Park(new Airplane("AIR111", "SAAB", "Apple", "Grey", 5, 2));
            garage.Park(new Bus("BUS111", "MAN", "100", "Red", 10, 10));
            garage.Park(new Bus("BUS111", "MAN", "100", "Red", 10, 10));
            garage.UnPark("BUS111");
        }

        public void FindByRegNo()
        {
            // få input för vilket regno vi vill skriva ut info om
            // använd foreach (var vehicle in garage){ vehicle.RegNo osv osv }
        }


        private static void UnPark()
        {
            // få input för vilket regnr vi vill ta bort
            // kalla på garage.Unpark();
        }

        public void Park()
        {
            // få input för att skapa ett nytt fordon
            // kalla på garage.Park();
            var list = new List<string>();
            bool finish = false;
            Console.Clear();

            Console.WriteLine("Welcome to LexiGarage!" +
                "\n Park your vehicle to the garage" +
                "\n Please enter details to park your vehicle" +
                "\n '1': Registration number" +
                "\n '2': Number of wheels" +
                "\n '3': Type of vehicle" +
                "\n '4': Model" +
                "\n '5': Color" +
                 "\n '0': Exit back to main menu");

            do
            {
                var input = Console.ReadLine();
                var nav = input[0];
                var value = input.Substring(1);

                switch (nav)
                {
                    case '1':
                        Console.WriteLine("");
                        break;
                }

            } while (!finish);
        }
        private static void CreateGarage()
        {
            throw new NotImplementedException();
        }

    }
}