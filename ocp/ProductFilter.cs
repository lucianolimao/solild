using System.Collections.Generic;
using System.Linq;
using ocp.Interfaces;

namespace ocp
{
    public class ProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            
            return items.Where(x => spec.IsSatisfied(x));

            // foreach (var i in items)
            //     if (spec.IsSatisfied(i))
            //         yield return i;
        }
    }
}