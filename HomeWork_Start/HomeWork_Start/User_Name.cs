using System;
using System.Security;
using ClassLibraryPause;
using ClassLibraryPrint;

namespace User_Name
{
    class User_Name
    {

        //Морозов Михаил
        //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        //б) *Сделать задание, только вывод организовать в центре экрана.


        static void Main(string[] args)
        {

            ClassPrintText.PrintUserName();
            Class1.Pause("Это последнее задание, для выхода нажмите любую кнопку...");

        }
    }
}
