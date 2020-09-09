using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex33
{
    class Fractions
    {
        // Числитель и значенатель дроби
        private int numerator;
        private int denominator;


        // Доступ к полям класса и получение значений числителя и знаменателя
        // С проверкой знаменателя на != 0
        public int Numerator
        {
            set { numerator = value; }
            get { return numerator; }
        }
        public int Denominator
        {
            set
            {
                if (value == 0) throw new ArgumentException("Знаменатель не может быть равен 0");
                else
                    denominator = value;
            }
            get { return denominator; }
        }



        public Fractions(int num, int den)
        {
            numerator = num;
            denominator = den;
        }


        // Сложение двух дробей
        public static Fractions Sum (Fractions x, Fractions y)
        {
            int leastCommonMultiple = getLeastCommonMultiple(x.denominator, y.denominator); // Наименьшее общее кратное знаменателей
            int additionalMultiplierFirst = leastCommonMultiple / x.denominator; // Дополнительный множитель к первой дроби
            int additionalMultiplierSecond = leastCommonMultiple / y.denominator; // Дополнительный множитель ко второй дроби

            int result = (x.numerator * additionalMultiplierFirst) + (y.numerator * additionalMultiplierSecond);
            return new Fractions(result, x.denominator * additionalMultiplierFirst);
        }


        // Вычитание двух дробей
        public static Fractions Minus(Fractions x, Fractions y)
        {
            int leastCommonMultiple = getLeastCommonMultiple(x.denominator, y.denominator); // Наименьшее общее кратное знаменателей
            int additionalMultiplierFirst = leastCommonMultiple / x.denominator; // Дополнительный множитель к первой дроби
            int additionalMultiplierSecond = leastCommonMultiple / y.denominator; // Дополнительный множитель ко второй дроби

            int result = (x.numerator * additionalMultiplierFirst) - (y.numerator * additionalMultiplierSecond);
            return new Fractions(result, x.denominator * additionalMultiplierFirst);
        }

        // Умножение двух дробей
        public static Fractions Multi(Fractions x, Fractions y)
        {
            int numResult = x.numerator * y.numerator;
            int denResult = x.denominator * y.denominator;
            int nod = getGreatCommonDivisor(numResult, denResult);
            if (nod != 1) return new Fractions(numResult / nod, denResult / nod);
            else return new Fractions(numResult, denResult);

        }

        // Деление двух дробей
        public static Fractions Division(Fractions x, Fractions y)
        {
            return new Fractions(x.numerator * y.denominator, x.denominator * y.numerator);
        }



        // Возвращает наибольший общий делитель
        private static int getGreatCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }


        // Возвращает наименьшее общее кратное
        private static int getLeastCommonMultiple(int a, int b)
        {
            return a * b / getGreatCommonDivisor(a, b);
        }


        // Метод представления дроби в строке
        public override string ToString()
        {
            return $"{numerator} / {denominator}";
        }
    }
}
