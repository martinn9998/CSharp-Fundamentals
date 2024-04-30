namespace _01._Company_Roster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empleyeesCount = int.Parse(Console.ReadLine());
            var empList = new List<Employee>();
            var depList = new List<string>();
            for (int i = 0; i < empleyeesCount; i++)
            {
                var input = Console
                    .ReadLine()
                    .Split()
                    .ToList();
                string name = input[0];
                double salary = double.Parse(input[1]);
                string department = input[2];
                Employee employee = new Employee(name, salary,
                    department);
                empList.Add(employee);
                depList.Add(department);
            }
            depList = depList
                .Distinct()
                .ToList();
            double highestSalary = 0;
            string maxSalaryDep = "";
            foreach (var item in depList)
            {
                double averageSalary = empList
                    .Where(x => x.Department == item)
                    .Select(x => x.Salary)
                    .Average();
                if (averageSalary > highestSalary)
                {
                    highestSalary = averageSalary;
                    maxSalaryDep = item;
                }
            }
            Console.WriteLine($"Highest Average Salary: {maxSalaryDep}");
            foreach (var item in empList
                .Where(x => x.Department == maxSalaryDep)
                .OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{item.Name} {item.Salary:f2}");
            }
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set;}
        public string Department { get; set;}
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
    }
}
