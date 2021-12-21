using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGarage1._0
{
    internal class GarageManager
    {
        private UI ui;

        private GarageHandler garageHandler;

        public GarageManager()
        {
            ui = new UI();
            garageHandler = new GarageHandler(10);
        }

        //show main metod som kallar på ui menyn
        //funktioner, parkera fordon, fråga om vissa saker. input
        //vilken typ av fordon

        public void PrintAllVehicles()
        {
            garageHandler.PrintAllVehicles();
        }
    }
}
