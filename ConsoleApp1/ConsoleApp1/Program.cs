using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            const double a = 5;
            const double b = 7;
            double s, sum, g, gCos;
            s = (a * b) / 2 * Math.Sin(90 * Math.PI / 180);
            sum = Math.Pow(a, 2) + Math.Pow(b, 2);
            g = Math.Sqrt(sum);
            gCos = Math.Sqrt(sum) - 2 * a * b * Math.Cos(90 * Math.PI / 180);

            Console.WriteLine("Площадь треугольника равна " + s);
            Console.WriteLine("Длина гипотенузы согласно теоремы пифагора  равна " + g);
            Console.WriteLine("Длина гипотенузы согласно теореме косинусов равна " + gCos);
            Console.ReadKey();
        }
    }
}
