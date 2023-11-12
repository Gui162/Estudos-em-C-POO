using _07___exercicio_de_fixacao;
using System.Globalization;

Conta conta;

Console.Write("Entre o numero da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta:");
string titular = Console.ReadLine();
Console.WriteLine("Havera deposito inicial ? (S/N)");
char resp = char.Parse(Console.ReadLine());

if (resp == 's' || resp == 'S')
{
    Console.WriteLine("Entre o Valor de Deposito Inicial");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new Conta(numero, titular, depositoInicial);
}
else
{
    conta = new Conta(numero, titular);
}

Console.WriteLine();
Console.WriteLine("Dados da conta");
Console.WriteLine(conta);

Console.Write("escreva um valor para deposito: ");
double quantia = double.Parse(Console.ReadLine());
conta.Deposito(quantia);
Console.WriteLine(conta);

Console.Write("escreva um valor para saque: ");
quantia = double.Parse(Console.ReadLine());
conta.Saque(quantia);
Console.WriteLine(conta);
