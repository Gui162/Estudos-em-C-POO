using exercicio02;

Funcionarios funcionario1, funcionario2;
double mediaSalario;

funcionario1 = new Funcionarios();
funcionario2 = new Funcionarios();

Console.WriteLine("Dados do primeiro funcionario");
funcionario1.Nome = Console.ReadLine();
funcionario1.Salario = double.Parse(Console.ReadLine());

Console.WriteLine("Dados do segundo funcionario");
funcionario2.Nome = Console.ReadLine();
funcionario2.Salario = double.Parse(Console.ReadLine());

mediaSalario = (funcionario1.Salario + funcionario2.Salario) / 2;

Console.WriteLine($"salario medio = {mediaSalario}");

