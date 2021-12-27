using LexiconGarage.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

        internal void PrintAllVehicles()
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

        public void Park()
        {
            // få input för att skapa ett nytt foirdon
            // kalla på garage.Park();
        }

        public void UnPark()
        {
            // få input för vilket regnr vi vill ta bort
            // kalla på garage.Unpark();
        }

        public void FindByRegNo()
        {
            // få input för vilket regno vi vill skriva ut info om
            // använd foreach (var vehicle in garage){ vehicle.RegNo osv osv }
        }
    }
}
