using System.Globalization;
using Exercicio_proposto.Entities;

namespace Exercicio_proposto
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Enter the number of tax payers: ");
            int taxPayersNumber = int.Parse(Console.ReadLine());
            List<TaxPayer> taxPayers = new List<TaxPayer>();
            
            for (int i = 1; i <= taxPayersNumber; i++)
            {
                Console.WriteLine();

                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c): ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                switch (type)
                {
                    case 'i':
                        Console.Write("Health expenditures: ");
                        double healthExpenditures = double.Parse(Console.ReadLine());
                        taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
                        break;
                    case 'c':
                        Console.Write("Number of employees: ");
                        int numberOfEmployees = int.Parse(Console.ReadLine());
                        taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                        break;
                    default:
                        break;
                }
                
            }

            Console.WriteLine();

            double totalTaxes = 0;

            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine($"{taxPayer.Name}: $ {taxPayer.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture)}");
                
                totalTaxes += taxPayer.TaxesPaid();
            }

            Console.WriteLine();

            Console.WriteLine($"TOTAL TAXES: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}