namespace Coursework_Horbach_program__Form
{
    partial class FileManagePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox_list = new ComboBox();
            listBox_result = new ListBox();
            button_give = new Button();
            menuStrip1 = new MenuStrip();
            addpromotionToolStripMenuItem = new ToolStripMenuItem();
            editpromotionToolStripMenuItem = new ToolStripMenuItem();
            deletepromotionToolStripMenuItem = new ToolStripMenuItem();
            файлToolStripMenuItem = new ToolStripMenuItem();
            acctivepromoToolStripMenuItem = new ToolStripMenuItem();
            saveacctivepromoToolStripMenuItem = new ToolStripMenuItem();
            loadacctivepromoToolStripMenuItem = new ToolStripMenuItem();
            deletepromoToolStripMenuItem = new ToolStripMenuItem();
            savedeleteacctionToolStripMenuItem1 = new ToolStripMenuItem();
            loaddeletacctionToolStripMenuItem1 = new ToolStripMenuItem();
            givelistToolStripMenuItem = new ToolStripMenuItem();
            button_log_exit = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox_list
            // 
            comboBox_list.Font = new Font("Times New Roman", 9F);
            comboBox_list.FormattingEnabled = true;
            comboBox_list.Items.AddRange(new object[] { "Дійсні промокоди", "Видалені промокоди", "Зареєстровані користувачі" });
            comboBox_list.Location = new Point(12, 41);
            comboBox_list.Name = "comboBox_list";
            comboBox_list.Size = new Size(316, 25);
            comboBox_list.TabIndex = 0;
            // 
            // listBox_result
            // 
            listBox_result.FormattingEnabled = true;
            listBox_result.HorizontalScrollbar = true;
            listBox_result.Location = new Point(12, 82);
            listBox_result.Name = "listBox_result";
            listBox_result.ScrollAlwaysVisible = true;
            listBox_result.Size = new Size(776, 344);
            listBox_result.TabIndex = 1;
            // 
            // button_give
            // 
            button_give.Font = new Font("Times New Roman", 9F);
            button_give.Location = new Point(632, 41);
            button_give.Name = "button_give";
            button_give.Size = new Size(142, 25);
            button_give.TabIndex = 2;
            button_give.Text = "Отримати";
            button_give.UseVisualStyleBackColor = true;
            button_give.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addpromotionToolStripMenuItem, editpromotionToolStripMenuItem, deletepromotionToolStripMenuItem, файлToolStripMenuItem, givelistToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // addpromotionToolStripMenuItem
            // 
            addpromotionToolStripMenuItem.Font = new Font("Times New Roman", 7.8F);
            addpromotionToolStripMenuItem.Name = "addpromotionToolStripMenuItem";
            addpromotionToolStripMenuItem.Size = new Size(131, 20);
            addpromotionToolStripMenuItem.Text = "Додати пропозицію";
            addpromotionToolStripMenuItem.Click += addpromotionToolStripMenuItem_Click;
            // 
            // editpromotionToolStripMenuItem
            // 
            editpromotionToolStripMenuItem.Font = new Font("Times New Roman", 7.8F);
            editpromotionToolStripMenuItem.Name = "editpromotionToolStripMenuItem";
            editpromotionToolStripMenuItem.Size = new Size(152, 20);
            editpromotionToolStripMenuItem.Text = "Редагувати пропозицію";
            editpromotionToolStripMenuItem.Click += editpromotionToolStripMenuItem_Click;
            // 
            // deletepromotionToolStripMenuItem
            // 
            deletepromotionToolStripMenuItem.Font = new Font("Times New Roman", 7.8F);
            deletepromotionToolStripMenuItem.Name = "deletepromotionToolStripMenuItem";
            deletepromotionToolStripMenuItem.Size = new Size(143, 20);
            deletepromotionToolStripMenuItem.Text = "Видалити пропозицію";
            deletepromotionToolStripMenuItem.Click += deletepromotionToolStripMenuItem_Click;
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acctivepromoToolStripMenuItem, deletepromoToolStripMenuItem });
            файлToolStripMenuItem.Font = new Font("Times New Roman", 7.8F);
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(50, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // acctivepromoToolStripMenuItem
            // 
            acctivepromoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveacctivepromoToolStripMenuItem, loadacctivepromoToolStripMenuItem });
            acctivepromoToolStripMenuItem.Name = "acctivepromoToolStripMenuItem";
            acctivepromoToolStripMenuItem.Size = new Size(202, 26);
            acctivepromoToolStripMenuItem.Text = "Активні промокоди";
            // 
            // saveacctivepromoToolStripMenuItem
            // 
            saveacctivepromoToolStripMenuItem.Name = "saveacctivepromoToolStripMenuItem";
            saveacctivepromoToolStripMenuItem.Size = new Size(159, 26);
            saveacctivepromoToolStripMenuItem.Text = "Зберегти";
            saveacctivepromoToolStripMenuItem.Click += зберегтиToolStripMenuItem_Click;
            // 
            // loadacctivepromoToolStripMenuItem
            // 
            loadacctivepromoToolStripMenuItem.Name = "loadacctivepromoToolStripMenuItem";
            loadacctivepromoToolStripMenuItem.Size = new Size(159, 26);
            loadacctivepromoToolStripMenuItem.Text = "Завантажити";
            loadacctivepromoToolStripMenuItem.Click += завантажитиToolStripMenuItem_Click;
            // 
            // deletepromoToolStripMenuItem
            // 
            deletepromoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { savedeleteacctionToolStripMenuItem1, loaddeletacctionToolStripMenuItem1 });
            deletepromoToolStripMenuItem.Name = "deletepromoToolStripMenuItem";
            deletepromoToolStripMenuItem.Size = new Size(202, 26);
            deletepromoToolStripMenuItem.Text = "Видалені промокоди";
            // 
            // savedeleteacctionToolStripMenuItem1
            // 
            savedeleteacctionToolStripMenuItem1.Name = "savedeleteacctionToolStripMenuItem1";
            savedeleteacctionToolStripMenuItem1.Size = new Size(159, 26);
            savedeleteacctionToolStripMenuItem1.Text = "Зберегти";
            savedeleteacctionToolStripMenuItem1.Click += зберегтиToolStripMenuItem1_Click;
            // 
            // loaddeletacctionToolStripMenuItem1
            // 
            loaddeletacctionToolStripMenuItem1.Name = "loaddeletacctionToolStripMenuItem1";
            loaddeletacctionToolStripMenuItem1.Size = new Size(159, 26);
            loaddeletacctionToolStripMenuItem1.Text = "Завантажити";
            loaddeletacctionToolStripMenuItem1.Click += завантадитиToolStripMenuItem1_Click;
            // 
            // givelistToolStripMenuItem
            // 
            givelistToolStripMenuItem.Font = new Font("Times New Roman", 7.8F);
            givelistToolStripMenuItem.Name = "givelistToolStripMenuItem";
            givelistToolStripMenuItem.Size = new Size(118, 20);
            givelistToolStripMenuItem.Text = "Отримати списки";
            // 
            // button_log_exit
            // 
            button_log_exit.Font = new Font("Times New Roman", 10.8F);
            button_log_exit.Location = new Point(635, 0);
            button_log_exit.Name = "button_log_exit";
            button_log_exit.Size = new Size(152, 28);
            button_log_exit.TabIndex = 47;
            button_log_exit.Text = "Вийти";
            button_log_exit.UseVisualStyleBackColor = true;
            button_log_exit.Click += button_log_exit_Click;
            // 
            // FileManagePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_log_exit);
            Controls.Add(button_give);
            Controls.Add(listBox_result);
            Controls.Add(comboBox_list);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FileManagePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FileManagePage";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_list;// Випадаючий список для вибору типу списку 
        private ListBox listBox_result; // Список для відображення результату
        private Button button_give; // Кнопка для отримання списку
        private MenuStrip menuStrip1; // Верхнє меню
        // Пункти меню для керування промокодами
        private ToolStripMenuItem addpromotionToolStripMenuItem; // Додати промокод
        private ToolStripMenuItem editpromotionToolStripMenuItem; // Редагувати промокод
        private ToolStripMenuItem deletepromotionToolStripMenuItem; // Видалити промокод
        private ToolStripMenuItem файлToolStripMenuItem; // Пункт меню для роботи з файлами
        private ToolStripMenuItem acctivepromoToolStripMenuItem; // Активні промокоди
        private ToolStripMenuItem saveacctivepromoToolStripMenuItem; // Зберегти активні промокоди в файл формату json
        private ToolStripMenuItem loadacctivepromoToolStripMenuItem; // Завантажити активні промокоди в файл формату json
        private ToolStripMenuItem deletepromoToolStripMenuItem; // Видалені промокоди
        private ToolStripMenuItem savedeleteacctionToolStripMenuItem1; // Зберегти видалені промокоди в файл формату json
        private ToolStripMenuItem loaddeletacctionToolStripMenuItem1; // Завантажити видалені промокоди в файл формату json
        private ToolStripMenuItem givelistToolStripMenuItem; // Отримати списки
        private Button button_log_exit; // Кнопка виходу

    }
}