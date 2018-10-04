using System;
using System.Linq;

namespace complete
{
    class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);
            var car = new Product("Car", Color.Blue, Size.Medium);

            Product[] products = {apple, tree, house, car};

            var productFilter = new ProductFilter();
            var itens = productFilter.Filter(products, new ColorSpecification(Color.Green));

            Console.WriteLine("Products:");

            var filePersist = new FilePersistence();
            filePersist.Save(itens);

            Console.ReadLine();
        }
    }
}
