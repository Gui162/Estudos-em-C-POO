using System.IO;
string sourcePath = @"C:\Users\Gui\Desktop\Nova pasta\Estudos-em-C-POO\12 - Stream Writer\ConsoleApp1\ConsoleApp1\TextFile1.txt";
string targetPath = @"C:\Users\Gui\Desktop\Nova pasta\Estudos-em-C-POO\12 - Stream Writer\ConsoleApp1\ConsoleApp1\TextFile2.txt";



/* Pegando o arquivo um copiando e escrevendo tudo em maiusculo no arquivo 2 que nao existia */

try
{
    //lendo todas as linhas do arquivo
    string[] lines = File.ReadAllLines(sourcePath);

    //usando o bloco using para fechar o SW e escrever todo o conteudo que esta na string lines acima no arquivo target 2 tudo em maiusculo.
    using (StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (string line in lines)
        {
            sw.WriteLine(line.ToUpper());
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("Aconteceu Um erro");
    Console.WriteLine(e.Message);
}
