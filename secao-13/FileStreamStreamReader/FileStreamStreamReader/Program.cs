string path = @"C:/temp/file1.txt";
FileStream fs = null;
StreamReader sr = null;

try
{
    fs = new FileStream(path, FileMode.Open);
    sr = new StreamReader(fs);
    string line = sr.ReadLine();
    Console.WriteLine(line);
} catch(IOException ex)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(ex.Message);
} finally
{
    if (fs != null) fs.Close();
    if (sr != null) sr.Close();
}

// Bloco using: sintaxe mais sucinta para declarar e fechar objetos IDisposable (objetos não gerenciados pelo CLR)
// Para não precisar instanciar um FileStream para usar o StreamREader, é possível usar a classe estática File
Console.WriteLine("===============================");
try
{
    using (sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
} catch(Exception ex)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(ex.Message);
}