using System.Globalization;
namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // CONTRUTOR

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // CONSTRUTOR 2 (recebe so o nome e preco, quantidade vem zerada)

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
          //Quantidade = 0; (essa linha nao e necessaria pois valores numericos como int e double por padrao ja vem zerados quando sao criados)
        }

        // CONSTRUTOR 3

        public Produto() { }
        

        // METODOS
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}