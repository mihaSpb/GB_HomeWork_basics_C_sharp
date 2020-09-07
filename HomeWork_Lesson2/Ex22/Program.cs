using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex22
{

    //Морозов Михаил
    //2. Написать метод подсчета количества цифр числа.

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите произвольное целое число: ");
            string str = (Console.ReadLine());
            int a = str.Length;
            Console.WriteLine(a);


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
