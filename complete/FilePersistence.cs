using System;
using System.IO;
using System.Collections.Generic;

namespace complete
{
    public class FilePersistence : IPersistence<Product>
    {
        private readonly string filename = "/home/luciano/Projects/solid/product.txt";

        public void Save(IEnumerable<Product> products)
        {
            string prods = "";

            if(!File.Exists(filename))
             {
                 foreach (var product in products)
                    prods += product.ToString() + "\n";
                 
                 File.WriteAllText(filename, prods);

                 Console.WriteLine("Produtos salvos.");
             }
        }
    }
}