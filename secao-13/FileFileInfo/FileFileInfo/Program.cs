using System.IO;

string sourcePath = @"C:/temp/file1.txt";
string targetPath = @"C:/temp/file2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);

    string[] lines = File.ReadAllLines(sourcePath);
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
} catch (IOException ex)
{
    Console.WriteLine("An error ocurred");
    Console.WriteLine(ex.Message);
}