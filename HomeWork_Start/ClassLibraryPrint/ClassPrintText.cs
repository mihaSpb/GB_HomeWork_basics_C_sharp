using System;

namespace ClassLibraryPrint
{
    public class ClassPrintText
    {
        //Морозов Михаил
        //*Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).

        static public void PrintUserName()
        {
            string name = "Михаил";
            string lastName = "Морозов";
            string city = "Санкт-Петербург";

            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine($"{name} {lastName} из города {city}");
        }
    }
}
