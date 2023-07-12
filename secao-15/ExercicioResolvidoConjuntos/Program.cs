using ExercicioResolvidoConjuntos.Entities;

string tempPath = Path.GetTempPath();
Console.Write("Enter file name: ");
string fileName = Console.ReadLine();

HashSet<LogRecord> records = new HashSet<LogRecord>();

try
{
    using (StreamReader sr = File.OpenText($"{tempPath}{fileName}"))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(' ');
            string name = line[0];
            DateTime instant = DateTime.Parse(line[1]);
            records.Add(new LogRecord(name, instant));
        }
        Console.WriteLine($"Total users: {records.Count}");
    }
}
catch (IOException ex) 
{
    Console.WriteLine(ex.Message);
}