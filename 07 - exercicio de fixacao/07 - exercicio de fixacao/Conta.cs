using System.Globalization;

namespace _07___exercicio_de_fixacao
{
    internal class Conta
    {
        //atributos
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        // construtores

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double depositoinicial) : this(numero, titular)
        {
            Deposito(depositoinicial);

            // muito melhor chamar o metodo de deposisto pois se no furuto as regras de deposistos forem alteradas o deposito inicial tambem vai ser alterado
            // se utilizar Salto = saldo
            // se em algum momento a regra de deposito for alterada esse deposito inicial nao vai ser aplicado a nova regra dificicultando a manutencao
        }


        //to string 
        public override string ToString()
        {
            return "Conta"
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        // metodos

        public void Deposito (double quantia)
        {
            Saldo += quantia;
        }

        public void Saque (double quantia)
        {
            Saldo -= 5; // taxa de saque 
            Saldo -= quantia;
        }
        
    }
}
