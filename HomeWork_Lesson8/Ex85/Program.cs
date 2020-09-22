using System;
using System.Linq;
using System.IO;
using System.Xml.Linq;

// Морозов Михаил
// Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок)


namespace Ex85
{


    class Program
    {

        static void Converter(string fileNameOpen, string fileNameSave)
        {
            // Чтение CSV файла
            string[] lines = File.ReadAllLines(fileNameOpen);
             
            // Создание фиксированной структуры нового XML файла
            XElement top = new XElement("TopElement",
                    from items in lines
                    let fields = items.Split(';')

                    select new XElement("Item",

                    new XElement("Name", fields[0]),
                    new XElement("Surname", fields[1]),
                    new XElement("University", fields[2]),
                    new XElement("Faculty", fields[3]),
                    new XElement("Department", fields[4]),
                    new XElement("Age", fields[5]),
                    new XElement("Course", fields[6]),
                    new XElement("Group", fields[7]),
                    new XElement("City", fields[8]))
            );

            // Запись данных в файл
            File.WriteAllText(fileNameSave, top.ToString());

        }


        static void Main(string[] args)
        {
            Converter("students_6.csv", "students_8.xml");

            Console.WriteLine("Работа программы завершена!");

            Console.ReadKey();
        }
    }
}
