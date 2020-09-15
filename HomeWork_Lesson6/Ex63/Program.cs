using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Морозов Михаил
// Переделать программу Пример использования коллекций для решения следующих задач:

// а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
// б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
// в) отсортировать список по возрасту студента;
// г) * отсортировать список по курсу и возрасту студента;

namespace Ex63
{
    class Program
    {
        // Метод для сравнения строк
        static int AgeCompare(ClassStudent st1, ClassStudent st2)
        {
            return String.Compare(st1.age.ToString(), st2.age.ToString());
        }



        // Распределение студентов по курсам 
        public static void ListStudent(Dictionary<int, int> cousreFrequency)
        {
            ICollection<int> keys = cousreFrequency.Keys;

            String result = String.Format($"Курс     Количество студентов\n");
            foreach (int key in keys)
                result += String.Format($"{key,-10} {cousreFrequency[key],-10}\n");
            Console.WriteLine($"\n{result}");
        }


        static int CourceAndAgeCompare(ClassStudent st1, ClassStudent st2)
        {
            if (st1.course > st2.course)
                return 1;
            if (st1.course < st2.course)
                return -1;
            if (st1.age > st2.age)
                return 1;
            if (st1.age < st2.age)
                return -1;
            return 0;
        }





        static void Main(string[] args)
        {
            int studKurs1 = 0;
            int studKurs2 = 0;

            List<ClassStudent> list = new List<ClassStudent>();

            //Создаем список студентов
            Dictionary<int, int> cousreFrequency = new Dictionary<int, int>();
            StreamReader sr = new StreamReader("students_6.csv");

            // Пока не конец потока
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new ClassStudent(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    // Подсчитываем количество учащихся пятого и шестого курсов
                    if (int.Parse(s[6]) == 5) studKurs1++; else if (int.Parse(s[6]) == 6) studKurs2++;
                    if (int.Parse(s[5]) > 17 && int.Parse(s[5]) < 21)
                    {
                        if (cousreFrequency.ContainsKey(int.Parse(s[6])))
                            cousreFrequency[int.Parse(s[6])] += 1;
                        else
                            cousreFrequency.Add(int.Parse(s[6]), 1);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - для выхода");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();


            Console.WriteLine($"Всего студентов: {list.Count}");
            Console.WriteLine($"Учащихся пятого курса: {studKurs1}");
            Console.WriteLine($"Учащихся шестого курса: {studKurs2}");
            Console.WriteLine("\nСтуденты в возрасте от 18 до 20 лет, с распределением по курсам обучения");

            ListStudent(cousreFrequency);

            list.Sort(new Comparison<ClassStudent>(AgeCompare));
            Console.WriteLine("Сортированный список студентов по возрасту: ");
            foreach (var v in list) Console.WriteLine($"{v.firstName} {v.age}");

            list.Sort(new Comparison<ClassStudent>(CourceAndAgeCompare));
            Console.WriteLine("\nСортированный список студентов по курсу и возрасту возрасту: ");
            foreach (var v in list) Console.WriteLine($"{v.firstName}, курс {v.course}, возраст {v.age}");


            Console.ReadKey();
        }
    }
}
