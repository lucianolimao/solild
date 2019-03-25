using System;
using System.Collections.Generic;
using System.Linq;

namespace ocp
{
    class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);
            var cat = new Product("Cat", Color.Blue, Size.Large);
            var dog = new Product("Dog", Color.Red, Size.Large);

            Product[] products = {apple, tree, house, cat, dog};

            ProductFilterNoRefactor productFilter = new ProductFilterNoRefactor();
            var productsByColor = productFilter.FilterByColor(Color.Blue, products);

            ExibeProdutos(productsByColor);

            // var productFilter = new ProductFilter();
            // var itens = productFilter.Filter(products, new ColorSpecification(Color.Blue));

            // Console.WriteLine("Blue products (new):");

            // foreach(var item in itens)
            //     Console.WriteLine(item.Name);

            // Console.WriteLine("");

            // Console.WriteLine("Green products (new):");

            // itens = productFilter.Filter(products, new ColorSpecification(Color.Green));

            // foreach(var item in itens)
            //     Console.WriteLine(item.Name);

            Console.ReadLine();
        }

        private static void ExibeProdutos(IEnumerable<Product> products)
        {
            foreach(Product product in products)
                Console.WriteLine(product.ToString());
        }
    }
}
