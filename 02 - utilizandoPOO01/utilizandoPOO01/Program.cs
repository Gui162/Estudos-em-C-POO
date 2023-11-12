using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace utilizandoPOO01
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("entre com as medidas do triangulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("entre com as medidas do triangulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine($"Area de x = {areaX:F4}");
            Console.WriteLine($"Area de y = {areaY:F4}");
            if (areaX > areaY)
            {
                Console.WriteLine("Maior Area: X");
            }
            else
            {
                Console.WriteLine("Maior Area: Y");
            };

        }
    }
}