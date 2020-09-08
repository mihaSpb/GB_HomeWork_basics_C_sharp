using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Морозов Михаил
// Реализуйте задачу 1 в виде статического класса StaticClass;
// а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
// б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
// в)** Добавьте обработку ситуации отсутствия файла на диске.


namespace Ex42
{
    class Program
    {
        static void Main()
        {

            int arrLength = 20;
            int[] arr = new int[arrLength];  // Массив из 20-ти элементов  
            int result = 0; // Переменная для хранения количества пар элементов массива, которые делятся на три
            string fileName = "customArray.txt";

            Random arrNum = new Random(); // Рандомайзер для заполнения массива

            Console.Write("Исходный массив случайных чисел:\n");

            // Заполнение массива
            for (int i = 0; i < arrLength; i++)
            {
                arr[i] = arrNum.Next(-10000, 10001);
                Console.Write($"{arr[i]} ");
            }


            // Вызов метода из статического метода - имя класса.имя метода
            result = OneDimArray.GetCountPair(arr, arrLength);

            Console.WriteLine($"\n\nКоличество пар элементов массива, в которых только одно число делится на три: {result}");

            // Считывание массива из файла и вывод его на экран
            int s = OneDimArray.LoadFileArray(fileName);
            //Console.WriteLine(s);

            Console.ReadKey();
        }

    }
}
