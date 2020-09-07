using System;
using ClassLibraryPause;

namespace IMT
{
    class IMT
    {
        //  Морозов Михаил
        //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) 
        //по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.

        
        static double IMT_I (int m, double h)
        {
            var I = m / (h * h);

            return I;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("{0:F1}", IMT_I(86, 1.82f));

            Class1.Pause("Нажмите на любую кнопку...");
        }
    }
}
