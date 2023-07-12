string path = Path.GetTempPath();
Console.Write("Enter the file name: ");
string fn = Console.ReadLine();

Dictionary<string, int> votes = new Dictionary<string, int>();
votes.Add("Alex Blue", 0);
votes["Maria Green"] = 0;
votes["Bob Brown"] = 0;

try
{
    using (StreamReader sr = File.OpenText($"{path}{fn}"))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(',');
            string votesKey = line[0];
            int votesNumber = int.Parse(line[1]);
            votes[votesKey] += votesNumber;
        }
        foreach (var candidate in votes) Console.WriteLine($"{candidate.Key}: {candidate.Value}");
    }
}
catch (IOException ex) 
{
    Console.WriteLine(ex.Message);
}