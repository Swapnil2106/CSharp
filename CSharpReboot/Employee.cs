using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReboot
{
    internal class Employee : Person, IPrintable
    {
        public int Salary { get; set; }

        public void PrintDetails(List<Employee> emplist)
        {
            foreach (var employee in emplist)
            {
                Console.WriteLine($"Name: {employee.Name}");
                Console.WriteLine($"Age: {employee.Age}");
                Console.WriteLine($"Email: {employee.Email}");
                Console.WriteLine($"Salary: {employee.Salary}\n");
            }
        }

        public static List<Employee> EmployeeWithSalaryGreaterThan50K(List<Employee> employees)
        {
            return employees.Where(e => e.Salary > 50000).ToList();
        }

        public static double GetEmployeesAverageSalary(List<Employee> employees)
        {
            return employees.Average(e => e.Salary);
        }

        public static Employee GetEmployee(List<Employee> employees)
        {
            return employees.OrderByDescending(e => e.Salary).FirstOrDefault();
        }

        public static List<string> GetEmployeeNames(List<Employee> employees)
        {
            return employees.OrderBy(e => e.Salary)
                            .Select(e => e.Name)
                            .ToList();
        }
    }
}
