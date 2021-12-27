using LexiconGarage.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGarage.Vehicles
{
    internal class Boat : Vehicle
    {
        public int NumberOfEngines { get; set; }

        public Boat(string regNo, string name, string model, string color, int numberOfWheel, int numberOfEngines) : base(regNo, numberOfWheel, name, model, color)
        {
            NumberOfEngines = numberOfEngines;
        }

        public override string ToString()
        {
            return base.ToString() + $", Number of Engines:{NumberOfEngines}.";
        }
    }
}
