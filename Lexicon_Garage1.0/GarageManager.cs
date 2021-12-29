using System.Text;

namespace LexiconGarage
{
    public class GarageManager
    {
        static IUI ui = new ConsoleUI();
        public void ShowMenu()
        {
            ui.PrintString("Welcome to LexiGarage");
            ui.PrintString("Use the below numbers to do what you want.");
            ui.PrintString("\n1. Create a garage");
            ui.PrintString("\n2. Park your vehicle to the garage");
            ui.PrintString("\n3. Remove a vehicle from the garage");
            ui.PrintString("\n4. Print a list of vehicles in the garage");
            ui.PrintString("\n5. Search for types, models etc in the garage");
            ui.PrintString("\n0. Exit the menu");
           ;
        }


        /*
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
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter the valid numbers 1, 2, 3, 4, 5 or 0");
                        break;
                }
            }
        }

        private static void FindByRegNo()
        {
            Console.WriteLine("testfindbyreg");
        }

        private static void PrintAllVehicles()
        {
            Console.WriteLine("testprintall");
        }

        private static void UnPark()
        {
            Console.WriteLine("Unpark");
        }

        /*static void Park()
        {
            var list = new List<string>();
            bool finish = false;
            Console.Clear();

            Console.WriteLine("Welcome to LexiGarage!" +
                "\n Park your vehicle to the garage" +
                "\n Please enter details to park your vehicle" +
                "\n '1': Registration number" +
                "\n '2': Number of wheels" +
                "\n '3': Type of vehicle" +
                "\n '4': Model" +
                "\n '5': Color" +
                "\n '0': Exit back to main menu");  

            do
            {
                var input = Console.ReadLine();
                var nav = input[0];
                var value = input.Substring(1);
                
                switch (nav)
                {
                    case '1':
                        Console.WriteLine("Hej");
                        break;


                }

            } while (!finish);
        }
        
        private static void CreateGarage()
        {
            Console.WriteLine("creategarage");
        }
        */
    }
}