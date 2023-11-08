using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee ID:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Employee Gender (M/F):");
            char gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Salary:");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Date of Joining (DD/MM/YYYY):");
            DateTime doj = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.WriteLine("\nID\tEmployee Name\t\tEmployee Gender\t\tEmployee Salary\t\tDOJ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{id}\t{name}\t\t\t{gender}\t\t\t{salary}\t\t{doj:dd/MM/yyyy}");

            double taxRate = (salary > 90000) ? 0.3 : 0.15;
            double tax = salary * taxRate;

            Console.WriteLine($"\nYou have to pay: {tax}");
            Console.ReadKey();
        }
    }
}
