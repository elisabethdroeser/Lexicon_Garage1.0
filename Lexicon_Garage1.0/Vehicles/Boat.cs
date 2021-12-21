using LexiconGarage1.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Garage1.Vehicles
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
