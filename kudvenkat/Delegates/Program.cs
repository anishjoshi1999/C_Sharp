using System;
public delegate void HelloFunctionDelegate(string Message);
class Program
{
    public static void Main(string[] args)
    {
        //A Delegate is a type safe function pointer
        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
        del("Hello From Delegate");
    }
    public static void Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
    }
}