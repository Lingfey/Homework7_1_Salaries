using System;
using System.Text.RegularExpressions;

namespace Homework7_1_Salaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] arr = new string[5, 2];
            for (int i = 0; i < 5; i++)
            {
                string name, salary;
                Console.Write(i + 1 + ". ");
                do
                {
                    Console.WriteLine("Enter the name of an employee");
                    name = Console.ReadLine();
                    if (!Regex.IsMatch(name, @"^[A-Z][a-z]+$"))
                    {
                        Console.WriteLine("Wrong name format");
                    }
                }
                while (!Regex.IsMatch(name, @"^[A-Z][a-z]+$"));
                arr[i, 0] = name;
                do
                {
                    Console.WriteLine("Enter the salary amount");
                    salary = Console.ReadLine();
                    if (!Regex.IsMatch(salary, @"^[-1-9][\d]+$"))
                    {
                        Console.WriteLine("Wrong salary format");
                    }
                    else if (Convert.ToDouble(salary) < 0)
                    {
                        Console.WriteLine("Salary amount can't be less than 0");
                    }
                    else if (Convert.ToDouble(salary) > 200000)
                    {
                        Console.WriteLine("Salary amount is too high");
                    }
                }
                while (!Regex.IsMatch(salary, @"^[-1-9][\d]+$") || Convert.ToDouble(salary) < 0 || Convert.ToDouble(salary) > 200000);
                arr[i, 1] = salary;
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + ". ");
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0} ", arr[i, j]);

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}