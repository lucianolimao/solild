using System.Collections.Generic;

namespace complete
{
    public interface IFilter<T>
    {
         IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}