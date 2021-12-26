namespace LexiconGarage1;

internal class UI
{
    // Program => GarageManager =>
    internal static void Menu()
    {
        do
        {
            Console.WriteLine("Welcome to LexiGarage");
            Console.WriteLine("Use the below numbers to do what you want. ");
            Console.WriteLine("Create a garage");
            Console.WriteLine("Add a new vehicle to the garage");
            Console.WriteLine("Remove a vehicle from the garage"); 
            Console.WriteLine("Print a list of vehicles in the garage");
            Console.WriteLine("Search for types, models etc in the garage");
            Console.WriteLine("* 0: Exit the program:");
            } 
        while (true);
        }
        /*
        while (true)
        {
            Console.WriteLine("Please go through the menu by using the number \n(1, 2, 3, 0 etc)."
                + "\n1. Check garage"
        ); 
            char input = ' ';

            try
            {
                input = Console.ReadLine()![0];
            }
            catch (IndexOutOfRangeException)
            {
                Console.Clear();
                Console.WriteLine("Please enter some input");
            }
            switch (input)
            {
                case '1':
                    GarageManager();
                    break;
                case '2':
                    //GarageHandler();
                    break;

                 default:
                    break;
            }

        }
    }
        */

        private static void GarageManager()
    {
        throw new NotImplementedException();
    }
}
