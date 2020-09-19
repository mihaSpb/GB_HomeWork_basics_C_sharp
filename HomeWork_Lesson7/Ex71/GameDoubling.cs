using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex71
{

    // Делегат с сигнатурой void void
    public delegate void reverseFunc();

    class GameDoubling
    {
        // Текущее значение
        int resultValue;

        // Коичество ходов
        int stepCount;

        // Целевое значение
        int goal;


        // Рандомайзей для создания целевого значения
        Random rand = new Random();

        public void SetGoal()
        {
            this.goal = rand.Next(2, 2517);
        }



        Stack<reverseFunc> lastOper = new Stack<reverseFunc>();

        // Возвращает текущее значение поля resultValue
        public int ResultValue {get { return this.resultValue; } }

        // Возвращает текущее значение поля stepCount
        public int StepCount { get { return this.stepCount; } }

        // Возвращает текущее значение поля goal
        public int Goal { get { return this.goal; } }


        // Конструктор присваивает всем полям значение 0
        public GameDoubling()
        {
            this.resultValue = 1;
            this.stepCount = 0;
            this.goal = 0;
        }


        // Отмена последнего действия. Проверяет стэк, если не пустой, выполняет операцию, обратную последней
        public void CheckStack()
        {
            reverseFunc reverseFunc;
            if (lastOper.Count != 0)
            {
                reverseFunc = lastOper.Pop();
                reverseFunc();
            }
            return;
        }

        // Сброс текущего значения и счётчика шагов
        public void Reset()
        {
            this.resultValue = 1;
            this.stepCount = 0;
            lastOper.Clear();
        }

        // Генерация целевого значения
        public void GetGoal()
        {
            this.goal = rand.Next(2, 2049);
        }

        // Проверка текущего значения с целевым
        public bool CheckGoal()
        {
            if (this.resultValue == this.goal)
            {
                return true;
            }

            return false;
        }

        #region Методы добавления значений или вычитания при отмене

        public void PlusOne()
        {
            this.resultValue++;
            this.stepCount++;
            Debug.Write(resultValue);

            lastOper.Push(new reverseFunc(MinusOne));
        }

        public void MultiplicTwo()
        {
            this.resultValue *= 2;
            this.stepCount++;
            lastOper.Push(new reverseFunc(DivideByTwo));
        }


        public void MinusOne()
        {
            this.resultValue--;
            this.stepCount--;

        }

        public void DivideByTwo()
        {
            this.resultValue /=2;
            this.stepCount--;
        }

        #endregion
    }
}
