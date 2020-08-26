using System;
using ClassLibraryPause;

namespace Anketa
{
    class Anketa
    {
        //Морозов Михаил
        //Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). 
        //В результате вся информация выводится в одну строчку.

        static void Main(string[] args)
        {
            int age;
            int growth;
            int weight;

            Console.Write("Введите свое имя: ");
            string firstName = Console.ReadLine();

            Console.Write("Введите свою фамилию: ");
            string lastName = Console.ReadLine();

            Console.Write("Введите свой возраст: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите свой рост: ");
            growth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите свой вес: ");
            weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(String.Format($"{firstName} {lastName}, возраст: {age}, рост: {growth} вес: {weight}"));

            Class1.Pause("Для выхода из консоли нажмите любую кнопку...");
        }
    }
}
