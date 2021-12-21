namespace LexiconGarage1;

internal class UI
{
    internal static void MenuManager()
    {
        while (true)
        {
            Console.WriteLine("Please go through the menu by using the number \n(1, 2, 3, 0 etc)."
                + "\n1. Check garage"
        ) 
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
                case
            }



        }
    }
}
