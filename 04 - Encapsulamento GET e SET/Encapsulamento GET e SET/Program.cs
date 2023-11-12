using Course;

Produto p = new Produto("TV", 500.00, 10);

p.SetNome("Tv 4k");

Console.WriteLine(p.GetNome());

/* p.SetPreco (nao existe pos nao setamos para poder modificar o preco, isso e uma coisa bacana que se pode fazer com o get & set)
 fora que com get e set conseguimos fazer algumas logicas nesses metodos, como o GETNOME o nome tem q ser maior q 3 caracteres... 

 nao existe tambem SetQuantidade */


Console.WriteLine(p.GetPreco());

Console.WriteLine(p.GetQuantidade());

Console.WriteLine(p.ValorTotalEmEstoque());

p.AdicionarProdutos(5);

Console.WriteLine(p.GetQuantidade());

Console.WriteLine(p.ValorTotalEmEstoque());

