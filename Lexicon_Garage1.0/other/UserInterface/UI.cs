using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LexiconGarage.Vehicles;

namespace LexiconGarage1;

public class UI
{
    // Program => GarageManager =>
    static void Menu()
    {
        while (true)
        { 
            Console.WriteLine("Welcome to LexiGarage");
            Console.WriteLine("Use the below numbers to do what you want.");
            Console.WriteLine("\n1. Create a garage");
            Console.WriteLine("\n2. Add a new vehicle to the garage");
            Console.WriteLine("\n3. Remove a vehicle from the garage");
            Console.WriteLine("\n4. Print a list of vehicles in the garage");
            Console.WriteLine("\n5. Search for types, models etc in the garage");
            Console.WriteLine("\n0. Exit the program:");

            char input = ' ';
            try
            {
                input = Console.ReadLine()![0];
            }
            catch (IndexOutOfRangeException)
            {
                Console.Clear();
                Console.WriteLine("Please enter input");
            }
            switch (input)
            {
                case '1':
                    CreateGarage();
                    break;
                case '2':
                    Park();
                    break;
                case '3':
                    UnPark();
                    break;
                case '4':
                    PrintAllVehicles();
                    break;
                case '5':
                    FindByRegNo();
                    break;
                case '0';
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please enter the valid numbers 1, 2, 3, 4, 5 or 0");
                    break;
            }   
        }
    }


}
