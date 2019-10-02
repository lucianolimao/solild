using isp.Interfaces;
using static System.Console;

namespace isp
{
    public class Printer : IPrinter
    {
        public void Print()
        {
            WriteLine("Imprimindo...");
        }
    }
}
