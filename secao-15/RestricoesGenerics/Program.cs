using RestricoesGenerics.Entities;
using RestricoesGenerics.Services;
using System.Globalization;

List<Product> list = new List<Product>();

Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] vect = Console.ReadLine().Split(",");
    list.Add(new Product(vect[0], double.Parse(vect[1], CultureInfo.InvariantCulture)));
}

CalculationService calculationService = new CalculationService();
Product max = calculationService.Max(list);
Console.WriteLine($"Max:{max}");