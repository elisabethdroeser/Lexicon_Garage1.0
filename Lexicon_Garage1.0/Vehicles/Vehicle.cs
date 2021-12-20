using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Garage1._0.Vehicles
{
    internal class Vehicle
    {
        private int regNo;

        public int RegNo { get; set; }

        public string? color;

        public string? Color { get; set; }
    
        public Vehicle(int regNo, string color)
        {
                RegNo = regNo;  
                Color = color;  
        }


    }
}
