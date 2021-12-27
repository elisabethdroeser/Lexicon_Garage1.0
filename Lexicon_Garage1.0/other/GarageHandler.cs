using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LexiconGarage1
{
    internal class GarageHandler
    {
        private Garage garage;

        //parkera fordon - push
        //hämta ut fordon - pop
        //print all vehicles m egenskaper
        
        public GarageHandler(int size)
        {
            garage = new Garage(size);
        }

        internal void PrintAllVehicles()
        {
            //foreach (var vehicle in garage)
            //{
            //    Console.WriteLine(vehicle.Stats());
            //}
        }

        public void SeedData()
        {
            //skapa ett gäng frodon
            // parkjera dem
        }
    }
}
