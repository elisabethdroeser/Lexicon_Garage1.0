namespace LexiconGarage1;

internal class UI
{
    // Program => GarageManager =>
    internal static void Menu()
    {
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
                    GarageHandler();
                    break;

                 default:
                    break;
            }

        }
    }

    private static void GarageManager()
    {
        throw new NotImplementedException();
    }
}
