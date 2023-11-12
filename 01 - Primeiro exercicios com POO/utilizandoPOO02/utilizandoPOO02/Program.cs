

using utilizandoPOO02;
using System.Globalization;

Produto p = new Produto();

// CRIANDO UM OBJETO CHAMADO P
Console.WriteLine("Entre com os dados do produto");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();
Console.Write("Preco: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade: ");
p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();
Console.WriteLine("Dados do Produto: " + p);

// ADICIONANDO PRODUTOS
Console.WriteLine();
Console.Write("Digite o numero de produtos a ser adiconado no estoque: ");
int qtd = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qtd);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);

// REMOVENDO PRODUTOS
Console.WriteLine();
Console.Write("Digite o numero de produtos a ser removidos no estoque: ");
qtd = int.Parse(Console.ReadLine());
p.RemoverProdutos(qtd);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);

