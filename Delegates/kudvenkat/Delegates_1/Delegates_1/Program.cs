using System;
public delegate void HelloFunctionDelegate(string message);
class Program
{
    public static void Main(string[] args)
    {
        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
        del("Hello from delegate");
        //A delegate is a type safe function pointer
        //It points to a function
    }
    public static void Hello(string s)
    {
        Console.WriteLine(s);
    }
}