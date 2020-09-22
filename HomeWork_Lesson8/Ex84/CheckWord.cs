using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Ex84
{
    // Класс для хранения списка слов. А также для сериализации в XML и десериализации из XML
    class CheckWord
    {
        string fileName;
        List<Dictionary> list;
        public string FileName
        {
            set { fileName = value; }
        }

        // Конструктор записывает путь к файлу и инициализирует пустой список слов
        /// <param name="fileName">Имя и путь к файлу</param>
        public CheckWord(string fileName)
        {
            this.fileName = fileName;
            list = new List<Dictionary>();
        }

        /// <summary>Метод добавления слова</summary>
        /// <param name="endtext">Слово на англ</param>
        /// <param name="rutext">Слово на рус</param>
        public void Add(string endtext, string rutext)
        {
            bool contain = list.Contains(new Dictionary(endtext, rutext));
            if (!contain)
                list.Add(new Dictionary(endtext, rutext));
            else
                MessageBox.Show("Данное слово уже имеется в списке", "Внимание");
        }

        /// <summary>Метод удаления слова</summary>
        /// <param name="wordtoremove">Слово из списка</param>
        public void Remove(Dictionary wordToRemove)
        {
            int index = list.IndexOf(wordToRemove);
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }

        /// <summary>Индексатор - свойство для доступа к закрытому объекту</summary>
        /// <param name="index">Индекс слова</param>
        /// <returns></returns>
        public Dictionary this[int index]
        {
            get { return list[index]; }
        }

        // Метод сериализации слов
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Dictionary>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        // Метод десериализации списка слов
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Dictionary>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Dictionary>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        // Свойство возвращает размер списка слов
        public int Count
        {
            get { return list.Count; }
        }
    }
}
