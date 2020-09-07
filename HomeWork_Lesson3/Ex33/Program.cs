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




        // Обработка исключений и инициализация дробей
        static Fractions Init(int numerator, int denumerator)
        {
            bool checkException;
            Fractions fraction = null;

            do
            {
                checkException = false;
                try
                {
                    fraction = new Fractions(numerator, denumerator);
                }
                catch (ArgumentException ex)
                {
                    checkException = true;
                    Console.WriteLine("Ошибка: " + ex.Message);
                    Console.Write("Повторно введите знаменатель дроби: ");
                    denumerator = CheckInt();
                }
            } while (checkException);

            return fraction;
        }

        static int CommonDenomin(int a, int b)
        {
            int comDen;

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }

            return comDen = a + b;
        }



        static void Main(string[] args)
        {
            Console.Write("Введите числитель первой дроби: ");
            int n1 = CheckInt();
            Console.Write("Введите знаминатель первой дроби: ");
            int d1 = CheckInt();
            Console.Write("\nВведите числитель второй дроби: ");
            int n2 = CheckInt();
            Console.Write("Введите знаминатель второй дроби: ");
            int d2 = CheckInt();

            Fractions fraction1 = Init(n1, d1);
            Fractions fraction2 = Init(n2, d2);

            Console.WriteLine($"\nПервая дробь: {fraction1}");
            Console.WriteLine($"Вторая дробь: {fraction2}");

            Console.WriteLine($"\nСумма двух дробей: {Fractions.Sum(fraction1, fraction2)}");
            Console.WriteLine($"\nРазность двух дробей: {Fractions.Minus(fraction1, fraction2)}");
            Console.WriteLine($"\nРезультат умножения двух дробей: {Fractions.Multi(fraction1, fraction2)}");
            Console.WriteLine($"\nРезультат деления двух дробей: {Fractions.Division(fraction1, fraction2)}");



            Console.ReadKey();
        }
    }
}
