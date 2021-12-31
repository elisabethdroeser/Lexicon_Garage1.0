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
            bool finish = false;
            Console.Clear();

            // Fråga om typ
            Console.WriteLine("Choose Vehicle type:" +
                "\n 1. Car" +
                "\n 2. Airplane" +
                "\n 3. Boat" +
                "\n 4. Bus" +
                "\n 5. Motorcycle" +
                "\n 0. Exit");

            var nav = Console.ReadLine();

            switch (nav)
            {
                case "1":
                    type = "Car";
                    break;
                case "2":
                    type = "Airplane";
                    break;
                case "3":
                    type = "Boat";
                    break;
                case "4":
                    type = "Bus";
                    break;
                case "5":
                    type = "Motorcycle";
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please press either 1-5 depending on what you want to do");     
                    break;
            }

            Console.WriteLine("Enter licence number: ");
            var regNo = Console.ReadLine();

            Console.WriteLine("Enter name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Enter color: ");
            var color = Console.ReadLine();

            Console.WriteLine("Enter model: ");
            var model = Console.ReadLine();

            Console.WriteLine("Enter number of wheels (only numbers):");
            var nrOfwheel = Int32.Parse(Console.ReadLine());

            switch (type)
            {
                case "Car":
                    Console.WriteLine("Enter fueltype:");
                    var fuelType = Console.ReadLine();
                    if (garage.Park(new Car(regNo, name, model, color, nrOfwheel, fuelType)))
                    {
                        Console.WriteLine("Car successfully parked");
                    }
                    else
                    {
                        Console.WriteLine("Car not successfully parked!");
                    }
                    break;
                case "Airplane":
                    Console.WriteLine("Enter number of seats; ");
                    var nrOfSeats = Int32.Parse(Console.ReadLine());
                    if (garage.Park(new Airplane(regNo, name, model, color, nrOfwheel, nrOfSeats)))
                    {
                        Console.WriteLine("Airplane successfully parked");
                    }
                    else
                    {
                        Console.WriteLine("Airplane not successfully parked!");
                    }
                    break;
                case "Boat":
                    Console.WriteLine("Enter number of engines; ");
                    var nrOfEngines = Int32.Parse(Console.ReadLine());
                    if (garage.Park(new Boat(regNo, name, model, color, nrOfwheel, nrOfEngines)))
                    {
                        Console.WriteLine("Boat successfully parked");
                    }
                    else
                    {
                        Console.WriteLine("Boat not successfully parked!");
                    }
                    break;
                case "Motorcycle":
                    Console.WriteLine("Enter number of engines; ");
                    var cylinderVolume = Int32.Parse(Console.ReadLine());
                    if (garage.Park(new Motorcycle(regNo, name, model, color, nrOfwheel, cylinderVolume)))
                    {
                        Console.WriteLine("Motorcycle successfully parked");
                    }
                    else
                    {
                        Console.WriteLine("Motorcycle not successfully parked!");
                    }
                    break;
                default:
                    break;
            } 
       }  
        public void CreateGarage()
        {
            // todo, få input från användaren
            Console.WriteLine("How large shall your garage be?");
            var input = Console.ReadLine();
            var size = input.Length;
            //var size = 10;
            garage = new Garage<Vehicle>(size);
        }

    }
}