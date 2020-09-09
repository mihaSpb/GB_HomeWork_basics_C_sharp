using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex42
{

    /// <summary>
    /// Статический класс - содержит статический метод, который принимает в себя массив и возвращает результат (количество пар 
    /// элементов, в которой хоть один из элементов делится на 3).
    /// </summary>
    static class OneDimArray
    {
        // Массив для заполнения из файла
        public static int myArraySise;
        public static int[] myArray = new int[myArraySise];


        // Метод подсчета пар элементов массива, которые делятся на три
        public static int GetCountPair(int[] countArray, int legthCount)
        {
            int countPair = 0;

            for (int j = 0; j < legthCount - 1; j++)
            {
                if (countArray[j] % 3 == 0 & countArray[j + 1] % 3 != 0 | countArray[j] % 3 != 0 & countArray[j + 1] % 3 == 0)
                {
                    countPair++;
                   // Console.Write($"\nпары, подпадающие под условия: {countArray[j]} {countArray[j + 1]}");
                }
            }
            return countPair;
        }



        // Считываем массив из файли и возвращаем массив целых числел.
        public static int LoadFileArray(string nameFile)
        {
            int size = 0;
            int[] arrayTemp = new int[size];

            StreamReader stremRead = new StreamReader(nameFile);

            var arr = stremRead.ReadLine().Split(',');

            foreach (var item in arr)
            {
                int t;
                var res = int.TryParse(item, out t);

                if (res) Add(t);
            }

            stremRead.Close();

            for (int j = 0; j < size - 1; j++)
            {

              Console.Write($"\nмассив из файла: {arrayTemp[j]}");
            }

            return arrayTemp[size];

        }


        // Расширение размера массива при заполнении его из файла
        static void Add(int item)
        {
            if (myArray.Length <= myArraySise) Array.Resize(ref myArray, myArray.Length * 2);
            myArray[myArraySise++] = item;
        }

    }
}
