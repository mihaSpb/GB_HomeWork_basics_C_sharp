using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24
{
    // Морозов Михаил
    // 4. Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль. 
    // На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
    // Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
    // С помощью цикла do while ограничить ввод пароля тремя попытками.

    class Program
    {
        static void Main(string[] args)
        {

            int stop = 0;

            do
            {
                Console.Write("Введите имя пользователя: ");
                string user = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string pass = Console.ReadLine();
                Console.Clear();
                stop++;

                CheckUser(user, pass);

                if (CheckUser(user, pass))
                {
                    Console.WriteLine("Поздравляю! Вход выполнен успешно!");
                    stop = 3;
                }
                else
                {
                    Console.WriteLine("Вход не выполнен. Пароль или имя пользователя не совпадают. Попробуйте еще раз.");
                }
            }
            while (stop < 3);


            Console.WriteLine();
            Console.ReadKey();
        }

        private static bool CheckUser(string user, string pass)
        {
            return (user == "root" && pass == "GeekBrains");
        }
    }
}
