using System;
using System.IO;

namespace srp
{
    public class Product
    {
        public string Name { get; set; }
        public string Size {get;set;}

        public Product()
        {
        }

        public override string ToString()
        {
            return Name + " " + Size;
        }
    }

    public class Persistence
    {
        public void Save(string filename, Product product)
        {
            if(!File.Exists(filename))
             File.WriteAllText(filename, product.ToString());
        }
    }

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