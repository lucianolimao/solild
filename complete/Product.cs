namespace complete
{
    public class Product
    {
        public string Name { get;set; }
        public Size Size { get;set; }
        public Color Color { get; }

        public Product(string name, Color color, Size size)
        {
            this.Color = color;
            this.Size = size;
            this.Name = name;
        }

        public override string ToString()
        {
            return Name + " " + Size + " - Cor: " + Color;
        }
    }

    public enum Size
    {
        Small = 1,
        Medium = 2,
        Large = 3
    }

    public enum Color
    {
        Yellow = 1,
        Green = 2,
        Blue = 3
    }
}