using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjMoreEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            List<AverageSalary> salaries = new List<AverageSalary>();

            List<string> departments = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string department = input[2];

                Employee employee = new Employee(name, department, salary);
                employees.Add(employee);
                if(!departments.Contains(department))
                {
                    departments.Add(department);
                    AverageSalary averageSalary = new AverageSalary(department, new List<decimal> { salary });
                    salaries.Add(averageSalary);
                }
                else
                {
                    int index = salaries.FindIndex(x => x.Department==department);
                    salaries[index].Salary.Add(salary);
                }
             
            }

            string bestDepartment = "";
            decimal bestSalary = 0;
            foreach (var salary in salaries)
            {
                if (salary.Salary.Count > 0)
                {
                    decimal currentSalary = salary.Salary.Sum() / salary.Salary.Count;
                    if (currentSalary > bestSalary)
                    {
                        bestSalary = currentSalary;
                        bestDepartment = salary.Department;
                    }
                }
            }
            Console.WriteLine($"Highest Average Salary: {bestDepartment}");
            foreach (var emplyee in employees.Where(x=> x.Department==bestDepartment).OrderByDescending(x=> x.Salary))
            {
                Console.WriteLine($"{emplyee.Name} {emplyee.Salary:F2}");
            }
        }
    }


    class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string department, decimal salary)
        {
            Name = name;
            Department = department;
            Salary = salary;
        }
    }

    class AverageSalary
    {
        public string  Department { get; set; }
        public List<decimal> Salary { get; set; }

        public AverageSalary(string department, List<decimal> salary)
        {
            Department = department;
            Salary = salary;
        }
    }

}
