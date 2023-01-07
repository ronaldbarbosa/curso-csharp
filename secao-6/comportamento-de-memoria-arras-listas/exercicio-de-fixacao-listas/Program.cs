using System;
using System.Collections.Generic;

namespace exercicio_de_fixacao_listas
{
    public class Exercicio
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            List<Employee> registredEmployees = new List<Employee>();

            Console.Write("How many emplyees will be registered? ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine($"Employee #{i + 1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: " );
                double salary = double.Parse(Console.ReadLine());

                Employee employee = new Employee(id, name, salary);
                registredEmployees.Add(employee);

                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int employeeId = int.Parse(Console.ReadLine());
            int pos = registredEmployees.FindIndex(x => x.Id == employeeId);

            if(pos == -1) 
            {
                Console.WriteLine("This id does not exist!");
            } 
            else
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                registredEmployees[pos].increaseSalary(percentage);
            }

            Console.WriteLine("\nUpdated list of employees:");
            foreach (Employee employee in registredEmployees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}