using System;


namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool Equal = Calculator<string>.AreEqual("A", "a");
            if(Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
    public class Calculator<T>
    {
        public static bool AreEqual(T Value1,T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
}
