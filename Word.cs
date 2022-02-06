using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace myDicti
{
    class Word<TKey, TValue> // класс хранящий слово (Key) и его переводы
    {
        public string Key { get; set; } // ключ - слово

        public List<string> Variants = new List<string>();//коллекция вариантов перевода
        
        public Word()  // конструктор без параметраметров
        {
            Key = null;
            Variants = null;
        }

        public Word(string key, string value) // конструктор с параметрами
        {
            Key = key;            
            Variants.Add(value);
        }

        //-------------------------------МЕТОДЫ--------------------------

        public void AddValue(string value) // добавление вариата перевода
        {
            Variants.Add(value);
        }
        public void RemoveOneVar(string value) // добавление вариата перевода
        {
            if (Variants.Count == 1)
                return;
            Variants.Remove(value);
        } 
        public void WordToFile(string Path)// запись в файл
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Path, false, Encoding.Default))// создание нового файла и запись в него/ или перезапись существующего                   
                {
                    sw.WriteLine(this.GetString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public string GetString()
        {
            string sum = "";
            foreach (var item in Variants)
                sum += " " + item;

            return Key + " * " + sum;
        }
        public override string ToString()
        {
            string sum = "";
            foreach (var item in Variants)
                sum += " " + item;

            return sum;
        }
    }
}
