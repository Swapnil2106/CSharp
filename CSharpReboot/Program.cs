using System.Security.Cryptography.X509Certificates;

namespace CSharpReboot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();

            e1.Name = "Jack";
            e1.Age = 30;
            e1.Email = "Jack@gmail.com";
            e1.Salary = 80000;

            e2.Name = "Peter";
            e2.Age = 25;
            e2.Email = "Peter@gmail.com";
            e2.Salary = 50000;

            //To add employees to a list, we can use the following codes:
            //Code 1
            List<Employee> empList = new List<Employee>
            { 
                e1, e2 
            };

            e1.PrintDetails(empList);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            List<Employee> empList2 = new List<Employee>
            {
                new Employee { Name = "Alice", Age = 28, Email = "alice@example.com", Salary = 60000 },
                new Employee { Name = "Bob", Age = 32, Email = "bob@example.com", Salary = 70000 },
                new Employee { Name = "Charlie", Age = 27, Email = "charlie@example.com", Salary = 55000 },
                new Employee { Name = "Diana", Age = 29, Email = "diana@example.com", Salary = 62000 },
                new Employee { Name = "Edward", Age = 35, Email = "edward@example.com", Salary = 90000 }
            };

            var highEarners = Employee.EmployeeWithSalaryGreaterThan50K(empList2);
            Console.WriteLine("Employees with salary greater than 50K:");
            foreach (var emp in highEarners)
            {
                Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}");
            }

            double averageSalary = Employee.GetEmployeesAverageSalary(empList2);
            Console.WriteLine($"\nAverage Salary of Employees: {averageSalary}");

            Employee topEarner = Employee.GetEmployee(empList2);
            Console.WriteLine($"\nTop Earner: {topEarner.Name}, Salary: {topEarner.Salary}");

            List<string> employeeNames = Employee.GetEmployeeNames(empList2);
            Console.WriteLine("\nEmployee Names in ascending order of salary:");
            foreach (var name in employeeNames)
            {
                Console.WriteLine(name);
            }


        }
    }
}
