using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Морозов Михаил
// Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
// а) Вывести только те слова сообщения,  которые содержат не более n букв.
// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
// в) Найти самое длинное слово сообщения.
// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
// д) *** Создать метод, который производит частотный анализ текста.
//   В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает 
//   сколько раз каждое из слов массива входит в этот текст.Здесь требуется использовать класс Dictionary.

namespace Ex52
{
    // Статический класс Message для обработки текста
    static class Message
    {
        static public string message;

        // Метод загрузки обрабатываемого текста из файла
        static Message()
        {
            // ReadAllText считывает все содержимое файла до конца, а затем закрывает его
            message = File.ReadAllText("text_message.txt");
        }


        /// <summary>
        /// Вывод на экран только тех слов, длина которых не менее n букв
        /// </summary>
        /// <param name="lenWord"> длина слова </param>
        static public void GetWordByLength(int lenWord)
        {
            string[] parts = SplitPartsMessage();

            // Вывод на экран результат разделения
            //for (int i = 0; i < parts.Length; i++)
            //{ Console.WriteLine(parts[i]); }

            // Перебираем "разрезанный" массив и ищем там слова нужносго размера
            Console.WriteLine($"Слова, содержащие не менее {lenWord} букв: ");
            foreach (string word in parts)
            {
                if (word == "") // Игнорируем пробелы
                    continue;
                if (word.Length <= lenWord)
                    Console.Write($"{word} ");
            }

        }



        /// <summary>Производит частотный анализ текста</summary>
        /// <param name="words">Массив слов</param>
        /// <param name="text">Текст</param>
        static public void FreqAnalys(string[] words, string text)
        {

            string[] textWords = SplitPartsMessage(); // разрезаем текст на слова
            Dictionary<string, int> wordFreq = new Dictionary<string, int>();

            // Выборка нужных слов из текста (предварительно порезанного на слова)
            foreach (string word in words)
            {
                foreach (string wordInText in textWords)
                {
                    if (word == "")
                        continue;
                    if (wordInText == word)
                    {
                        if (word == "")
                            continue;
                        if (wordFreq.ContainsKey(word))
                            wordFreq[word] += 1;
                        else
                            wordFreq.Add(word, 1);
                    }
                }
            }
            // Получаем набор ключей
            ICollection<string> keys = wordFreq.Keys;

            //Форматированный вывод заголовка
            String result = String.Format("{0,-10} {1,-10}\n", "Слово", "Частота появления");


            //Подсчет числа слов
            foreach (string key in keys)
            {
                result += String.Format("{0,-10} {1,-10:N0}\n", key, wordFreq[key]);
            }

            // Вывод результата
            Console.WriteLine($"\n{result}");
        }



        /// <summary>
        /// Метод для разделения исходного теста на слова
        /// и добавления их в новый массив
        /// </summary>
        /// <returns></returns>
        private static string[] SplitPartsMessage()
        {
            char[] div = { ' ', ',', '.', '-', '!', '\n', '\t' }; // Создаем массив разделителей
            string[] parts = message.Split(div); // Разбиваем строку на части
            return parts;
        }



        /// <summary>
        /// Удаление слов, оканчивающихся на выбранную букву
        /// </summary>
        /// <param name="delChar"> Искомая буква </param>
        static public void DeleteWordByChar(char delChar)
        {
            string[] parts = SplitPartsMessage();

            Console.WriteLine($"\n\nСлова, заканчивающиеся на букву {delChar}, которые будут удалены:");

            foreach (string word in parts)
            {
                if (word == "")
                    continue;

                if (word[word.Length - 1] == delChar)
                {
                    Console.Write($"{word} ");
                    message.Replace(word, "");
                }


            }

        }



        /// <summary>
        /// Определение самого длинного слова
        /// </summary>
        /// <returns></returns>
        static public string FindMaxWord()
        {
            string[] parts = SplitPartsMessage();

            string maxWord = parts[0]; // Возвращаемое самое длинное слово
            int max = parts[0].Length; // Сравнительная длина слова, для определения самого длинного слова в цикле

            foreach (string word in parts)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    maxWord = word;
                }
            }

            return maxWord;
        }




        /// <summary>
        /// Составление строки из самых длинных слов текста
        /// </summary>
        /// <returns></returns>
        static public StringBuilder GetLongWords()
        {
            string[] longString = SplitPartsMessage(); // разрезаем текст на слова

            StringBuilder result = new StringBuilder(); // Метод StringBuilder - для формирования новой строки

            int max = FindMaxWord().Length; // Метод поиска самого длинного слова
            
            // Перебор слов и составление новой строки
            foreach (string word in longString)
            {
                if (word.Length == max)
                {
                    result.Append($"{word} "); // добавление нового слова
                }
            }
            return result;
        }


    }
}
