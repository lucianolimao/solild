using System;
using System.Collections.Generic;
using static System.Console;

namespace isp
{
    public interface IPrinter
    {
        void Print();
    }

    public interface IScanner
    {
        void Scan();
    }

    public interface IMultifunctional : IPrinter, IScanner
    {

    }

    public class Printer : IPrinter
    {
        public void Print()
        {
            WriteLine("Imprimindo...");
        }
    }

    public class Multifunctional : IMultifunctional
    {
        public void Print()
        {
            WriteLine("Imprimindo...");
        }

        public void Scan()
        {
            WriteLine("Scanning...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            printer.Print();

            WriteLine("");

            var multi = new Multifunctional();
            multi.Print();
            multi.Scan();

            ReadLine();
        }
    }
}
