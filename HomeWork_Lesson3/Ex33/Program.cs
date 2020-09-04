using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex33
{
    // Морозов Михаил
    // 3. * Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
    // Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
    // Написать программу, демонстрирующую все разработанные элементы класса.

    // ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
    // ArgumentException("Знаменатель не может быть равен 0");
    // Добавить упрощение дробей.

    class Program
    {


        // Функция проверки ввода целого числа без обработки исключений
        static int CheckInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Введите целое число. Пожалуйста, повторите ввод: ");
                else return x;
        }



        static void Main(string[] args)
        {
            Console.Write("Введите числитель первой дроби: ");
            int n1 = CheckInt();
            Console.Write("Введите знаминатель первой дроби: ");
            int d1 = CheckInt();
            Console.Write("Введите числитель второй дроби: ");
            int n2 = CheckInt();
            Console.Write("Введите знаминатель второй дроби: ");
            int d2 = CheckInt();



            Console.ReadKey();
        }
    }
}
