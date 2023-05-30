using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program1
    {
        static int findMax(int a, int b)
        {
            int max = a < b ? b : a;
            return max;
        }
        static void Main(string[] args)
        {
            int max = findMax(3, 8);
            Console.WriteLine(max);
        }
    }
}
