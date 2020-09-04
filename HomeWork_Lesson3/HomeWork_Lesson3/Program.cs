using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31
{
    // Морозов Михаил
    // 1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры;

    // б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;


    class Program
    {

        static void Main(string[] args)
        {
            // Сложение
            Console.WriteLine("Сложение комплексных чисел");
            Complex z1 = new Complex(re: 25, im: -10);
            Console.WriteLine($"Первое комплексное число: {z1}");

            Complex z2 = new Complex(4, 20);
            Console.WriteLine($"Второе комплексное число: {z2}");

            // Операция суммирования двух комплексных чисел
            Complex z3 = z1 + z2;
            Console.WriteLine($"Результат сложения комплексных чисел: {z3}");


            // Вычитание двух комплексных чисел
            Console.WriteLine("\nВычитание комплексных чисел");

            Complex sub1 = new Complex
            {
                A = 0,
                B = 20
             };
            Console.WriteLine($"Первое комплексное число: {sub1}");

            Complex sub2 = new Complex
            {
                A = 5,
                B = -15
            };
            Console.WriteLine($"Второе комплексное число: {sub2}");

            Complex sub3 = sub1 - sub2;
            Console.WriteLine($"Результат вычитания комплексных чисел: {sub3}");




            // Умножение двух комплексных чисел
            Console.WriteLine("\nУмножение комплексных чисел");

            Complex multi1 = new Complex
            {
                A = 30,
                B = 20
            };
            Console.WriteLine($"Первое комплексное число: {multi1}");

            Complex multi2 = new Complex
            {
                A = -5,
                B = 100
            };
            Console.WriteLine($"Второе комплексное число: {multi2}");

            Complex multi3 = multi1 * multi2;
            Console.WriteLine($"Результат умножения комплексных чисел: {multi3}");

            Console.ReadKey();
        }
    }
}
