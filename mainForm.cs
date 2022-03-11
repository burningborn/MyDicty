using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MyDicty
{
    
    public partial class mainForm : Form
    {
        myDicti.MyDictionary CurrentDicti = new myDicti.MyDictionary();
        static string Lexicons = @"H:\111_IT_Step\WinForms\repos\MyDicty\Files\LexiconsList.txt"; // файл хранения списка словарей
        private string line = "";
        private int ListSize = 0; // количество словарей
        public string[] LangList; // список словарей
        private bool searchFlag = true;

        public mainForm()
        {
            InitializeComponent();
            lexiconInitFunc(); // завгрузка списка словарей из файла в переменную LangList
        }

        private void LangListZise() // вычисление количества словарей 
        {
            using (StreamReader sr = new StreamReader(Lexicons))
                while ((line = sr.ReadLine()) != null)
                {
                    ListSize++;
                }
            LangList = new string[ListSize];
        }
        private void lexiconInitFunc() // функция завгрузки списка словарей из файла в переменную LangList
        {
            LangListZise();
            int size = 0;
            using (StreamReader sr = new StreamReader(Lexicons))
                while ((line = sr.ReadLine()) != null)
                {
                    LangList[size] = line;
                    size++;
                }
        }
        private void newLexiconFunc() // функция создания нового словаря
        {
            string _filename = null;
            SaveFileDialog sfd = new SaveFileDialog();
                      
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _filename = sfd.FileName;
            }
            try
            {
            using (StreamWriter sw = new StreamWriter(Lexicons, true, Encoding.Default))
                  {
                    sw.WriteLine(_filename); // запись пути доступа к файлу нового словаря в реестр словарей
                  }
                using (StreamWriter sW = new StreamWriter(_filename + ".txt"))
                {
                    sW.WriteLine();  // создание файла нового словаря
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void newLexicon(object sender, EventArgs e)
        {
            newLexiconFunc();
        }
        private void DictiBox_SelectedIndexChanged(object sender, EventArgs e) // выбор словаря
        {           
            CurrentDicti.Clear();  // удаление всех слов
            CurrentDicti.LanguageBaseLoad(LangList[DictiBox.SelectedIndex]) ; // загрузка выбранного словаря
        }
        
        private void SearchKey(object sender, EventArgs e) // поиск слова по ключу
        {
            if (searchFlag == true)        
            translateBox.Text = CurrentDicti.GetWord(keyBox.Text); // вывод результата на экран 
        }
        private void searchByItem(object sender, EventArgs e)
        {
            if (searchFlag == false)
                keyBox.Text = CurrentDicti.searchByEiem(translateBox.Text);
        }
        public void saveFile(string _filename) // функция сохранения файла
        {
            if (_filename == "")
            {

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _filename = saveFileDialog.FileName;
                }
                else
                {

                }
            }
            try
            {
                CurrentDicti.AllToFile(_filename);
            }
            catch
            {
                MessageBox.Show("Unable to save in file");
            }
        }
        private void save(object sender, EventArgs e) // сохранение 
        {
            saveFile(LangList[DictiBox.SelectedIndex]);
        }

        private void saveAs(object sender, EventArgs e) // сохранение с новым именем
        {
            saveFile("");
        }

        private void addItemFunc()  // функция добавления варианта перевода
        {
            if (keyBox.Text == "")
            {

                var result = MessageBox.Show("Введите слово", "Message", MessageBoxButtons.OK);
                if (DialogResult==result)    
                    return; 
            }
            else if (CurrentDicti.addItem(keyBox.Text, addRemoveItem(translateBox.Text)))
            {
                translateBox.Text = CurrentDicti.GetWord(keyBox.Text);
                MessageBox.Show("Перевод добавлен");
            }
            else
                MessageBox.Show("Этот авриант перевода уже существует");
        }
        private void addItemBtn_Click(object sender, EventArgs e) // добавление варианта перевода через кнопку
        {
            addItemFunc();
        }

        private void addItem(object sender, EventArgs e) // добавление варианта перевода через меню
        {
            addItemFunc();
        }
        private string addRemoveItem(string item)
        {
            string[] list = item.Split();
            return list[list.Length - 1];
        }
        private void removeItemFunc()  // функция удаления варианта перевода
        {
            if(CurrentDicti.removeItem(keyBox.Text, addRemoveItem(translateBox.Text)))
            {
            translateBox.Text = CurrentDicti.GetWord(keyBox.Text);
            MessageBox.Show("Перевод удалён");
            }
            else
            MessageBox.Show("Нельзя удалить последний перевод");



        }
        private void removeItemBtn_Click(object sender, EventArgs e) // удалить вариант перевода кнопкой
        {
            removeItemFunc();
        }
        private void removeItem(object sender, EventArgs e) // удалить вариант перевода через меню
        {
            removeItemFunc();
        }
        private void RemoveWordFunc() // функция удаления слова из словаря
        {
            CurrentDicti.RemoveWord(keyBox.Text);
            keyBox.Text = translateBox.Text = null;
            MessageBox.Show("Слово " + Convert.ToString(keyBox.Text) + " удалено из словаря");
        }
        private void removeWordBtn_Click(object sender, EventArgs e) // удаление слова из словаря через кнопку
        {
            RemoveWordFunc();
        }
        private void RemoveWord(object sender, EventArgs e) // удаление слова из словаря через меню
        {
            RemoveWordFunc();
        }
        private void addWordFunc() // функция добавления слова в словарь
        {           
            if (keyBox.Text != "" && translateBox.Text != "")
            {
                if (CurrentDicti.AddWord(keyBox.Text, translateBox.Text) == true)
                    MessageBox.Show("Cлово " + Convert.ToString(keyBox.Text) + " и его перевод добавлены в словарь");
                else
                    MessageBox.Show($"Слово {keyBox.Text} уже есть в словаре.");
            }
            else
                MessageBox.Show("Вам необходимо ввести слово и (или) его перевод");
        }
        private void addKey_Click(object sender, EventArgs e) // добаить слово //кнопка
        {
            addWordFunc();
        }

        private void addWord(object sender, EventArgs e) // добаить слово //меню
        {
            addWordFunc();
        }

        private void WordToFile(object sender, EventArgs e) // запись слова в отдельный словарь
        {
            string Path = null;
            if (saveWordDialog.ShowDialog() == DialogResult.OK)
            {
                Path = saveWordDialog.FileName;
            }
            try
            {
                CurrentDicti.WordToFile(keyBox.Text, Path);
                MessageBox.Show("Слово записано в файл");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioItemBtn_CheckedChanged(object sender, EventArgs e)
        {
            searchFlag = false;
        }

        private void radioWordBtn_CheckedChanged(object sender, EventArgs e)
        {
            searchFlag = true;     
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Save your Dictionary?", "Message", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Cancel)
                e.Cancel = true;
            if (result == DialogResult.Yes)
            {
                string _filename = "";
                saveFile(_filename);
                if (_filename == "")
                    e.Cancel = true;
            }
        }
    }
}       