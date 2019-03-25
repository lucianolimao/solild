using System;

namespace ocp
{
   public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Color = color;
            Size = size;
        }

        public override string ToString()
        {
            return Name + " " + Color + " " + Size;
        }
    }
}