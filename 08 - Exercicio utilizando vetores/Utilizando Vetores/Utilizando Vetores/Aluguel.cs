
namespace Utilizando_Vetores
{
    internal class Aluguel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int NumeroQuarto { get; set; }


        public override string ToString()
        {
            return NumeroQuarto + ": " + Nome + ", " + Email;
        }
    }
}
