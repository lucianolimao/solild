using static System.Console;

namespace lsp
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public Rectangle()
        {
            
        }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
    }

    public class Square : Rectangle
    {
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }
    }

    class Program
    {
        static public int Area(Rectangle r) => r.Width * r.Height;

        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(2,3);
            WriteLine($"{rc} has area {Area(rc)}");

            // should be able to substitute a base type for a subtype
            Rectangle sq = new Square();

            //Square sq = new Square();

            sq.Width = 4;
            WriteLine($"{sq} has area {Area(sq)}");
            WriteLine("");
            WriteLine($"Tipo: {sq.GetType().Name}");
            ReadLine();
        }
    }
}
