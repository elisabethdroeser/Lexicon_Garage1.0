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
    }
}
