using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex25
{
    // Морозов Михаил
    // 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, 
    // набрать вес или все в норме;
    // б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.


    class Program
    {
        static void Main(string[] args)
        {
            string status;
            double mas;

            Console.Write("Введите Вашу массу тела в кг: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Ваш рост в метрах: ");
            double h = Convert.ToDouble(Console.ReadLine());

            status = StatusIMT(m, h);

            Console.WriteLine("Ваш ИМТ {0:F2}", IMT_I(m, h));

            switch (status)
            {
                case "more":
                    mas = m - NormIMT(h);
                    Console.WriteLine($"Вам нужно похудеть! На {Convert.ToInt32(mas)} кг.");
                    break;

                case "less":
                    mas = NormIMT(h) - m;
                    Console.WriteLine($"Ваш вес слишком низкий! Наберите {Convert.ToInt32(mas)} кг.");
                    break;

                default:
                    Console.WriteLine("Ваш вес в норме!");
                    break;
            }


            Console.WriteLine();
            Console.ReadKey();
        }

        private static string StatusIMT(int m, double h)
        {
            string status;
            if (IMT_I(m, h) > 25.0f)
            {
                status = "more";
            }

            else if (IMT_I(m, h) < 18.5f)
            {
                status = "less";
            }

            else
            {
                status = "ok";
            }

            return status;
        }

        static double IMT_I(int m, double h)
        {
            var I = m / (h * h);

            return I;
        }


        static double NormIMT (double h)
        {
            double normIMT = 21.75f; // Норм ИМТ - от 18,5 до 25 (среднее 21,75)
            var masNorm = normIMT * (h * h);

            return masNorm;
        }

    }
}
