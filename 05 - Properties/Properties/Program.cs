
using Course;

Produto p = new Produto("TV", 500, 10);


/* sem as propieties voce teria que utilizar desta forma:

 Console.WriteLine(p.GetNome);
 p.SetNome("Tv 4k")

 Console.WriteLine(p.GetQuantidade);

 com as propieties voce pdoe usar desta forma: */

p.Nome = "tv 4k";

Console.WriteLine(p.Nome);
Console.WriteLine(p.Quantidade);