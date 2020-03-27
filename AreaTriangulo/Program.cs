using System;
using System.Globalization;

namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            double pX, pY = 0.0;
            double areaX, areaY = 0.0;

            Console.WriteLine("Entre com os lados da medidas do triangulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com os lados da medidas do triangulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            pX = (x.A + x.B + x.C) / 2;

            pY = (y.A + y.B + y.C) / 2;

            areaX = Math.Sqrt(pX*(pX - x.A)*(pX - x.B)*(pX - x.C));

            areaY = Math.Sqrt(pY * (pY - y.A) * (pY - y.B) * (pY - y.C));

            Console.WriteLine("Área de X = {0}", areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = {0}", areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior Area X");
            }
            else
            {
                Console.WriteLine("Maior Area Y");
            }



        }
    }
}
