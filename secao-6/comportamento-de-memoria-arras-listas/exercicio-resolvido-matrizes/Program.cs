Console.Clear();

int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];

for (int i = 0; i < n; i++)
{
    string[] values = Console.ReadLine().Split(' ');

    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = int.Parse(values[j]);     
    }
}

int negativeNumbers = 0;

Console.WriteLine("Main diagonal:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == j)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        if (matrix[i, j] < 0)
        {
            negativeNumbers++;
        }
    }
}

Console.WriteLine($"\nNegative numbers = {negativeNumbers}");