using System;
using System.Collections.Generic;

namespace Generic_List_Collection
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
            List<Employee> empList = new List<Employee>(10);
            // TODO: Add some records to the list
            empList.Add(new Employee("John Doe", 50000));
            empList.Add(new Employee("John Smith", 60000));
            empList.Add(new Employee("John Slick", 70000));
            empList.Add(new Employee("Mildred Mintz", 50000));
            // TODO: Inspect some List properties
            Console.WriteLine("empList Capacity is: {0}",empList.Capacity);
            Console.WriteLine("emList Count is: {0}",empList.Count);
            // TODO: Use Exists() and Find()
            if (empList.Exists(HighPay))
            {
                Console.WriteLine("\nHighly paid employee found!");
            }
            Employee e = empList.Find(x => x.mName.StartsWith("J"));
            if(e != null)
            {
                Console.WriteLine("Found Employee whose name starts with J: {0}",e.mName);
            }

            // TODO: Use ForEach to iterate over each item
            empList.ForEach(TotalSalaries);
            Console.WriteLine("Total payroll is: {0}",total);

            Console.WriteLine("\nPress Enter key to continue...");
            Console.ReadLine();
        }

        // Iterator function for the ForEach method
        static int total = 0;
        static void TotalSalaries(Employee e) {
        total += e.mSalary;
        }

        // delegate function to use for the Exists method
        static Boolean HighPay(Employee emp) {
        return emp.mSalary >= 65000;
        }
    }
}