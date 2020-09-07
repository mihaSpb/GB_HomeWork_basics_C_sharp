using System;

namespace ClassLibraryPause
{
    public class Class1
    {

        //Морозов Михаил
        //*Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).

        static public void Pause (string str)
        {
            Console.WriteLine();
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
