using System;
using System.Globalization;

namespace CalculoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;
            double p, areaX, areaY;

            Console.WriteLine("Quais as medidas do triângulo X?");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Quais as medidas do triângulo Y?");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (xA + xB + xC) / 2.0;
            areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC)); // Math.Sqrt() usado para fazer a raiz quadrada
         
            p = (yA + yB + yC) / 2.0;
            areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture)); // "F4" significa que a variável terá 4 casas decimais: 5.0000
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("A área do triângulo X é maior");
            } else if (areaX < areaY)
            {
                Console.WriteLine("A área do triângulo Y é maior");
            } else
            {
                Console.WriteLine("Os triângulos têm áreas iguais!");
            }
        }
    }
}
