using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LexiconGarage1.Vehicles;

namespace LexiconGarage1
{
    //Garaget: En representation av själva byggnaden. Garaget är en plats där en mängd av fordon kan förvaras.Garaget kan alltså representeras som en samling av fordon.
    //generisk samling av fordon, begränsas av en constraint. 

    //internal class Garage //: IEnumerable<T> where T : IVehicle
    public class Garage //: IEnumerable
    {
        public Garage(int size)
        {
            vehicles = new Vehicle[size];
        }


        private Vehicle[] vehicles;

        // public Garagee[] vehicles)
        //    {
        //
        //    }
        //public IEnumerator<Vehicle> GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
