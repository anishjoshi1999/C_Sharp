namespace Lesson_5
{
    class Program
    {
        static int findMin(int[] arr)
        {
            int min = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                int current = arr[i+ 1];
                if(min > current)
                {
                    min = current;
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 20, 4 };
            int min = findMin(numbers);
            Console.WriteLine(min);
        }
    }
}