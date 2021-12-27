using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LexiconGarage.Vehicles;

namespace LexiconGarage
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private T[] vehicles;
        public Garage(int size)
        {
            vehicles = new T[size];
        }

        public bool Park(T vehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    return true;
                }
            }
            return false;
        }

        public bool UnPark(string regno)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i].RegNo == regno)
                {
                    vehicles[i] = null;
                    return true;
                }
            }
            return false;
        }

        // denna bestämmer vad som händer när vi gör en foreach över en instans av Garage<Vehicle>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null)
                {
                    yield return vehicles[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
