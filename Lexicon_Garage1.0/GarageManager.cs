using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGarage1
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

        public void Park()
        {
            //skriv ut instruktioner (från UI-klassen)
            //ta emot input (regnr, fordonstyp etc)
            //skicka info till GarageHandler.Park => Garage
            // skriv ut att allt gått bra
        }

        public void Unpark()
        {
            ////skriv ut instruktioner (från UI-klassen)
            // ta emot regnr på fordonen som man vill upark
            // skicka info in till GarageHandler.Unpark => Garage
            // skriv ut att allt gått bra
        }

        public void SeedData()
        {
            //kalla på GarageHandler.SeedData
            //skriv ut att allt gått bra
        }

        public void Search()
        {
            //skriv ut instruktioner (från UI-klassen)
            //.. 
        }

        public void PrintAllVehicles()
        {
            garageHandler.PrintAllVehicles();
        }


    }
}
