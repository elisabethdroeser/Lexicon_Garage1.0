using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGarage.Vehicles
{
    internal class Airplane : Vehicle
    {
        public int NumberOfSeats { get; set; }

        public Airplane(string regNo, string name, string model, string color, int numberOfWheel, int numberOfSeats) : base(regNo, numberOfWheel, name, model, color)
        {
            NumberOfSeats = numberOfSeats;
        }

        public override string ToString()
        {
            return base.ToString() + $", Number of Seats: {NumberOfSeats}.";
        }
    }
}
