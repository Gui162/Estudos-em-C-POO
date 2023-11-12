using System;


namespace utilizandoPOO01
{
    internal class Triangulo
    {
        /* atributos da classe */

        public double A;
        public double B;
        public double C;

        /* colocando os metodos */

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }
    }
}
