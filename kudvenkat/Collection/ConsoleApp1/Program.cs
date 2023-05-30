using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Anish",
                Salary = 500000
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Anisha",
                Salary = 500000
            };
            List<Customer> customers = new List<Customer>(2);
            List<SavingCustomer> savingCustomers = new List<SavingCustomer>(2);
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            for(int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine(customers[i].ID);
                Console.WriteLine(customers[i].Name);
                Console.WriteLine(customers[i].Salary);
            }
        }
        public class Customer
        {
            public int ID { get; set; }
            public string? Name { get; set; }
            public int Salary { get; set; }
        }
        public class SavingCustomer: Customer {
        
        }

    }
}
