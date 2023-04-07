namespace LowLevelDesign.SOLID.Liskov_Substitution_Principle
{
    // Violation of LSP
    /*public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalculateArea()
        {
            return Width * Height;
        }
    }

    public class Square : Rectangle
    {
        public new int Width
        {
            set { base.Width = base.Height = value; }
        }

        public new int Height
        {
            set { base.Width = base.Height = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Square();
            rectangle.Width = 5;
            rectangle.Height = 10;

            int area = rectangle.CalculateArea(); // Output: 50, should be 25
        }
    }
    */



    // Implementation of LSP
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalculateArea()
        {
            return Width * Height;
        }
    }

    public class Square : Rectangle
    {
        public Square(int length)
        {
            Width = Height = length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 5;
            rectangle.Height = 10;

            int area = rectangle.CalculateArea(); // Output: 50

            Square square = new Square(5);
            area = square.CalculateArea(); // Output: 25

        }
    }


}
