using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static double tripleNumber(double num)
        {
            double tripleNumber = num + 3;
            return tripleNumber;
        }
        static void Main(string[] args) {
            double originalNumber = 3;
            Console.WriteLine(originalNumber + " tripled is " + tripleNumber(originalNumber));
        }
    }
}
