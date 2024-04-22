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
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            addpromotionToolStripMenuItem = new ToolStripMenuItem();
            editpromotionToolStripMenuItem = new ToolStripMenuItem();
            deletepromotionToolStripMenuItem = new ToolStripMenuItem();
            файлToolStripMenuItem = new ToolStripMenuItem();
            активніПромокодиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            завантадитиToolStripMenuItem = new ToolStripMenuItem();
            видаленіПромокодиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem1 = new ToolStripMenuItem();
            завантадитиToolStripMenuItem1 = new ToolStripMenuItem();
            отриматиСпискиToolStripMenuItem = new ToolStripMenuItem();
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
            listBox_result.Location = new Point(12, 82);
            listBox_result.Name = "listBox_result";
            listBox_result.Size = new Size(776, 344);
            listBox_result.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 9F);
            button1.Location = new Point(632, 41);
            button1.Name = "button1";
            button1.Size = new Size(142, 25);
            button1.TabIndex = 2;
            button1.Text = "Отримати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addpromotionToolStripMenuItem, editpromotionToolStripMenuItem, deletepromotionToolStripMenuItem, файлToolStripMenuItem, отриматиСпискиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // addpromotionToolStripMenuItem
            // 
            addpromotionToolStripMenuItem.Font = new Font("Times New Roman", 7.8F);
            addpromotionToolStripMenuItem.Name = "addpromotionToolStripMenuItem";
            addpromotionToolStripMenuItem.Size = new Size(131, 24);
            addpromotionToolStripMenuItem.Text = "Додати пропозицію";
            addpromotionToolStripMenuItem.Click += addpromotionToolStripMenuItem_Click;
            // 
            // editpromotionToolStripMenuItem
            // 
            editpromotionToolStripMenuItem.Font = new Font("Times New Roman", 7.8F);
            editpromotionToolStripMenuItem.Name = "editpromotionToolStripMenuItem";
            editpromotionToolStripMenuItem.Size = new Size(152, 24);
            editpromotionToolStripMenuItem.Text = "Редагувати пропозицію";
            editpromotionToolStripMenuItem.Click += editpromotionToolStripMenuItem_Click;
            // 
            // deletepromotionToolStripMenuItem
            // 
            deletepromotionToolStripMenuItem.Font = new Font("Times New Roman", 7.8F);
            deletepromotionToolStripMenuItem.Name = "deletepromotionToolStripMenuItem";
            deletepromotionToolStripMenuItem.Size = new Size(143, 24);
            deletepromotionToolStripMenuItem.Text = "Видалити пропозицію";
            deletepromotionToolStripMenuItem.Click += deletepromotionToolStripMenuItem_Click;
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { активніПромокодиToolStripMenuItem, видаленіПромокодиToolStripMenuItem });
            файлToolStripMenuItem.Font = new Font("Times New Roman", 7.8F);
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(50, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // активніПромокодиToolStripMenuItem
            // 
            активніПромокодиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { зберегтиToolStripMenuItem, завантадитиToolStripMenuItem });
            активніПромокодиToolStripMenuItem.Name = "активніПромокодиToolStripMenuItem";
            активніПромокодиToolStripMenuItem.Size = new Size(224, 26);
            активніПромокодиToolStripMenuItem.Text = "Активні промокоди";
            // 
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.Size = new Size(159, 26);
            зберегтиToolStripMenuItem.Text = "Зберегти";
            зберегтиToolStripMenuItem.Click += зберегтиToolStripMenuItem_Click;
            // 
            // завантадитиToolStripMenuItem
            // 
            завантадитиToolStripMenuItem.Name = "завантадитиToolStripMenuItem";
            завантадитиToolStripMenuItem.Size = new Size(159, 26);
            завантадитиToolStripMenuItem.Text = "Завантажити";
            завантадитиToolStripMenuItem.Click += завантажитиToolStripMenuItem_Click;
            // 
            // видаленіПромокодиToolStripMenuItem
            // 
            видаленіПромокодиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { зберегтиToolStripMenuItem1, завантадитиToolStripMenuItem1 });
            видаленіПромокодиToolStripMenuItem.Name = "видаленіПромокодиToolStripMenuItem";
            видаленіПромокодиToolStripMenuItem.Size = new Size(224, 26);
            видаленіПромокодиToolStripMenuItem.Text = "Видалені промокоди";
            // 
            // зберегтиToolStripMenuItem1
            // 
            зберегтиToolStripMenuItem1.Name = "зберегтиToolStripMenuItem1";
            зберегтиToolStripMenuItem1.Size = new Size(224, 26);
            зберегтиToolStripMenuItem1.Text = "Зберегти";
            зберегтиToolStripMenuItem1.Click += зберегтиToolStripMenuItem1_Click;
            // 
            // завантадитиToolStripMenuItem1
            // 
            завантадитиToolStripMenuItem1.Name = "завантадитиToolStripMenuItem1";
            завантадитиToolStripMenuItem1.Size = new Size(224, 26);
            завантадитиToolStripMenuItem1.Text = "Завантажити";
            завантадитиToolStripMenuItem1.Click += завантадитиToolStripMenuItem1_Click;
            // 
            // отриматиСпискиToolStripMenuItem
            // 
            отриматиСпискиToolStripMenuItem.Font = new Font("Times New Roman", 7.8F);
            отриматиСпискиToolStripMenuItem.Name = "отриматиСпискиToolStripMenuItem";
            отриматиСпискиToolStripMenuItem.Size = new Size(118, 24);
            отриматиСпискиToolStripMenuItem.Text = "Отримати списки";
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
            Controls.Add(button1);
            Controls.Add(listBox_result);
            Controls.Add(comboBox_list);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FileManagePage";
            Text = "FileManagePage";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_list;
        private ListBox listBox_result;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addpromotionToolStripMenuItem;
        private ToolStripMenuItem editpromotionToolStripMenuItem;
        private ToolStripMenuItem deletepromotionToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem активніПромокодиToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private ToolStripMenuItem завантадитиToolStripMenuItem;
        private ToolStripMenuItem видаленіПромокодиToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem1;
        private ToolStripMenuItem завантадитиToolStripMenuItem1;
        private ToolStripMenuItem отриматиСпискиToolStripMenuItem;
        private Button button_log_exit;
    }
}