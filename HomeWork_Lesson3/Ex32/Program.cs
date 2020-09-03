using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32
{
    // Морозов Михаил
    // 2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
    // Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse;

    // б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
    // При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;

    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            string str;
            // Создание списка введенных значений
            List<int> num = new List<int>();


            while (true)
            {
                Console.Write("Введите число (0 заканчивает ввод чисел):");


                // Проверка того, что введено именно целое число.
                if (Int32.TryParse(str = (Console.ReadLine()), out int a))
                {
                    if (a == 0)
                    {
                        break;
                    }
                    else if (a > 0 && a % 2 != 0)
                    {
                        num.Add(a);
                        sum += a;
                    }
                }
                else
                {
                    Console.WriteLine("Введите целое число!");
                }

            }

            // Вывод конечных данных
            Console.WriteLine($"Сумма всех введенных нечетных положительных чисел: {sum}");
            Console.Write("Список чисел: ");

            ListNum(num);

            Console.WriteLine();
            Console.ReadKey();
        }

        // Вывод списка чисел
        private static void ListNum(List<int> num)
        {
            for (int i = 0; i < num.Count; i++)
            {
                Console.Write($"{num[i]}, ");

            }
        }
    }
}
