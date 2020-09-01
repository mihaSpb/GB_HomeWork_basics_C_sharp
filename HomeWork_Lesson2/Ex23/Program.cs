using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23
{

    //Морозов Михаил
    //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Введите произвольное целое число (0 заканчивает ввод чисел):");

            int sum = 0;
            int a = int.Parse(Console.ReadLine());

            while (a != 0)
            {
                if (a > 0 && a % 2 != 0)
                {
                   sum = sum + a;
                }
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Сумма всех введенных нечетных положительных чисел: {sum}");




            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
