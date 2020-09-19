using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Морозов Михаил
// Используя Windows Forms, разработать игру «Угадай число». 
// Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.
// Компьютер говорит, больше или меньше загаданное число введенного.
// a) Для ввода данных от человека используется элемент TextBox;
// б) ** Реализовать отдельную форму c TextBox для ввода числа.



namespace Ex72
{
    class RandNumber
    {
        int value;
        int steps;

        public int Value { get { return this.value; } }
        public int Steps { get { return this.steps; } }



        public RandNumber(int max)
        {
            start(max);
        }

        public void start(int max)
        {
            Random rand = new Random();
            this.value = rand.Next(0, max + 1);
            Debug.WriteLine(this.value);
        }


        // Проверка значения
        public string CheckValue(out bool check, int userAnswer)
        {
            Debug.WriteLine(userAnswer);

            if (userAnswer == this.value)
            {
                check = true;
                return $"Поздравляю, вы угадали за {this.steps} ходов!";
            }
            else if (userAnswer > this.value)
            {
                check = false;
                steps++;
                return $"Введённое число большое, попробуйте ещё раз!";
            }
            else
            {
                check = false;
                steps++;
                return $"Введённое число мало, попробуйте ещё раз!";
            }
        }

        public void Reset(int max)
        {
            start(max);
            this.steps = 0;
        }

    }
}
