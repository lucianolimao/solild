﻿using System;
using System.IO;

namespace srp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.Name = "Cabo USB";
            p.Size = "1.5m";

            Persistence persist = new Persistence();
            persist.Save("/home/luciano/Projects/solid/srp/bin/Debug/netcoreapp2.1/product.txt", p);

            Console.WriteLine("Produto salvo");
        }
    }
}