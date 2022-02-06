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
        static string Lexicons = @"H:\111_IT_Step\WinForms\repos\MyDicty\Files\LexiconsList.txt";
        private string line = "";
        private int ListSize = 0;
        public string[] LangList;

        public mainForm()
        {
            InitializeComponent();
            lexiconInitFunc();
        }

        private void LangListZise()
        {
            using (StreamReader sr = new StreamReader(Lexicons))
                while ((line = sr.ReadLine()) != null)
                {
                    ListSize++;
                }
            LangList = new string[ListSize];
        }
        private void lexiconInitFunc()
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
        private void newLexiconFunc()
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
                    sw.WriteLine(_filename);
                  }
                using (StreamWriter sW = new StreamWriter(_filename + ".txt"))
                {
                    sW.WriteLine();
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
            translateBox.Text = CurrentDicti.GetWord(keyBox.Text); // вывод результата на экран 
        }

        public void saveFile(string _filename) // функция сохранения файла
        {
            if (_filename == "")
            {

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _filename = saveFileDialog.FileName;
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
        private void save(object sender, EventArgs e)
        {
            //saveFile(LangList[DictiBox.SelectedIndex]);
        }

        private void saveAs(object sender, EventArgs e)
        {
            saveFile("");
        }

        private void addItemFunc()
        {
            CurrentDicti.addItem(keyBox.Text, translateBox.Text);
            translateBox.Text = CurrentDicti.GetWord(keyBox.Text);
            MessageBox.Show("Перевод добавлен");
        }
        private void addItemBtn_Click(object sender, EventArgs e) // удалить вариант перевода
        {
            addItemFunc();
        }

        private void addItem(object sender, EventArgs e)
        {
            addItemFunc();
        }
        private void removeItemFunc()
        {
            CurrentDicti.removeItem(keyBox.Text, translateBox.Text);
            translateBox.Text = CurrentDicti.GetWord(keyBox.Text);
            MessageBox.Show("Перевод удалён");
        }
        private void removeItemBtn_Click(object sender, EventArgs e)
        {
            removeItemFunc();
        }
        private void removeItem(object sender, EventArgs e)
        {
            removeItemFunc();
        }
        private void RemoveWordFunc()
        {
            CurrentDicti.RemoveWord(keyBox.Text);
            keyBox.Text = translateBox.Text = null;
            MessageBox.Show("Слово " + Convert.ToString(keyBox.Text) + " удалено из словаря");
        }
        private void removeWordBtn_Click(object sender, EventArgs e)
        {
            RemoveWordFunc();
        }
        private void RemoveWord(object sender, EventArgs e)
        {
            RemoveWordFunc();
        }
        private void addWordFunc()
        {
            if (keyBox.Text != null && translateBox.Text != null)
            {
                CurrentDicti.AddWord(keyBox.Text, translateBox.Text);
                MessageBox.Show("Cлово " + Convert.ToString(keyBox.Text) + " и его перевод добавлены в словарь");
            }
            else
                MessageBox.Show("Вам необходимо ввести слово и его перевод");
        }
        private void addKey_Click(object sender, EventArgs e) // добаить слово //кнопка
        {
            addWordFunc();
        }

        private void addWord(object sender, EventArgs e) // добаить слово //меню
        {
            addWordFunc();
        }

        private void WordToFile(object sender, EventArgs e)
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
    }
}       