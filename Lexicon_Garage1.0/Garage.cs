using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LexiconGarage1.Vehicles;

namespace LexiconGarage1
{
    internal class Garage //: IEnumerable<T> where T : IVehicle
    {
        public Garage(int size)
        {
            vehicles = new Vehicle[size]; 
        }
        private Vehicle[] vehicles;

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
