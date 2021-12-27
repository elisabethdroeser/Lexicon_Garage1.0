using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGarage.Vehicles
{
    internal class Bus : Vehicle
    {
        public int Length { get; set; }

        public Bus(string regNo, string name, string model, string color, int numberOfWheel, int length) : base(regNo, numberOfWheel, name, model, color)
        {
            Length = length;
        }
        public override string ToString()
        {
            return base.ToString() + $", Length: {Length}.";
        }
    }
}
