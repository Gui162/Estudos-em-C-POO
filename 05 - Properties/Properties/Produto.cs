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

        // PROPIETIES

        // ====================================NOME=================================================
        public string Nome
        {
            get { return _nome; }

            set {
                if (value != null && value.Length > 3)
                {
                    _nome = value;
                }
            }
        }

        /* public string GetNome()
         {
             return _nome;
         }
         public void SetNome(string nome)
         {
             if (nome != null && nome.Length > 3)
             {
                 _nome = nome;
             }
         }*/

        // =======================================PRECO===============================================
        public double Preco
        {
            get { return _preco; }
        }
        /*
        public double GetPreco()
        {
            return _preco;
        }
        */

        // ====================================QUANTIDADE============================================

        public int Quantidade
        {
            get { return _quantidade; }
        }
        /*
        public int GetQuantidade()
        {
            return _quantidade;
        }
        */

        // ===========================================================================================

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