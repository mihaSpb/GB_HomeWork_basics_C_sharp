using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Морозов Михаил
//* Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
// Например:
// badc являются перестановкой abcd.


namespace Ex53
{
    class Program
    {

        /// <summary>Метод определяет, является ли одна строка перестановкой другой</summary>
        /// Переводим строки в массивы, а затем переставляем символы по алфавиту и сравниваем две строки
        /// <param name="str1">Первая строка</param>
        /// <param name="str2">Вторая строка</param>
        /// <returns></returns>
        static bool ComparisionString(string str1, string str2)
        {

            // Перевод строк в нижний регистр
            str1 = str1.ToLower();
            str2 = str2.ToLower();

            // Переменные для строк, в которых символы выстроены по алфавиту
            // При первом обращении - присврение нулевого символа исходной строки
            string news1 = str1[0].ToString();
            string news2 = str2[0].ToString();


            // Обработка первой строки. В параметры метода попадает упорядоченная строка 1 и
            // следующий символ из исходной строки 1.
            for (int i = 1; i < str1.Length; i++)
                AlphabetString(ref news1, str1[i]);


            for (int i = 1; i < str2.Length; i++)
               AlphabetString(ref news2, str2[i]);

            // Сравнение двух строк 
            if (news1.Equals(news2))
                    return true;
            else
                return false;
        }



        /// <summary>Метод вставляет новый символ в строку в алфавитном порядке</summary>
        /// <param name="s">Строка</param>
        /// <param name="ch">Новый символ</param>
        static void AlphabetString(ref string s, char ch)
        {
            // Сравнивается i-й символ в перестраиваемой строке со следующим символом из исходной строки 
            for (int i = 0; i < s.Length; i++)
            {
                // Если значение i-го символа в перестраиваемой строке больше, чем значение ch, то ch вставляется перед i-м символом
                if (s[i] > ch)
                {
                    s = s.Insert(i, ch.ToString());
                    break;
                }
                else
                    if (i == s.Length - 1)
                    {
                        s += ch.ToString();
                        break;
                    }
            }

        }



        static void Main(string[] args)
        {
            // True
            string firstString = "kjdsbjdsueaeescs";
            string secondString = "eskajedsucdjsebs";

            // False
            //string firstString = "kjdsbjdsueaewescs";
            //string secondString = "eskajedsucdjsebs";

            Console.WriteLine("Является ли одна строка перестановкой другой.");

            Console.WriteLine($"Проверим следующие строки: {firstString} и {secondString}");

            if (ComparisionString(firstString, secondString) == true && ComparisionString(firstString, secondString) == true)
                Console.WriteLine($"Строки являются перестановками друг друга.");
            else
                Console.WriteLine($"Строки состоят из разных символов.");

            Console.ReadKey();
        }
    }
}
