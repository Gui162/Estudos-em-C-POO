using Utilizando_Vetores;

int quantidadeQuartos = 10;

Console.Write("Quantos Quartos voce deseja alugar:  ");
int n = int.Parse(Console.ReadLine());


Aluguel[] vect = new Aluguel[quantidadeQuartos];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Alguel #{i+1}:");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto: ");
    int quarto = int.Parse(Console.ReadLine());
    vect[quarto] = new Aluguel { Nome = nome, Email = email, NumeroQuarto = quarto };
    Console.WriteLine("\n");
}

Console.WriteLine("Quatos alugados: ");

for (int i = 0; i < quantidadeQuartos; i++)
{
    if (vect[i] != null)
    {
        Console.WriteLine(vect[i]);
    }
    
}