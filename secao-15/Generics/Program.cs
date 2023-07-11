using Generics;

PrintService<string> printService = new PrintService<string>();

Console.Write("How many values? ");
int numberOfValues = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfValues; i++)
{
    string value = Console.ReadLine();
    printService.AddValue(value);
}

Console.WriteLine($"First: {printService.First()}");
printService.Print();