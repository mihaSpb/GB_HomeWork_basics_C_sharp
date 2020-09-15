using System;
using System.Collections.Generic;

// Морозов Михаил
// Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
// Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).

namespace Ex61
{
    /// <summary>
    /// Делегат с сигнатурой методов типа double (double, double).
    /// </summary>
    /// <param name="a"></param>
    /// <param name="x"></param>
    /// <returns></returns>
    public delegate double Func(double a, double x);


    class Program
    {

        /// <summary>
        /// Метод для расчета функции a* x^2
        /// </summary>
        /// <param name="a">параметр а</param>
        /// <param name="x">параметр х</param>
        /// <returns></returns>
        public static Double FuncDemo (double a, double x)
        {


            return a * Math.Pow(x,2.0);
        }

        /// <summary>
        /// Метод для расчета функции a* sin(x)
        /// </summary>
        /// <param name="a"> параметр а </param>
        /// <param name="x"> параметр х </param>
        /// <returns></returns>
        public static Double FuncSin(double a, double x)
        {
            return a * Math.Sin(x);
        }


        static void Plot(List<Func> temp, int start, int end)
        {

            for (int i = 0; i < temp.Count; i++)
            {
                for (int x = start; x <= end; x++)
                {
                    Console.WriteLine($"f({x,2}) = {temp[i](x),5}");
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }




        static void Main(string[] args)
        {
            List<Func> funcs = new List<Func>() {new Func(FuncDemo), new Func(FuncSin)};

            Plot(funcs, 5, 10);

            Console.ReadKey();
        }
    }
}
