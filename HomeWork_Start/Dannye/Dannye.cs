using System;
using ClassLibraryPause;

namespace Dannye
{
    //Морозов Михаил
    //Написать программу обмена значениями двух переменных:
    //а) с использованием третьей переменной;
    //б) * без использования третьей переменной.


    class Dannye
    {
        static void Main(string[] args)
        {
            int x = 100;
            int y = 20;
            int z = x;

            x = y;
            y = z;

            Console.WriteLine(string.Format($"С использованием третьей переменной: {x} {y}"));

            x = x + y;
            y = y - x;
            y = -y;
            x = x - y;


            Console.WriteLine(string.Format($"Без использования третьей переменной: {x} {y}"));


            Class1.Pause("Готово, для выхода нажмите любую кнопку...");
        }
    }
}
