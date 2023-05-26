using System;
public class Employee
{
    public string? FirstName;
    public string? LastName;
    public void PrintFullName()
    {
        Console.WriteLine(this.FirstName + " " + this.LastName);
    }
}
public class PartTimeEmployee:Employee
{
    public new void PrintFullName()
    {
        //base.PrintFullName();
        //Console.WriteLine(this.FirstName + " " + this.LastName + " - Contractor");
    }
}
public class FullTimeEmployee: Employee
{

}
public class Program
{
    public static void Main(string[] args)
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "FullTimeEmployee";
        FTE.LastName = "Joshi";
        FTE.PrintFullName();

        PartTimeEmployee PTE = new PartTimeEmployee();
       // Employee PTE1 = new PartTimeEmployee();
        PTE.FirstName = "PartTimeEmployee";
        PTE.LastName = "Joshi";
        PTE.PrintFullName();
       // PTE1.PrintFullName();
       //((Employee)PTE).PrintFullName();
    }
}