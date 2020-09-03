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

        struct Complex
    {
        public double im;
        public double re;



        /// <summary> Метод вычитания комплексных чисел </summary>
        /// <param name="num">Комплексное число для разности</param>
        /// <returns></returns>
        public Complex Subtrac(Complex num)
        {
            Complex y;
            y.im = im - num.im;
            y.re = re - num.re;
            return y;
        }




    }




    class Program
    {
        static void Main(string[] args)
        {



        }
    }
}
