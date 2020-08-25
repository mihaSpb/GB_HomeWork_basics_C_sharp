using System;
using System.Security;

namespace HomeWork_Start
{
    class Program
    {

        static void Pause ()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            string name;

            name = Environment.UserName;
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine(name);
            Console.WriteLine("Hello World!");
            Pause("Перегрузка");
        }

        static void Pause (string str)
        {
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
