using System;

namespace ConsoleApp1
{
    public class TV
    {
        public static int Channels;
        public static int Channel = 1;

    }

    class Program
    {

        static void Main(string[] args)
        {
            string s = "Сегодня мы с вами рассмотрели, как работать со строками" +
                " в Си-шарп. Были описаны основные операторы и методы, которые используются для работы со строками";
            s = s.Split('.')[1];
            s = s.Substring(1, s.IndexOf(",") - 1);
            Console.WriteLine(s);
        }
    }
}