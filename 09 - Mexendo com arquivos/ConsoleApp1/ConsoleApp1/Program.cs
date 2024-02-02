using System.IO;

// o @ e para nao ter q colocar duas \\ no caminho, exemplo C:\\users\\gui

string soucePath = @"C:\Users\Gui\Desktop\Nova pasta\Estudos-em-C-POO\09 - Mexendo com arquivos\file1.txt";
string targetPath = @"C:\Users\Gui\Desktop\Nova pasta\Estudos-em-C-POO\09 - Mexendo com arquivos\file2.txt";

try
{
    /*
      FileInfo fileInfo = new FileInfo(soucePath);
    fileInfo.CopyTo(targetPath);
    */

    string[] lines = File.ReadAllLines(soucePath);
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("Um erro ocorreu");
    Console.WriteLine(e.Message);
}