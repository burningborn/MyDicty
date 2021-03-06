using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace myDicti
{
    class MyDictionary : IEnumerable
    {
        public Dictionary<string, Word<string, List<string>>> thisDictionary;  //список слов и их переводов
        public MyDictionary()  // конструктор без параметров
        {
           thisDictionary = new Dictionary<string, Word<string, List<string>>>();
        }
        public MyDictionary(Word<string, List<string>> word)  // конструктор с параметрами
        {
            thisDictionary = new Dictionary<string, Word<string, List<string>>>();
        }
        public IEnumerator GetEnumerator() => thisDictionary.GetEnumerator(); //определяем публичный метод GetEnumerator для работы с foreach

        //-------------------------------МЕТОДЫ--------------------------

        public void addItem(string key, string tranceVar)
        {
            foreach (var item in thisDictionary)
            {
                if (item.Key == key)
                    item.Value.AddValue(tranceVar);
            }
        }

        public void removeItem(string key, string tranceVar)
        {
            foreach (var item in thisDictionary)
            {
                if (item.Key == key)
                    item.Value.RemoveOneVar(tranceVar);
            }
        }
        public void AddWord(Word<string, List<string>> word) // метод добавления имеющиегося слова в словарь
        {
            if (!thisDictionary.ContainsKey(word.Key))
                thisDictionary.Add(word.Key, word);
        }
        public void AddWord(string key, string value) // метод добавления слова и его перевода в словарь
        {
            var Word= new Word<string, List<string>>(key, value);
            if (!thisDictionary.ContainsKey(key))
                thisDictionary.Add(Word.Key, Word);
        }
        public void RemoveWord(string key) // удаление слова
        {
            thisDictionary.Remove(key);
        }

        public void Clear()
        {
            thisDictionary.Clear();
        }
        public void LanguageBaseLoad(string Path)  //загрузка слваря
        {            
            string line = ""; // перменная для приёма строки из файла       
            if (File.Exists(Path)) //проверка открытия файла
            {
                using (StreamReader sr = new StreamReader(Path)) //открытие файла на чтение
                {
                    while ((line = sr.ReadLine()) != null) // построчная запись в строку
                    {
                        line.TrimStart();
                        line = Regex.Replace(line, @"\s+", " ");
                        line = Regex.Replace(line, @"[*,\[\]]", "");
                        string[] list = line.Split();          // делим строку на слова
                        List<string> temp = new List<string>();
                        for (int i = 0; i < list.Length; i++)
                        {
                            if (list[i] != "")
                                temp.Add(list[i]);
                        }
                        Word<string, List<string>> tempWord = new Word<string, List<string>>(temp[0], temp[1]); // записываем первое слово как ключ
                        for (int i = 2; i < temp.Count; i++)
                        {
                            tempWord.AddValue(temp[i]); // записываем варианты перевода ключевого слова
                        }
                        this.AddWord(tempWord);
                    }                  
                }               
            }
        }
        public string SearchWord(string key) // метод поиска перевода по ключу
        {
            if (thisDictionary.ContainsKey(key)) // проверка ключа на наличие в коллекции
            {
                var Word = new Word<string, List<string>>(); // создание объекта Word

                thisDictionary.TryGetValue(key, out Word); // получени значения по ключу
                return Convert.ToString(Word.ToString()); // возврат значения в виде строки
            }
            else
            {
                return default;
            }
        }

        public string GetWord(string key) // метод получения слова из словаря в виде строки
        {
            if (thisDictionary.ContainsKey(key))
            { 
                string temp = null;
            foreach (var item in thisDictionary)
                if (item.Key.Equals(key))
                {
                    temp = item.Value.ToString();
                }
            return temp;
            }    
            else
            {
                return default;
            }
        }       
        public bool WordToFile(string key, string Path)
        {
            if (thisDictionary.ContainsKey(key))
            {
                foreach (var item in thisDictionary)
                {
                    if (item.Key.Equals(key))
                        item.Value.WordToFile(Path);
                }     
                 return true;
            }
            else
            {
                 return false;
            }
        }
        public void AllToFile(string Path) // метод записи всего словаря в файл
        {
            string saveDicti = "";
            foreach (var item in thisDictionary)
                saveDicti += Convert.ToString(item.Key) + " * " + Convert.ToString(item.Value) + "\n";
            try
            {
                using (StreamWriter sw = new StreamWriter(Path, false, Encoding.Default))// создание нового файла и запись в него/ или перезапись существующего                   
                    sw.WriteLine(saveDicti);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } 
        
       public override string ToString() // переопределения метода ToString
        {     
            return this.GetWord(Convert.ToString(thisDictionary.Keys));
        }     
    }
}
