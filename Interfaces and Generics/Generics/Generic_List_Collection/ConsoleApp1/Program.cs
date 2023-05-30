using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Employee
    {
        public string mName;
        public int mSalary;

        public Employee(string name, int salary)
        {
            mName = name;
            mSalary = salary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create a new empty List for Employee objects 
            List<Employee> employees = new List<Employee>(10);

            // TODO: Add some records to the list
            employees.Add(new Employee("John Doe", 50000));
            employees.Add(new Employee("Anish Joshi", 60000));
            employees.Add(new Employee("Nick Slick", 65000));
            employees.Add(new Employee("Anisha Joshi", 65000));


            // TODO: Inspect some List properties
            Console.WriteLine("Employee Capacity is: {0}",employees.Capacity);
            Console.WriteLine("Employee Count is: {0}",employees.Count);

            // TODO: Use Exists() and Find()
            if (employees.Exists(HighPay))
            {
                Console.WriteLine("\nHighly paid employee found!");
            }
            Employee e = employees.Find(x => x.mName.StartsWith("J"));
            if (e != null)
            {
                Console.WriteLine("Found Employee whose name starts with J: {0}", e.mName);
            }
            employees.ForEach(TotalSalaries);
            Console.WriteLine("Total payroll is: {0}\n",total);

            // TODO: Use ForEach to iterate over each item

            Console.WriteLine("\nPress Enter key to continue...");
        }

        // Iterator function for the ForEach method
        static int total = 0;
        static void TotalSalaries(Employee e)
        {
            total += e.mSalary;
        }

        // delegate function to use for the Exists method
        static Boolean HighPay(Employee emp)
        {
            return emp.mSalary >= 65000;
        }
    }
}