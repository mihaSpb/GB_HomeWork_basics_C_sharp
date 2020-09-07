using System;
using ClassLibraryPause;

namespace DistanceXY
{
    class Distance
    {
        //  Морозов Михаил
        //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по 
        //    формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, 
        //    используя спецификатор формата .2f(с двумя знаками после запятой);
        //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

        static double DistanceXY(double x1, double x2, double y1, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }




        static void Main(string[] args)
        {

            Console.WriteLine("{0:F2}", DistanceXY(5,10,10,20));

            Class1.Pause("Нажмите на любую кнопку...");
        }
    }
}
