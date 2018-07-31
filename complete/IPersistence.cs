using System.Collections.Generic;

namespace complete
{
    public interface IPersistence<T>
    {
        void Save(IEnumerable<T> obj);
    }
}