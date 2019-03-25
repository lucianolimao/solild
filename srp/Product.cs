namespace srp
{
    public class Product
    {
        public string Name { get; set; }
        public string Size {get;set;}

        public Product()
        {
        }

        public override string ToString()
        {
            return Name + " " + Size;
        }
    }
}