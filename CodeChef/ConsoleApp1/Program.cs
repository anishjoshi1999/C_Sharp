using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());    
            try
            {
                for (int i = 0; i < n; i++)
                {
                    string[] inputString = Console.ReadLine().Split();
                    int[] inputs = Array.ConvertAll(inputString, s => int.Parse(s));
                    int Chef = inputs[0];
                    int Chefina = inputs[1];
                    if(Chef + Chefina > 6)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine("Please enter a valid input");
                Console.WriteLine(ex.ToString());
            }
           
          
        }
    }
}
