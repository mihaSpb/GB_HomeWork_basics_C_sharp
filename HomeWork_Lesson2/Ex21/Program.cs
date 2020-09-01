using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex21
{
    //Морозов Михаил
    //1. Написать метод, возвращающий минимальное из трех чисел.

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Первое число = {a} второе число = {b} третье число = {c}");

            int min;

            min = CheckMin(a, b, c);

            Console.WriteLine($"Минимальное число  {min}");
            Console.ReadKey();

        }

        private static int CheckMin(int a, int b, int c)
        {
            int min;
            if (a < b && a < c)
            {
                min = a;
            }

            else if (c < b)
            {
                min = c;
            }

            else
            {
                min = b;
            }

            return min;
        }
    }
}
