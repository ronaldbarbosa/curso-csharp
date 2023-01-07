Console.Clear();
string[] dim = Console.ReadLine().Split();
int x = int.Parse(dim[0]);
int y = int.Parse(dim[1]);
int[,] matrix = new int[x, y];

for (int i = 0; i < x; i++)
{
    string[] values = Console.ReadLine().Split();

    for (int j = 0; j < y; j++)
    {
        matrix[i, j] = int.Parse(values[j]);
    }
}

int value = int.Parse(Console.ReadLine());
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        if (value == matrix[i, j])
        {
            Console.WriteLine();
            Console.WriteLine($"Position {i},{j}:");
            if (i > 0)
            {
                Console.WriteLine($"Up: {matrix[i-1, j]}");
            }
            if (j > 0)
            {
                Console.WriteLine($"Left: {matrix[i, j-1]}");
            }
            if (j < y - 1)
            {
                Console.WriteLine($"Right: {matrix[i, j+1]}");
            }
            if (i < x - 1)
            {
                Console.WriteLine($"Down: {matrix[i+1, j]}");
            }
        }
        
    }
}