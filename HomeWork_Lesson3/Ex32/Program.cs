using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    // Морозов Михаил
    // 2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
    // Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse;

    // б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
    // При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;

namespace Ex32
{
    class Program
    {

        // Вывод списка чисел
        private static void ListNum(List<int> num)
        {
            for (int i = 0; i < num.Count; i++)
            {
                Console.Write($"{num[i]}, ");

            }
        }

        // Функция проверки ввода с обработкой исключений
        static int CheckExInput()
        {
            int res = 0;
            bool excCatch;
            do
            {
                excCatch = false;
                try
                {
                    Console.Write("Введите число (0 заканчивает ввод чисел):");
                    res = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    excCatch = true;
                    string message = ex.Message;
                    Console.WriteLine($"Возникло исключение: {message}");
                    Console.WriteLine("Пожалуйста, повторите ввод!");
                }

            } while (excCatch);
            return res;
        }



        static void Main(string[] args)
        {

            int sum = 0;
            // Создание списка введенных значений
            List<int> numList = new List<int>();

            while (true)
            {
                int num = CheckExInput();
                if (num == 0)
                {
                    break;
                }
                else if (num > 0 && num % 2 == 1)
                {
                    numList.Add(num);
                    sum++;
                }
            }

            // Вывод конечных данных
            Console.WriteLine($"Сумма всех введенных нечетных положительных чисел: {sum}");
            Console.Write("Список чисел: ");
            ListNum(numList);

            Console.ReadKey();
        }
    }
}

