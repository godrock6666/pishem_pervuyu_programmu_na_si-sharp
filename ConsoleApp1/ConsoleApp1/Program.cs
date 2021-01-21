using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int value = 1;//ONE
            for (int i = 0; i < 20; i++)
                Console.Write($"{value += 3} ");
            string str; //TWO
            do
                str = Console.ReadLine();
            while (str != "Root");
            Random sc = new Random();//THREE
            int[] mas = new int[5];
            int[] mas_1 = new int[mas.Length];
            int[] mas_2 = new int[mas.Length];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = sc.Next(0, 10);
                mas_1[i] = sc.Next(0, 10);
                mas_2[i] = mas[i] + mas_1[i];
                Console.WriteLine(mas_2[i]);



            }
        }
    }
}
