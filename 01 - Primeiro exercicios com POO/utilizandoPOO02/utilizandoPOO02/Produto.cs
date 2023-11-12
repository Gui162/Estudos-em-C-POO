using System;
using System.Globalization;

namespace utilizandoPOO02
{
    internal class Produto
    {
        // Atributos
        public string Nome;
        public double Preco;
        public int Quantidade;

        // Metodos
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        /* ToString() em uma instância de uma classe, ele retorna uma REPRESENTACAO legível/de texto do objeto em forma de string.*/
        public override string ToString()
        {
            return Nome 
                + ", R$" 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " + Quantidade 
                + " Unidades, Total: R$" 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
