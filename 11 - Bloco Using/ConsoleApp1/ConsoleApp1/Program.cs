using System.IO;

string path = @"C:\Users\Gui\Desktop\Nova pasta\Estudos-em-C-POO\11 - Bloco Using\ConsoleApp1\ConsoleApp1\TextFile1.txt";


// tudo que eu colocar nesse bloco vai ser executado e ao final desse bloco o recurso instanciado vai ser automaricamente fechado.

try
{
    using (FileStream fs = new FileStream(path, FileMode.Open))
    {
        using (StreamReader sr = new StreamReader(fs))
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }

        }
    }
}
catch (IOException e)
{
    Console.WriteLine("Aconteceu um erro");
    Console.WriteLine(e.Message);
}

/* =================================================================
 *                 utilizando a classe FILE
 * =================================================================*/


try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("Aconteceu um erro");
    Console.WriteLine(e.Message);
}