using System;
using System.Globalization;

namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double aX, bX, cX, aY, bY, cY  = 0.0;
            double pX, pY = 0.0;
            double areaX, areaY = 0.0;

            Console.WriteLine("Entre com os lados da medidas do triangulo X");
            aX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com os lados da medidas do triangulo Y");
            aY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            pX = (aX + bX + cX) / 2;

            pY = (aY + bY + cY) / 2;

            areaX = Math.Sqrt(pX*(pX - aX)*(pX - bX)*(pX - cX));

            areaY = Math.Sqrt(pY * (pY - aY) * (pY - bY) * (pY - cY));

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
