using System.Text;

namespace LexiconGarage
{
    public interface IUI
    {
        string GetStringInput();
        void PrintString(string message);
    }
}
