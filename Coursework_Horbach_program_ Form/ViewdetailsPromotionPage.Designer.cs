namespace Coursework_Horbach_program__Form
{
    partial class ViewdetailsPromotionPage
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
            menuStrip1 = new MenuStrip();
            homepageToolStripMenuItem = new ToolStripMenuItem();
            acctionToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            pictureBox_Photo = new PictureBox();
            label_description = new Label();
            label_date = new Label();
            label_shop = new Label();
            textBox_description = new TextBox();
            textBox_shop = new TextBox();
            textBox_date = new TextBox();
            label_category = new Label();
            label_code = new Label();
            textBox_category = new TextBox();
            textBox_promocode = new TextBox();
            button_use_promocode = new Button();
            button_give_promocode = new Button();
            button_log_exit = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Photo).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Times New Roman", 10.8F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homepageToolStripMenuItem, acctionToolStripMenuItem, searchToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homepageToolStripMenuItem
            // 
            homepageToolStripMenuItem.Name = "homepageToolStripMenuItem";
            homepageToolStripMenuItem.Size = new Size(85, 24);
            homepageToolStripMenuItem.Text = "Головна";
            homepageToolStripMenuItem.Click += homepageToolStripMenuItem_Click;
            // 
            // acctionToolStripMenuItem
            // 
            acctionToolStripMenuItem.Name = "acctionToolStripMenuItem";
            acctionToolStripMenuItem.Size = new Size(62, 24);
            acctionToolStripMenuItem.Text = "Акції";
            acctionToolStripMenuItem.Click += acctionToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(77, 24);
            searchToolStripMenuItem.Text = "Пошук";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // pictureBox_Photo
            // 
            pictureBox_Photo.Location = new Point(246, 41);
            pictureBox_Photo.Name = "pictureBox_Photo";
            pictureBox_Photo.Size = new Size(300, 141);
            pictureBox_Photo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Photo.TabIndex = 1;
            pictureBox_Photo.TabStop = false;
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Font = new Font("Times New Roman", 13.8F);
            label_description.Location = new Point(94, 202);
            label_description.Name = "label_description";
            label_description.Size = new Size(120, 26);
            label_description.TabIndex = 2;
            label_description.Text = "Опис акції:";
            // 
            // label_date
            // 
            label_date.AutoSize = true;
            label_date.Font = new Font("Times New Roman", 13.8F);
            label_date.Location = new Point(40, 295);
            label_date.Name = "label_date";
            label_date.Size = new Size(174, 26);
            label_date.TabIndex = 3;
            label_date.Text = "Дата закінчення:";
            // 
            // label_shop
            // 
            label_shop.AutoSize = true;
            label_shop.Font = new Font("Times New Roman", 13.8F);
            label_shop.Location = new Point(94, 250);
            label_shop.Name = "label_shop";
            label_shop.Size = new Size(99, 26);
            label_shop.TabIndex = 4;
            label_shop.Text = "Магазин:";
            // 
            // textBox_description
            // 
            textBox_description.Font = new Font("Times New Roman", 13.8F);
            textBox_description.Location = new Point(220, 199);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(555, 37);
            textBox_description.TabIndex = 5;
            // 
            // textBox_shop
            // 
            textBox_shop.Font = new Font("Times New Roman", 13.8F);
            textBox_shop.Location = new Point(219, 250);
            textBox_shop.Multiline = true;
            textBox_shop.Name = "textBox_shop";
            textBox_shop.Size = new Size(181, 27);
            textBox_shop.TabIndex = 6;
            // 
            // textBox_date
            // 
            textBox_date.Font = new Font("Times New Roman", 13.8F);
            textBox_date.Location = new Point(220, 295);
            textBox_date.Multiline = true;
            textBox_date.Name = "textBox_date";
            textBox_date.Size = new Size(181, 34);
            textBox_date.TabIndex = 7;
            // 
            // label_category
            // 
            label_category.AutoSize = true;
            label_category.Font = new Font("Times New Roman", 13.8F);
            label_category.Location = new Point(461, 253);
            label_category.Name = "label_category";
            label_category.Size = new Size(111, 26);
            label_category.TabIndex = 8;
            label_category.Text = "Категорія:";
            // 
            // label_code
            // 
            label_code.AutoSize = true;
            label_code.Font = new Font("Times New Roman", 13.8F);
            label_code.Location = new Point(461, 312);
            label_code.Name = "label_code";
            label_code.Size = new Size(117, 26);
            label_code.TabIndex = 9;
            label_code.Text = "Промокод:";
            label_code.Visible = false;
            // 
            // textBox_category
            // 
            textBox_category.Font = new Font("Times New Roman", 13.8F);
            textBox_category.Location = new Point(586, 250);
            textBox_category.Multiline = true;
            textBox_category.Name = "textBox_category";
            textBox_category.Size = new Size(181, 34);
            textBox_category.TabIndex = 10;
            // 
            // textBox_promocode
            // 
            textBox_promocode.Font = new Font("Times New Roman", 13.8F);
            textBox_promocode.Location = new Point(586, 304);
            textBox_promocode.Multiline = true;
            textBox_promocode.Name = "textBox_promocode";
            textBox_promocode.Size = new Size(181, 34);
            textBox_promocode.TabIndex = 11;
            textBox_promocode.Visible = false;
            // 
            // button_use_promocode
            // 
            button_use_promocode.Font = new Font("Times New Roman", 13.8F);
            button_use_promocode.Location = new Point(487, 378);
            button_use_promocode.Name = "button_use_promocode";
            button_use_promocode.Size = new Size(280, 41);
            button_use_promocode.TabIndex = 12;
            button_use_promocode.Text = "Використати промокод";
            button_use_promocode.UseVisualStyleBackColor = true;
            button_use_promocode.Click += button_use_promocode_Click;
            // 
            // button_give_promocode
            // 
            button_give_promocode.Font = new Font("Times New Roman", 13.8F);
            button_give_promocode.Location = new Point(120, 378);
            button_give_promocode.Name = "button_give_promocode";
            button_give_promocode.Size = new Size(280, 41);
            button_give_promocode.TabIndex = 13;
            button_give_promocode.Text = "Отримати промокод";
            button_give_promocode.UseVisualStyleBackColor = true;
            button_give_promocode.Click += button_give_promocode_Click;
            // 
            // button_log_exit
            // 
            button_log_exit.Font = new Font("Times New Roman", 10.8F);
            button_log_exit.Location = new Point(578, 0);
            button_log_exit.Name = "button_log_exit";
            button_log_exit.Size = new Size(197, 28);
            button_log_exit.TabIndex = 14;
            button_log_exit.Text = "Реєстрація/авторизація";
            button_log_exit.UseVisualStyleBackColor = true;
            button_log_exit.Click += button_log_exit_Click;
            // 
            // ViewdetailsPromotionPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_log_exit);
            Controls.Add(button_give_promocode);
            Controls.Add(button_use_promocode);
            Controls.Add(textBox_promocode);
            Controls.Add(textBox_category);
            Controls.Add(label_code);
            Controls.Add(label_category);
            Controls.Add(textBox_date);
            Controls.Add(textBox_shop);
            Controls.Add(textBox_description);
            Controls.Add(label_shop);
            Controls.Add(label_date);
            Controls.Add(label_description);
            Controls.Add(pictureBox_Photo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ViewdetailsPromotionPage";
            Text = "ViewdetailsPromotionPage";
            Load += ViewdetailsPromotionPage_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Photo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;   // Меню для навігації по програмі
        private ToolStripMenuItem homepageToolStripMenuItem; // Пункт меню для переходу на домашню сторінку
        private ToolStripMenuItem acctionToolStripMenuItem; // Пункт меню для переходу на сторінка перегляду акцій
        private ToolStripMenuItem searchToolStripMenuItem; // Пункт меню для  переходу на сторінку пошуку
        private PictureBox pictureBox_Photo; // Відображення фотографії промокоду
        private Label label_description; // Мітка для опису промокоду               
        private Label label_date; // Мітка для відображення дати закінчення дії промокоду        
        private Label label_shop; // Мітка для відображення магазину        
        private TextBox textBox_description; // Поле для відображення опису промокоду        
        private TextBox textBox_shop; // Поле для відображення назви магазину        
        private TextBox textBox_date; // Поле для відображення дати закінчення дії промокоду        
        private Label label_category; // Мітка для відображення категорії промокоду        
        private Label label_code; // Мітка для відображення коду промокоду       
        private TextBox textBox_category;  // Поле для відображення категорії промокоду       
        private TextBox textBox_promocode; // Поле для відображення коду промокоду        
        private Button button_use_promocode; // Кнопка для використання промокоду       
        private Button button_give_promocode; // Кнопка для перегляду промокоду
        private Button button_log_exit; // Кнопка виходу або входу в систему

    }
}