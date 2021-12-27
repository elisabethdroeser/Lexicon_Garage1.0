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
    public class Garage<Vehicle> : IEnumerable<Vehicle>
    {
        private Vehicle[] vehicles;
        public Garage(int size)
        {
            vehicles = new Vehicle[size];
        }

        public bool Park(Vehicle vehicle)
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
                //if (vehicles[i])
                //{

                //}
            }
            return false;
        }

        // denna bestämmer vad som händer när vi gör en foreach över en instans av Garage<Vehicle>
        public IEnumerator<Vehicle> GetEnumerator()
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
