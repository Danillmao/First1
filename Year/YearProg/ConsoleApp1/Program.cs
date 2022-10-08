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
            if (a % 4 == 0)
            {
                Console.WriteLine("Високосный год");
            }
            else
            {
                Console.WriteLine("Невисокосный год");
            }

        }
    }
}
