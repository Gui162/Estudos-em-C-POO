using exercicio01;

Pessoas pessoa1, pessoa2;

pessoa1 = new Pessoas();
pessoa2 = new Pessoas();



Console.WriteLine("Insira o nome da pessoa1:");
pessoa1.Nome = Console.ReadLine();
Console.WriteLine("Insira a idade da pessoa1:");
pessoa1.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o nome da pessoa2:");
pessoa2.Nome = Console.ReadLine();
Console.WriteLine("Insira a idade da pessoa2:");
pessoa2.Idade = int.Parse(Console.ReadLine());

if (pessoa1.Idade > pessoa2.Idade)
{
    Console.WriteLine($"Pessoa mais velhaL: {pessoa1.Nome}");
}
else
{
    Console.WriteLine($"Pessoa mais velha: {pessoa2.Nome}");
};



