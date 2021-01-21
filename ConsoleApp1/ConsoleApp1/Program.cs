using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int h, g;
            Console.WriteLine("Укажите количество забитых голов хозяевами");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите количество забитых голов гостями");
            g = Convert.ToInt32(Console.ReadLine());
            if (h > g) Console.WriteLine("Победили хозяева");
            else if (h < g) Console.WriteLine("Победили гости");
            else Console.WriteLine("Ничья");
        }
    }
}
