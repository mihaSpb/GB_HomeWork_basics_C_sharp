using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex26
{
    // Морозов Михаил
    // 6. * Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
    // Хорошим называется число, которое делится на сумму своих цифр.Реализовать подсчет времени выполнения программы, используя структуру DateTime.

    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;

            int minNum = 1;
            int maxNum = 1000000000;
            //int maxNum = 11;
            int countNum = 0;
            bool goodNum = false;

            for (int i = minNum; i < maxNum; i ++)
            {
                goodNum = CheckGoodNum(i);
                if (goodNum)
                {
                    countNum++;
                }
            }



            Console.WriteLine($"Количество 'хороших' чисел: {countNum}");
            Console.WriteLine($"Затрачено времени на расчет: {DateTime.Now - start}");


            Console.WriteLine();
            Console.ReadKey();
        }



        static bool CheckGoodNum(int i)
        {
            int count = i;
            int sumNumChar = 0;
            while (count > 0)
            {
                sumNumChar += count % 10;
                count /= 10;
            }
            return i % sumNumChar == 0;

        }
    }
}
