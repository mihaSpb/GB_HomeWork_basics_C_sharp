using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Морозов Михаил
// Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
//а) Сделать меню с различными функциями и представить пользователю выбор, 
//    для какой функции и на каком отрезке находить минимум.
//    Использовать массив(или список) делегатов, в котором хранятся различные функции.
//б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.
//    Пусть она возвращает минимум через параметр(с использованием модификатора out). 


namespace Ex62
{

    /// <summary>
    /// Делегат функции с сигнатурой double, double
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public delegate double Function(double x);


    class Program
    {
        /// <summary>
        /// Метод производит расчёт значения переданной функции и записывает в файл двоичным потоком
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <param name="start">Начальное значение аргумента</param>
        /// <param name="end">Конечное значение агрумента</param>
        /// <param name="F">Делегат функции</param>
        public static void SaveFunc(string fileName, double start, double end, Function F)
        {
            // Запускае поток, создаем новый файл с именем fileName (если он уже есть - перезапись)
            // доступ к файлу - запись
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            // бинарный поток данных
            BinaryWriter binaryWritter = new BinaryWriter(fileStream);

            // запись данных в файл
            while (start <= end)
            {
                binaryWritter.Write(F(start));
                start ++;
            }

            // закрываем потоки
            binaryWritter.Close();
            fileStream.Close();
        }


        /// <summary>
        /// Функция возвращает массив значений из файла и находит минимальное
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <param name="min">Переменная минимума с ключевым словом out</param>
        /// <returns></returns>
        public static double[] Load(string fileName, out double min)
        {
            // Открываем потоки
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);

            // новый массив для считанных из файла данных
            double[] array = new double[fileStream.Length / sizeof(double)];
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fileStream.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = binaryReader.ReadDouble();
                array[i] = d;
                if (d < min) min = d;
            }
            // закрываем потоки
            binaryReader.Close();
            fileStream.Close();

            return array;
        }


        #region Набор фнкций для расчета

        /// <summary>Функция извлечения квадратного корня</summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double mySqrt(double x)
        {
            return Math.Sqrt(x);
        }


        /// <summary>Функция возведения в квадрат</summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double secondPow(double x)
        {
            return Math.Pow(x, 2);
        }

        /// <summary>Функция возведения в третью степень</summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double thirdPow(double x)
        {
            return Math.Pow(x, 3);
        }



        /// <summary>Функция косинуса</summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double myCos(double x)
        {
            return Math.Cos(x);
        }

        #endregion


        /// <summary>
        /// Метод получает значения начала отрезка и конца из одной строки
        /// </summary>
        /// <param name="start">Начало отрезка</param>
        /// <param name="end">Конец отрезка</param>
        static void GetInterval(out double start, out double end)
        {
            // убираем пробел между введенными значениями
            string[] interval = Console.ReadLine().Split(' ');
            // начало и конец интервала
            start = double.Parse(interval[0]);
            end = double.Parse(interval[1]);
        }

        /// <summary
        /// >Метод выводит на экран значение функции и её аргумента
        /// </summary>
        /// <param name="start">Начальное значенеи аргумента</param>
        /// <param name="end">Конечное значение аргумента</param>
        /// <param name="values">Массив значений функции</param>
        static void PrintResults(double start, double end, double[] values)
        {
            Console.WriteLine($"Значение Х     Значение Y");
            int index = 0;
            while (start <= end)
            {
                Console.WriteLine($"{start, 5} {Math.Round(values[index], 3 ), 15}");
                start ++;
                index++;
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        /// <summary>
        /// Метод проверяет ввод целочисленного значения при выборе номера функции для расчета
        /// Введенное значение не должно превышать число доступных функций
        /// </summary>
        /// <param name="max">Максимальное значение, которое может ввести пользователь</param>
        /// <returns></returns>
        static int GetInt(int max)
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x) || x > max)
                    Console.Write($"Заданная функция отсутствует в списке доступных (требуется числовое значение от 0 до {max})." +
                        $"\nПожалуйста повторите ввод: ");
                else return x;
        }



        static void Main(string[] args)
        {
            // Создаем список доступных для расчета функций
            List<Function> functions = new List<Function> { new Function(mySqrt), new Function(secondPow), new Function(thirdPow), new Function(myCos) };

            Console.WriteLine($"Выберите функцию для расчета:");
            Console.WriteLine($"1 f(x)=y^1/2");
            Console.WriteLine($"2 f(x)=y^2");
            Console.WriteLine($"3 f(x)=y^3");
            Console.WriteLine($"4 f(x)=Cos(y)");

            // Выбор функции и проверка правильности выбора
            int userChoose = GetInt(functions.Count);

            Console.WriteLine($"Задайте отрезок для нахождения минимума в формате 'х1 х2' (где х1 > х2):");

            double start = 0;
            double end = 0;
            GetInterval(out start, out end);


            // Запись данных в файл
            SaveFunc("data.bin", start, end, functions[userChoose - 1]);
            double min = double.MaxValue;

            Console.WriteLine($"Получены следующие значения функции: ");

            PrintResults(start, end, Load("data.bin", out min));
            Console.WriteLine($"Минимальное значение функции равняется: {Math.Round( min, 2)}");



            Console.ReadKey();
        }
    }
}
