using System;
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Исходный текст:");
            Console.WriteLine($"\n{Message.message}\n");


            // вывод только тех слов, которые содержат не более n букв
            Message.GetWordByLength(3);

            // Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            Message.DeleteWordByChar('а');

            Console.WriteLine($"\n\nСамое длинное слово в тексте: {Message.FindMaxWord()}");

            Console.WriteLine($"\nСтрока, составленная из самых длинных слов в тексте: {Message.GetLongWords()}");

            Console.WriteLine("\nЧастотный анализ текста: ");
            // Массив слов для частотношо анализа
            string[] arr = { "не", "в", "игра", "памяти", "он" };
            // Вызов метода частотного анализа
            Message.FreqAnalys(arr, Message.message);



            Console.ReadKey();
        }
    }
}
