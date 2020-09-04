using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31
{
    struct Complex
    {
        private double a;
        private double b;

        // Доступ к полям класса и получение значений переменных a и b
        public double A 
        {
            set { a = value; }
            get { return a; }
        }
        public double B
        {
            set { b = value; }
            get { return b; }
        }



        // Сложение комплексных чисел
        public static Complex operator + (Complex x, Complex y)
        {
            return new Complex(re: x.a + y.a, im: x.b + y.b);
        }


        // Вычитание комплексных чисел
        public static Complex operator - (Complex x1, Complex y1)
        {
            return new Complex(re: x1.a - y1.a, im: x1.b - y1.b);
        }


        // Умножение комплексных чисел
        public static Complex operator * (Complex x1, Complex y1)
        {
            return new Complex(re: ((x1.a * y1.a) - (x1.b * y1.b)), im: ((x1.a * y1.b) + (x1.b * y1.a)));
        }



        public Complex(double re, double im)
        {
            a = re;
            b = im;
        }


        // Представление комплексного числа в читаемой форме
        public override string ToString()
        {
            if (b == 0) return $"{a}";
            else if (a==0) return $"{b}i";
            else return (b < 0) ? $"{a} - {-b}i" : $"{a} + {b}i";
        }

    }
}
