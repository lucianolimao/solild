using isp.Interfaces;
using static System.Console;

namespace isp
{
    public class Multifunctional : IMultifunctional
    {
        public void Print()
        {
            WriteLine("Imprimindo...");
        }

        public void Scan()
        {
            WriteLine("Escaniando...");
        }
    }
}
