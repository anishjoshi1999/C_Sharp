namespace Lesson_6
{
    class Program
    {
        static bool isItSquare(Tuple<int,int> rect)
        {
            if(rect.Item1 <= 0 || rect.Item2 <= 0)
            {
                Console.WriteLine("Error: Not a shape");
                return false;
            }

            return rect.Item1 == rect.Item2;
        }
        static void Main(string[] args)
        {
            Tuple<int,int> rect1 = new Tuple<int,int>(0,0);
            bool r = Program.isItSquare(rect1);
            Console.WriteLine(r);

            Tuple<int, int> rect2 = new Tuple<int, int>(15, 5);
            bool r1 = Program.isItSquare(rect2);
            Console.WriteLine(r1);
        }
    }
}