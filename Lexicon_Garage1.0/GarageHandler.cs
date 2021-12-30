using LexiconGarage.Vehicles;

namespace LexiconGarage
{
    public class GarageHandler
    {
        private Garage<Vehicle> garage; //print all vehicles m egenskaper

        public GarageHandler()
        {
            
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


        public void UnPark()
        {
            // få input för vilket regnr vi vill ta bort
            // kalla på garage.Unpark();
        }

        public void Park()
        {
            // få input för att skapa ett nytt fordon
            var type = "";
            // Fråga om typ
            Console.WriteLine("Choose Vehicle type:" +
                "\n 1. Car" +
                "\n 2. Airplane" +
                "\n 3. ...");
            
            var nav = Console.ReadLine();

            switch (nav)
            {
                case "1":
                    type = "Car";
                    break;
                case "2":
                    type = "Airplane";
                    break;
                default:
                    break;
            }

            Console.WriteLine("Enter licence number: ");
            var regnr = Console.ReadLine();

            Console.WriteLine("Enter name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Enter color: ");
            var color = Console.ReadLine();

            Console.WriteLine("Enter model: ");
            var model = Console.ReadLine();

            Console.WriteLine("Enter number of wheels: ");
            var nrofwheels = Int32.Parse(Console.ReadLine());

            switch (type)
            {
                case "Car":
                    Console.WriteLine("Enter fueltype");
                    var fueltype = Console.ReadLine();
                    if (garage.Park(new Car(regnr, name, model, color, nrofwheels, fueltype)))
                    {
                        Console.WriteLine("Car successfully parked");
                    }
                    else
                    {
                        Console.WriteLine("Car not successfully parked!");
                    }
                    
                    
                    break;
                case "Airplane":
                    Console.WriteLine("Enter number of seats");
                    var nrofseats = Console.ReadLine();
                    break;
                default:
                    break;
            }



        }
        public void CreateGarage()
        {
            // todo, få input från användaren
            var size = 10;
            garage = new Garage<Vehicle>(size);
        }

    }
}