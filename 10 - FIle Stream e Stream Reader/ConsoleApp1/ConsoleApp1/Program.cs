using System.IO;

string path = @"C:\Users\Gui\Desktop\Nova pasta\Estudos-em-C-POO\10 - FIle Stream e Stream Reader\ConsoleApp1\file1.txt";
FileStream fs = null;
StreamReader sr = null;

try
{
    //instanciando um filestream associado a um arquivo com a finalidade de abrir o arquivo para acesso.
    fs = new FileStream(path, FileMode.Open);
    sr = new StreamReader(fs);
    string line = sr.ReadLine();
    Console.WriteLine(line);
}
catch (IOException e)
{
    Console.WriteLine("Um erro ocorreu");
    Console.WriteLine(e.Message);
}
finally
{
    //fechando as streams pois elas nao sao gerenciadas diretamentes pelo .net e sim pelo windows

    if (sr != null) sr.Close();
    if (fs != null) fs.Close();
}

//  ================================================================================================================
/* ou podemos utilizar a classe FILE para ajudar a deixar o codigo mais limpo, pois ela faz a instanciacao
  do FileStream implicitamente */
//  ================================================================================================================

Console.WriteLine("\n");

try
{
    //instanciando um filestream associado a um arquivo com a finalidade de abrir o arquivo para acesso.
    sr = File.OpenText(path);
    string line = sr.ReadLine();
    Console.WriteLine(line);
}
catch (IOException e)
{
    Console.WriteLine("Um erro ocorreu");
    Console.WriteLine(e.Message);
}
finally
{
    //fechando as streams pois elas nao sao gerenciadas diretamentes pelo .net e sim pelo windows
    if (sr != null) sr.Close();
}


//  ================================================================================================================
/*                              agora mostrando como ler um arquivo ate o final  */
//  ================================================================================================================

Console.WriteLine("\n");

try
{
    //instanciando um filestream associado a um arquivo com a finalidade de abrir o arquivo para acesso.
    sr = File.OpenText(path);
    
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("Um erro ocorreu");
    Console.WriteLine(e.Message);
}
finally
{
    //fechando as streams pois elas nao sao gerenciadas diretamentes pelo .net e sim pelo windows
    if (sr != null) sr.Close();
}