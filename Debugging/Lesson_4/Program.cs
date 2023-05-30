using System.Diagnostics.CodeAnalysis;

namespace Lesson_4
{
    class Program
    {
        static int summation(int[] nums,int counter)
        {
            if(counter == -1) { 
            return 0;
            }
            else
            {
                int sum = nums[counter] + summation(nums, counter - 1);
                return sum;
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int sum = summation(numbers,numbers.Length - 1);
            Console.WriteLine(sum);
            int[] otherNumbers = { 1, 2, 20, 18 };
            int otherSum = summation(otherNumbers, otherNumbers.Length - 1);
            Console.WriteLine(otherSum);
        }
    }
}