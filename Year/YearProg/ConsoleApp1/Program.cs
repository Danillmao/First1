using System;

namespace Year
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int a;
            Console.WriteLine("Введите год");

            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            if (a % 4 == 0 & a / 400 != 0 || a / 100 == 0)
            {
                Console.WriteLine("Високосный год interface");
            }
            else
            {
                Console.WriteLine("Невисокосный год interface");
            }

        }
    }
}
