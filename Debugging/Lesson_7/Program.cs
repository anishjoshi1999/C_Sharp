namespace Lesson_7
{
    class Program
    {
        enum Shape
        {
            Error,
            Rectangle,
            Square
        }
        static void testShape(Shape shape)
        {
            switch (shape)
            {
                case Shape.Rectangle:
                    Console.WriteLine("Rectangle");
                    break;
                case Shape.Square:
                    Console.WriteLine("Square");
                    break;
                default:
                    throw new Exception("Shape not set");
              
            }
        }
        static void Main(string[] args)
        {
            Shape s = new Shape();
            Program.testShape(s);
        }
    }
}