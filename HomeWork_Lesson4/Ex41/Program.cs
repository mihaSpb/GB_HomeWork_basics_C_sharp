using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Морозов Михаил
// Дан целочисленный  массив из 20 элементов.Элементы массива  могут принимать  целые значения  от –10 000 до 10 000 включительно.
// Заполнить случайными числами.
// Написать программу, позволяющую найти и вывести количество пар элементов массива, 
// в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.
// Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 

namespace Ex41
{
    class Program
    {

        // Метод подсчета пар элементов массива, которые делятся на три.
        static int GetCountPair (int [] countArray, int legthCount)
        {
            int countPair = 0;

            for (int j = 0; j < legthCount - 1; j++)
            {
                if (countArray[j] % 3 == 0 & countArray[j + 1] % 3 != 0 | countArray[j] % 3 != 0 & countArray[j + 1] % 3 == 0)
                {
                    countPair++;
                    Console.Write($"\nпары, подпадающие под условия: {countArray[j]} {countArray[j + 1]}");
                }
            }
            return countPair;
        }



        static void Main(string[] args)
        {

            int arrLength = 20;
            int[] arr = new int[arrLength];  // Массив из 20-ти элементов  
            int result = 0; // Переменная для хранения количества пар элементов массива, которые делятся на три

            Console.Write("Исходный массив случайных чисел:\n");

            // Заполнение массива случайными числами
            FillingArray(arrLength, arr);

            result = GetCountPair(arr, arrLength);

            Console.WriteLine($"\n\nКоличество пар элементов массива, в которых только одно число делится на три: {result}");

            Console.ReadKey();

        }


        /// <summary>
        ///  Метод для заполнения массива, с использованием рандомайзера
        /// </summary>
        /// <param name="arrLength">Размер массива</param>
        /// <param name="arr"> Массив для заполнения</param>
        private static void FillingArray(int arrLength, int[] arr)
        {

            Random arrNum = new Random(); // Рандомайзер для заполнения массива
            for (int i = 0; i < arrLength; i++)
            {
                arr[i] = arrNum.Next(-10000, 10001);
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
