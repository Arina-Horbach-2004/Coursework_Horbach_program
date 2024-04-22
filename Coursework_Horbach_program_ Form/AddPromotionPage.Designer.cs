namespace Coursework_Horbach_program__Form
{
    partial class AddPromotionPage
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
            button_add_photo = new Button();
            pictureBox_photo = new PictureBox();
            dateTimePicker_data = new DateTimePicker();
            comboBox_category = new ComboBox();
            textBox_description = new TextBox();
            textBox_promocode = new TextBox();
            textBox_shop = new TextBox();
            textBox_ID = new TextBox();
            label_description = new Label();
            label_data = new Label();
            label_promocode = new Label();
            label_category = new Label();
            label_shop = new Label();
            label_ID = new Label();
            menuStrip1 = new MenuStrip();
            addpromotionToolStripMenuItem = new ToolStripMenuItem();
            editpromotionToolStripMenuItem = new ToolStripMenuItem();
            deletepromotionToolStripMenuItem = new ToolStripMenuItem();
            файлToolStripMenuItem = new ToolStripMenuItem();
            активніПромокодиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            завантажитиToolStripMenuItem = new ToolStripMenuItem();
            видаленіПромокодиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem1 = new ToolStripMenuItem();
            завантажитиToolStripMenuItem1 = new ToolStripMenuItem();
            отриматиСпискиToolStripMenuItem = new ToolStripMenuItem();
            button_log_exit = new Button();
            button_save = new Button();
            button_clear = new Button();
            button_clone = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_photo).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button_add_photo
            // 
            button_add_photo.Font = new Font("Times New Roman", 13.8F);
            button_add_photo.Location = new Point(582, 215);
            button_add_photo.Name = "button_add_photo";
            button_add_photo.Size = new Size(151, 67);
            button_add_photo.TabIndex = 43;
            button_add_photo.Text = "Додати фото";
            button_add_photo.UseVisualStyleBackColor = true;
            button_add_photo.Click += button_add_photo_Click;
            // 
            // pictureBox_photo
            // 
            pictureBox_photo.Location = new Point(461, 68);
            pictureBox_photo.Name = "pictureBox_photo";
            pictureBox_photo.Size = new Size(300, 141);
            pictureBox_photo.TabIndex = 42;
            pictureBox_photo.TabStop = false;
            // 
            // dateTimePicker_data
            // 
            dateTimePicker_data.Font = new Font("Times New Roman", 13.8F);
            dateTimePicker_data.Location = new Point(220, 290);
            dateTimePicker_data.Name = "dateTimePicker_data";
            dateTimePicker_data.Size = new Size(326, 34);
            dateTimePicker_data.TabIndex = 41;
            // 
            // comboBox_category
            // 
            comboBox_category.Font = new Font("Times New Roman", 13.8F);
            comboBox_category.FormattingEnabled = true;
            comboBox_category.Location = new Point(220, 183);
            comboBox_category.Name = "comboBox_category";
            comboBox_category.Size = new Size(181, 34);
            comboBox_category.TabIndex = 40;
            // 
            // textBox_description
            // 
            textBox_description.Font = new Font("Times New Roman", 13.8F);
            textBox_description.Location = new Point(220, 348);
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(326, 34);
            textBox_description.TabIndex = 39;
            // 
            // textBox_promocode
            // 
            textBox_promocode.Font = new Font("Times New Roman", 13.8F);
            textBox_promocode.Location = new Point(220, 234);
            textBox_promocode.Name = "textBox_promocode";
            textBox_promocode.Size = new Size(181, 34);
            textBox_promocode.TabIndex = 38;
            // 
            // textBox_shop
            // 
            textBox_shop.Font = new Font("Times New Roman", 13.8F);
            textBox_shop.Location = new Point(220, 121);
            textBox_shop.Name = "textBox_shop";
            textBox_shop.Size = new Size(181, 34);
            textBox_shop.TabIndex = 37;
            // 
            // textBox_ID
            // 
            textBox_ID.Font = new Font("Times New Roman", 13.8F);
            textBox_ID.Location = new Point(220, 69);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(181, 34);
            textBox_ID.TabIndex = 36;
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Font = new Font("Times New Roman", 13.8F);
            label_description.Location = new Point(137, 348);
            label_description.Name = "label_description";
            label_description.Size = new Size(69, 26);
            label_description.TabIndex = 35;
            label_description.Text = "Опис:";
            // 
            // label_data
            // 
            label_data.AutoSize = true;
            label_data.Font = new Font("Times New Roman", 13.8F);
            label_data.Location = new Point(40, 296);
            label_data.Name = "label_data";
            label_data.Size = new Size(174, 26);
            label_data.TabIndex = 34;
            label_data.Text = "Дата закінчення:";
            // 
            // label_promocode
            // 
            label_promocode.AutoSize = true;
            label_promocode.Font = new Font("Times New Roman", 13.8F);
            label_promocode.Location = new Point(95, 237);
            label_promocode.Name = "label_promocode";
            label_promocode.Size = new Size(117, 26);
            label_promocode.TabIndex = 33;
            label_promocode.Text = "Промокод:";
            // 
            // label_category
            // 
            label_category.AutoSize = true;
            label_category.Font = new Font("Times New Roman", 13.8F);
            label_category.Location = new Point(95, 183);
            label_category.Name = "label_category";
            label_category.Size = new Size(111, 26);
            label_category.TabIndex = 32;
            label_category.Text = "Категорія:";
            // 
            // label_shop
            // 
            label_shop.AutoSize = true;
            label_shop.Font = new Font("Times New Roman", 13.8F);
            label_shop.Location = new Point(95, 121);
            label_shop.Name = "label_shop";
            label_shop.Size = new Size(99, 26);
            label_shop.TabIndex = 31;
            label_shop.Text = "Магазин:";
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Font = new Font("Times New Roman", 13.8F);
            label_ID.Location = new Point(110, 72);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(42, 26);
            label_ID.TabIndex = 30;
            label_ID.Text = "ID:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addpromotionToolStripMenuItem, editpromotionToolStripMenuItem, deletepromotionToolStripMenuItem, файлToolStripMenuItem, отриматиСпискиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 44;
            menuStrip1.Text = "menuStrip1";
            // 
            // addpromotionToolStripMenuItem
            // 
            addpromotionToolStripMenuItem.Font = new Font("Times New Roman", 7.8F);
            addpromotionToolStripMenuItem.Name = "addpromotionToolStripMenuItem";
            addpromotionToolStripMenuItem.Size = new Size(131, 24);
            addpromotionToolStripMenuItem.Text = "Додати пропозицію";
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
            активніПромокодиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { зберегтиToolStripMenuItem, завантажитиToolStripMenuItem });
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
            // завантажитиToolStripMenuItem
            // 
            завантажитиToolStripMenuItem.Name = "завантажитиToolStripMenuItem";
            завантажитиToolStripMenuItem.Size = new Size(159, 26);
            завантажитиToolStripMenuItem.Text = "Завантажити";
            завантажитиToolStripMenuItem.Click += завантажитиToolStripMenuItem_Click;
            // 
            // видаленіПромокодиToolStripMenuItem
            // 
            видаленіПромокодиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { зберегтиToolStripMenuItem1, завантажитиToolStripMenuItem1 });
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
            // завантажитиToolStripMenuItem1
            // 
            завантажитиToolStripMenuItem1.Name = "завантажитиToolStripMenuItem1";
            завантажитиToolStripMenuItem1.Size = new Size(224, 26);
            завантажитиToolStripMenuItem1.Text = "Завантажити";
            завантажитиToolStripMenuItem1.Click += завантажитиToolStripMenuItem1_Click;
            // 
            // отриматиСпискиToolStripMenuItem
            // 
            отриматиСпискиToolStripMenuItem.Font = new Font("Times New Roman", 7.8F);
            отриматиСпискиToolStripMenuItem.Name = "отриматиСпискиToolStripMenuItem";
            отриматиСпискиToolStripMenuItem.Size = new Size(121, 24);
            отриматиСпискиToolStripMenuItem.Text = "Отримати списки ";
            отриматиСпискиToolStripMenuItem.Click += отриматиСпискиToolStripMenuItem_Click;
            // 
            // button_log_exit
            // 
            button_log_exit.Font = new Font("Times New Roman", 10.8F);
            button_log_exit.Location = new Point(635, 0);
            button_log_exit.Name = "button_log_exit";
            button_log_exit.Size = new Size(152, 28);
            button_log_exit.TabIndex = 45;
            button_log_exit.Text = "Вийти";
            button_log_exit.UseVisualStyleBackColor = true;
            button_log_exit.Click += button_log_exit_Click;
            // 
            // button_save
            // 
            button_save.Font = new Font("Times New Roman", 13.8F);
            button_save.Location = new Point(599, 350);
            button_save.Name = "button_save";
            button_save.Size = new Size(130, 37);
            button_save.TabIndex = 46;
            button_save.Text = "Зберегти";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_clear
            // 
            button_clear.Font = new Font("Times New Roman", 13.8F);
            button_clear.Location = new Point(599, 401);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(130, 37);
            button_clear.TabIndex = 47;
            button_clear.Text = "Очистити";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // button_clone
            // 
            button_clone.Font = new Font("Times New Roman", 13.8F);
            button_clone.Location = new Point(228, 401);
            button_clone.Name = "button_clone";
            button_clone.Size = new Size(307, 35);
            button_clone.TabIndex = 48;
            button_clone.Text = "Створити копію промокоду";
            button_clone.UseVisualStyleBackColor = true;
            button_clone.Click += button_clone_Click;
            // 
            // AddPromotionPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_clone);
            Controls.Add(button_clear);
            Controls.Add(button_save);
            Controls.Add(button_log_exit);
            Controls.Add(button_add_photo);
            Controls.Add(pictureBox_photo);
            Controls.Add(dateTimePicker_data);
            Controls.Add(comboBox_category);
            Controls.Add(textBox_description);
            Controls.Add(textBox_promocode);
            Controls.Add(textBox_shop);
            Controls.Add(textBox_ID);
            Controls.Add(label_description);
            Controls.Add(label_data);
            Controls.Add(label_promocode);
            Controls.Add(label_category);
            Controls.Add(label_shop);
            Controls.Add(label_ID);
            Controls.Add(menuStrip1);
            Name = "AddPromotionPage";
            Text = "AddPromotionPage";
            Load += AddPromotionPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_photo).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_add_photo;
        private PictureBox pictureBox_photo;
        private DateTimePicker dateTimePicker_data;
        private ComboBox comboBox_category;
        private TextBox textBox_description;
        private TextBox textBox_promocode;
        private TextBox textBox_shop;
        private TextBox textBox_ID;
        private Label label_description;
        private Label label_data;
        private Label label_promocode;
        private Label label_category;
        private Label label_shop;
        private Label label_ID;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addpromotionToolStripMenuItem;
        private ToolStripMenuItem editpromotionToolStripMenuItem;
        private ToolStripMenuItem deletepromotionToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem отриматиСпискиToolStripMenuItem;
        private ToolStripMenuItem активніПромокодиToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private ToolStripMenuItem завантажитиToolStripMenuItem;
        private ToolStripMenuItem видаленіПромокодиToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem1;
        private ToolStripMenuItem завантажитиToolStripMenuItem1;
        private Button button_log_exit;
        private Button button_save;
        private Button button_clear;
        private Button button_clone;
    }
}