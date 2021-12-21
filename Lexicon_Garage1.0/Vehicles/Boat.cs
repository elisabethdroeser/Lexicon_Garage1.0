using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGarage1.Vehicles
{
    internal class Boat : Vehicle
    {
        public int NumberOfEngines { get; set; }

        public Boat(int regNo, string name, string model, string color, int numberOfWheel, int numberOfEngines) : base(regNo, numberOfWheel, name, model, color)
        {
            NumberOfEngines = numberOfEngines; 
        }
    }
}
