
namespace MyDicty
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DictiLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addTranslateItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTranslateItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DictiBox = new System.Windows.Forms.ComboBox();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.translateBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.addKey = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.saveWordDialog = new System.Windows.Forms.SaveFileDialog();
            this.removeWordBtn = new System.Windows.Forms.Button();
            this.removeItemBtn = new System.Windows.Forms.Button();
            this.wordLbl = new System.Windows.Forms.Label();
            this.itemLbl = new System.Windows.Forms.Label();
            this.newLexiconDialog = new System.Windows.Forms.SaveFileDialog();
            this.radioWordBtn = new System.Windows.Forms.RadioButton();
            this.radioItemBtn = new System.Windows.Forms.RadioButton();
            this.toolAddWord = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DictiLbl
            // 
            this.DictiLbl.AutoSize = true;
            this.DictiLbl.Location = new System.Drawing.Point(225, 33);
            this.DictiLbl.Name = "DictiLbl";
            this.DictiLbl.Size = new System.Drawing.Size(111, 13);
            this.DictiLbl.TabIndex = 1;
            this.DictiLbl.Text = "Выбрать словарь";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(569, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem
            // 
            this.MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveAsToolStripMenuItem1});
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new System.Drawing.Size(37, 20);
            this.MenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveToolStripMenuItem.Text = "Create New";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.newLexicon);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveAsToolStripMenuItem.Text = "Save";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.save);
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.saveAsToolStripMenuItem1.Text = "Save as";
            this.saveAsToolStripMenuItem1.Click += new System.EventHandler(this.saveAs);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripSeparator2,
            this.addTranslateItemToolStripMenuItem,
            this.removeTranslateItemToolStripMenuItem,
            this.toolStripSeparator1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(266, 22);
            this.toolStripMenuItem1.Text = "add Word";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.addWord);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(266, 22);
            this.toolStripMenuItem2.Text = "Remove Word";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.RemoveWord);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(266, 22);
            this.toolStripMenuItem3.Text = "Word To File";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.WordToFile);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(263, 6);
            // 
            // addTranslateItemToolStripMenuItem
            // 
            this.addTranslateItemToolStripMenuItem.Name = "addTranslateItemToolStripMenuItem";
            this.addTranslateItemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.N)));
            this.addTranslateItemToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.addTranslateItemToolStripMenuItem.Text = "add Translate item";
            this.addTranslateItemToolStripMenuItem.Click += new System.EventHandler(this.addItem);
            // 
            // removeTranslateItemToolStripMenuItem
            // 
            this.removeTranslateItemToolStripMenuItem.Name = "removeTranslateItemToolStripMenuItem";
            this.removeTranslateItemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.removeTranslateItemToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.removeTranslateItemToolStripMenuItem.Text = "Remove Translate Item";
            this.removeTranslateItemToolStripMenuItem.Click += new System.EventHandler(this.removeItem);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(263, 6);
            // 
            // DictiBox
            // 
            this.DictiBox.FormattingEnabled = true;
            this.DictiBox.Items.AddRange(new object[] {
            "Англо - Русский",
            "Русско - Английский",
            "Немецко - Русский",
            "Русско - Немецкий"});
            this.DictiBox.Location = new System.Drawing.Point(198, 58);
            this.DictiBox.Name = "DictiBox";
            this.DictiBox.Size = new System.Drawing.Size(158, 21);
            this.DictiBox.TabIndex = 4;
            this.DictiBox.SelectedIndexChanged += new System.EventHandler(this.DictiBox_SelectedIndexChanged);
            // 
            // keyBox
            // 
            this.keyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyBox.Location = new System.Drawing.Point(42, 125);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(184, 23);
            this.keyBox.TabIndex = 5;
            this.keyBox.TextChanged += new System.EventHandler(this.SearchKey);
            // 
            // translateBox
            // 
            this.translateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.translateBox.Location = new System.Drawing.Point(328, 125);
            this.translateBox.Multiline = true;
            this.translateBox.Name = "translateBox";
            this.translateBox.Size = new System.Drawing.Size(184, 23);
            this.translateBox.TabIndex = 6;
            this.translateBox.TextChanged += new System.EventHandler(this.searchByItem);
            // 
            // addKey
            // 
            this.addKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addKey.Location = new System.Drawing.Point(42, 164);
            this.addKey.Name = "addKey";
            this.addKey.Size = new System.Drawing.Size(83, 23);
            this.addKey.TabIndex = 7;
            this.addKey.Text = "Добавить";
            this.toolAddWord.SetToolTip(this.addKey, "Для добавления слова \r\nнапишите слово и его \r\nпервод в соответствующих \r\nокнах и " +
        "нажмите \"Добавить\".\r\n");
            this.addKey.UseVisualStyleBackColor = false;
            this.addKey.Click += new System.EventHandler(this.addKey_Click);
            // 
            // addItemBtn
            // 
            this.addItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addItemBtn.Location = new System.Drawing.Point(328, 164);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(83, 23);
            this.addItemBtn.TabIndex = 8;
            this.addItemBtn.Text = "Добавить";
            this.toolAddWord.SetToolTip(this.addItemBtn, "Для добавления варианта\r\n перевода удалите из \r\nформы переводов все \r\nварианты, в" +
        "пишите новый \r\nвариант и нажмите \"Добавить\"");
            this.addItemBtn.UseVisualStyleBackColor = false;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // removeWordBtn
            // 
            this.removeWordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.removeWordBtn.Location = new System.Drawing.Point(143, 164);
            this.removeWordBtn.Name = "removeWordBtn";
            this.removeWordBtn.Size = new System.Drawing.Size(83, 23);
            this.removeWordBtn.TabIndex = 9;
            this.removeWordBtn.Text = "Удалить";
            this.toolAddWord.SetToolTip(this.removeWordBtn, "Для удаления слова \r\nтекщего слова из \r\nсловаря нажмите \"Удалить\".\r\n");
            this.removeWordBtn.UseVisualStyleBackColor = false;
            this.removeWordBtn.Click += new System.EventHandler(this.removeWordBtn_Click);
            // 
            // removeItemBtn
            // 
            this.removeItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.removeItemBtn.Location = new System.Drawing.Point(431, 164);
            this.removeItemBtn.Name = "removeItemBtn";
            this.removeItemBtn.Size = new System.Drawing.Size(83, 23);
            this.removeItemBtn.TabIndex = 10;
            this.removeItemBtn.Text = "Удалить";
            this.toolAddWord.SetToolTip(this.removeItemBtn, "Для удаления варианта\r\n перевода удалите из \r\nформы переводов все \r\nварианты, впи" +
        "шите \r\nвариант который хотите \r\nудалить и нажмите \"Удалить\"\r\n");
            this.removeItemBtn.UseVisualStyleBackColor = false;
            this.removeItemBtn.Click += new System.EventHandler(this.removeItemBtn_Click);
            // 
            // wordLbl
            // 
            this.wordLbl.AutoSize = true;
            this.wordLbl.Location = new System.Drawing.Point(111, 97);
            this.wordLbl.Name = "wordLbl";
            this.wordLbl.Size = new System.Drawing.Size(50, 13);
            this.wordLbl.TabIndex = 11;
            this.wordLbl.Text = "СЛОВО";
            // 
            // itemLbl
            // 
            this.itemLbl.AutoSize = true;
            this.itemLbl.Location = new System.Drawing.Point(390, 97);
            this.itemLbl.Name = "itemLbl";
            this.itemLbl.Size = new System.Drawing.Size(67, 13);
            this.itemLbl.TabIndex = 12;
            this.itemLbl.Text = "ПЕРЕВОД";
            // 
            // radioWordBtn
            // 
            this.radioWordBtn.AutoSize = true;
            this.radioWordBtn.Location = new System.Drawing.Point(66, 200);
            this.radioWordBtn.Name = "radioWordBtn";
            this.radioWordBtn.Size = new System.Drawing.Size(137, 17);
            this.radioWordBtn.TabIndex = 13;
            this.radioWordBtn.TabStop = true;
            this.radioWordBtn.Text = "ПОИСК ПО СЛОВУ";
            this.radioWordBtn.UseVisualStyleBackColor = true;
            this.radioWordBtn.CheckedChanged += new System.EventHandler(this.radioWordBtn_CheckedChanged);
            // 
            // radioItemBtn
            // 
            this.radioItemBtn.AutoSize = true;
            this.radioItemBtn.Location = new System.Drawing.Point(351, 200);
            this.radioItemBtn.Name = "radioItemBtn";
            this.radioItemBtn.Size = new System.Drawing.Size(163, 17);
            this.radioItemBtn.TabIndex = 14;
            this.radioItemBtn.TabStop = true;
            this.radioItemBtn.Text = "ПОИСК ПО ПЕРЕВОДУ";
            this.radioItemBtn.UseVisualStyleBackColor = true;
            this.radioItemBtn.CheckedChanged += new System.EventHandler(this.radioItemBtn_CheckedChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(569, 231);
            this.Controls.Add(this.radioItemBtn);
            this.Controls.Add(this.radioWordBtn);
            this.Controls.Add(this.itemLbl);
            this.Controls.Add(this.wordLbl);
            this.Controls.Add(this.removeItemBtn);
            this.Controls.Add(this.removeWordBtn);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.addKey);
            this.Controls.Add(this.translateBox);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.DictiBox);
            this.Controls.Add(this.DictiLbl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "PolyGlot";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DictiLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTranslateItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTranslateItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox DictiBox;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.TextBox translateBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button addKey;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.SaveFileDialog saveWordDialog;
        private System.Windows.Forms.Button removeWordBtn;
        private System.Windows.Forms.Button removeItemBtn;
        private System.Windows.Forms.Label wordLbl;
        private System.Windows.Forms.Label itemLbl;
        private System.Windows.Forms.SaveFileDialog newLexiconDialog;
        private System.Windows.Forms.RadioButton radioWordBtn;
        private System.Windows.Forms.RadioButton radioItemBtn;
        private System.Windows.Forms.ToolTip toolAddWord;
    }
}

