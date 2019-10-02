using static System.Console;

namespace isp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Impressora");
            var printer = new Printer();
            printer.Print();

            WriteLine("");

            WriteLine("Scanner");
            var scanner = new Scanner();
            scanner.Scan();

            WriteLine("");

            WriteLine("Multifuncional");
            var multi = new Multifunctional();
            multi.Print();
            multi.Scan();

            ReadLine();
        }
    }
}