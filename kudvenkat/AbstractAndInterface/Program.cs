//abstract classes can have implementations for some of its members(Methods)
//But the interface can't have implementation for any of its members

//An interface members are public by default
//An abstract class are private by default

//A class can inherit from multiple interfaces at the same time, where as a class cannot inherit from multiple classes at the same time.
//Abstract class members can have access modifiers where as interface members cannot have access modifiers

// abstract classes can have implementations for some of its members
// Interfaces cannot have fields(int,float,char,double etc) where as an abstract class can have fields

using System;
public abstract class Customer
{
    public void Print()
    {
        Console.WriteLine("Print");
    }
}
public interface ICustomer
{
    public void Print();
}
public class Program
{
    public static void Main(string[] args)
    {

    }
}
