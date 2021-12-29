namespace LexiconGarage
{
    public class ConsoleUI : IUI
    {
        public string GetStringInput() => Console.ReadLine();

        public void PrintString(string message) => Console.WriteLine(message);
    }
}
