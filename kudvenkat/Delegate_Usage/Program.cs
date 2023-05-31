using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Usage
{
    class Program
    {
        public static void Main(string[] args) { 
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee() {
            ID = 1,
            Name = "Test",
            Salary = 10000,
            Experience = 1,
            });

            employees.Add(new Employee()
            {
                ID = 2,
                Name = "Test2",
                Salary = 20000,
                Experience = 2,
            });

            employees.Add(new Employee()
            {
                ID = 3,
                Name = "Test3",
                Salary = 50000,
                Experience = 6,
            });

            employees.Add(new Employee()
            {
                ID = 4,
                Name = "Test4",
                Salary = 60000,
                Experience = 5,
            });

            Employee.PromoteEmployee(employees);
        }
    }
    }
    class Employee
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList) {
            foreach (Employee emp in employeeList)
            {
                if(emp.Experience >= 5) {
                    Console.WriteLine(emp.Name + " promoted");
                }
            }
        
        }
    }
