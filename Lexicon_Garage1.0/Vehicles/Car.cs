using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGarage.Vehicles
{
    internal class Car : Vehicle
    {
        public string FuelType { get; set; }

        public Car(string regNo, string name, string model, string color, int numberOfWheel, string fuelType) : base(regNo, numberOfWheel, name, model, color)
        {
            FuelType = fuelType;
        }
        public override string ToString()
        {
            return base.ToString() + $", FuelType: {FuelType}.";
        }
    }
}
