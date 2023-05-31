using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Usage_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee()
            {
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
            IsPromotable isPromotable = new IsPromotable(Promote);
            Employee.PromoteEmployee(employees,isPromotable);
        }
        public static bool Promote(Employee emp)
        {
            return emp.Experience >= 5;
        }
    }
}
delegate bool IsPromotable(Employee emp1);
class Employee
{
    public int ID { get; set; }
    public string? Name { get; set; }

    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
    {
        foreach (Employee emp in employeeList)
        {
            if (IsEligibleToPromote(emp))
            {
                Console.WriteLine(emp.Name + " promoted");
            }
        }

    }
}
