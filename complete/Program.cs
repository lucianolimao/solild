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

            Product[] products = {apple, tree, house};

            var productFilter = new ProductFilter();
            var itens = productFilter.Filter(products, new ColorSpecification(Color.Green));

            Console.WriteLine("Products:");

            var filePersist = new FilePersistence();
            filePersist.Save(itens);

            Console.ReadLine();
        }
    }
}
