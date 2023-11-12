using System.Globalization;
namespace Course
{
    class Produto
    {
        // ATRIBUTOS

        private string _nome;
        private double _preco;
        private int _quantidade;



        // CONSTRUTORES
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            // nomenclatura de atributos privados e minuscula e comecando com underline
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        // GET & SET
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 3)
            {
                _nome = nome;
            }
        }
        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        // METODOS DA CLASSE 
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}