using System.Collections.Generic;

namespace ocp
{
    public class ProductFilterNoRefactor
    {
        public IEnumerable<Product> FilterByColor(Color color, IEnumerable<Product> products)
        {
            foreach(Product product in products)
            {
                if(product.Color == color)
                    yield return product;
            }
        }
    }
}