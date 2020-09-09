using System;
using System.Text.RegularExpressions;

// Морозов Михаил
// Создать программу, которая будет проверять корректность ввода логина.
// Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, 
// при этом цифра не может быть первой:
// а) без использования регулярных выражений;
// б) ** с использованием регулярных выражений.



namespace Ex51
{
    class Program
    {
        /// Проверка без использования регулярных выражений<summary>
        /// Проверка соответствия условиям введенного логина
        /// Возвращает checkOK true, если условия выполнены
        /// Условия: строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, 
        /// при этом цифра не может быть первой</summary>
        /// <param name="login" Введенный логин></param>
        /// <returns></returns>
        /// 
        public static bool CheckLogin(string login, ref int resultCheckLogin)
        {
            int length = login.Length;

            if (length >= 2 & length <= 10) // Проверка соответствия длины логина
            {
                char charLogin = login[0]; // Переменная для проверки символов логина ( login[0] - проверяем первый символ)
                if (!(Char.IsDigit(charLogin))) // Проверка первого символа - не должен быть цифрой
                {
                    for (int i = 0; i < length; i++) // Проверка того, что введены строчные символы на латинице или цифры
                    {
                        charLogin = login[i];
                        if (!(CheckLatin(charLogin)))
                        {
                            resultCheckLogin = 2;
                            return false;
                        }
                    }
                    return true;
                }

                resultCheckLogin = 1;
                return false;
            }

            resultCheckLogin = 3;
            return false;
        }


        /// Проверка, что введенные символы на латинице либо содержит цифры</summary>
        /// <param name="charLogin">Символ</param>
        /// <returns></returns>
        private static bool CheckLatin(char charLogin)
        {
            int temp = charLogin;
            // Проверяем, входит ли код введенного символа в диапазон строчных латинских символов
            if ((temp >= 97 & temp <= 122) | (temp >= 48 & temp <= 57))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Текст на экран при вводе логина
        /// </summary>
        /// <param name="resultCheckLogin">Результат проверки логина </param>
        private static void ResultCheckLogin(int resultCheckLogin)
        {
            switch (resultCheckLogin)
            {
                case 0:
                    Console.Write($"\nЛогин корректен.");
                    break;
                case 1:
                    Console.Write($"\nЛогин не должен начинаться с цифры!");
                    break;
                case 2:
                    Console.Write($"\nЛогин может содержать только строчные буквы латинского алфавита или цифры!");
                    break;
                case 3:
                    Console.Write($"\nЛогин должен быть не более десяти символов, но не короче двух!");
                    break;
                case 4:
                    Console.Write($"\nВведенный логин не корректен! Проверьте длину логина или вводите строчные латинские символы!");
                    break;
            }
        }



        /// <summary>
        /// Метод проверки введенного логина с использованием регулярных выражений
        /// </summary>
        /// <param name="login"> Введенный логин</param>
        /// <param name="resultCheckLogin">Возвращаемый вариант результата проверки</param>
        /// <returns></returns>
        static bool CheckLoginReg(string login, ref int resultCheckLogin)
        {
            char charLogin = login[0];

            // Проверка первого символа
            if (Char.IsDigit(charLogin))
            {
                resultCheckLogin = 1;
                return false;
            }

            // Проверка входящих в логин символов и длины логина
            if (!(Regex.IsMatch(login, @"^[a-z0-9]{2,10}$")))
            {
                resultCheckLogin = 4;
                return false;
            }

            resultCheckLogin = 0;
            return true;
        }






        static void Main(string[] args)
        {
            string login = default(string);
            bool result = default(bool);
            int resultCheckLogin = 0;

            Console.Write($"Введите логин:");
            login = Console.ReadLine();

            // Запуск метода проверки логина (без регулярных выражений)
            result = CheckLogin(login, ref resultCheckLogin);
            Console.WriteLine($"Результат проверки логина (без регулярных выражений): {result}");
            // Вывод на экран результата проверки
            ResultCheckLogin(resultCheckLogin);
            Console.WriteLine("");

            // Проверка логина с использованием регулярных выражений
            Console.Write($"\nВведите логин:");
            login = Console.ReadLine();

            // Запуск метода проверки логина с использованием регулярных выражений
            result = CheckLoginReg(login, ref resultCheckLogin);
            Console.WriteLine($"Результат проверки логина (с использованием регулярных выражений): {result}");

            // Вывод на экран результата проверки
            ResultCheckLogin(resultCheckLogin);


            Console.ReadKey();

        }

    }
}
