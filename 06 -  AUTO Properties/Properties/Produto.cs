using System.Globalization;
namespace Course
{
    class Produto
    {
        // ATRIBUTOS

        private string _nome; // e privado pois tem uma properties la em baixo na linha 31
        public double Preco { get; private set; }  // auto properties (sao utilizadas para properties que nao necessitam de uma logia exclusiva)
        public int Quantidade { get; private set; } // auto properties (sao utilizadas para properties que nao necessitam de uma logia exclusiva)




        // CONSTRUTORES
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            // nomenclatura de atributos privados e minuscula e comecando com underline
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // GET & SET / PROPIETIES

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

        // =============================================================================================

        // METODOS DA CLASSE 
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
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}