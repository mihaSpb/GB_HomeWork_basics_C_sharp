using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31
{
    class ComplexNum
    {
        double re;
        private double im;


        /// Метод представления комплексного числа в удобной форме
        public string ToString()
        {
            return $"{re} + {im}i";
        }

        public ComplexNum()
        {
            im = 0;
            re = 0;
        }

        /// <summary> Метод сложения с другим комплексным числом </summary>
        /// <param name="x2">Комплексное число для сложения</param>
        /// <returns></returns>
        public ComplexNum Plus(ComplexNum x2)
        {
            ComplexNum x3 = new ComplexNum();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }



    }
}
