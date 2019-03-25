using System.IO;

namespace srp
{
    public class ProductWithoutRefactor
    {
        public string Name { get; set; }
        public string Size {get;set;}

        public override string ToString()
        {
            return Name + " " + Size;
        }
        
        public ProductWithoutRefactor()
        {

        }

        public void Save(string filename, ProductWithoutRefactor product)
        {
            if(!File.Exists(filename))
             File.WriteAllText(filename, product.ToString());
        }
    }
}