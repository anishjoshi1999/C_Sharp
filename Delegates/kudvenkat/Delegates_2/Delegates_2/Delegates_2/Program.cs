using System;
using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        List<Employee> empList = new List<Employee>();
        empList.Add(new Employee() {
        ID = 101,
        Name = "Mary",
        Salary = 5000,
        Experience = 5,
        });
        empList.Add(new Employee()
        {
            ID = 102,
            Name = "Mahendra",
            Salary = 6000,
            Experience = 15,
        });
        empList.Add(new Employee()
        {
            ID = 103,
            Name = "Mike",
            Salary = 4000,
            Experience = 4,
        });
        empList.Add(new Employee()
        {
            ID = 104,
            Name = "John",
            Salary = 3000,
            Experience = 5,
        });
        IsPromotable isPromotable = new IsPromotable(Promote);
        Employee.PromoteEmployee(empList, isPromotable);
    }
    public static bool Promote(Employee employee)
    {
        if(employee.Experience >= 5)
        {
            return true;
        }else
        {
            return false;
        }
    }
}
delegate bool IsPromotable(Employee emp);
class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }
    public static void PromoteEmployee(List<Employee> employeeList,IsPromotable IsEligibleToPromote)
    {
        foreach(Employee employee in employeeList)
        {
            if(IsEligibleToPromote(employee)) {
                Console.WriteLine(employee.Name + " promoted");
            }
        }
    }
}