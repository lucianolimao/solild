using System.IO;

namespace srp
{
public class Persistence
    {
        public void Save(string filename, Product product)
        {
            if(!File.Exists(filename))
             File.WriteAllText(filename, product.ToString());
        }
    }
}