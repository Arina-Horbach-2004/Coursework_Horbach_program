namespace Coursework_Horbach_program__Form
{
    partial class Register_or_AuthenticatePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_login = new TextBox();
            textBox_password = new TextBox();
            button_log = new Button();
            radioButton_authenticate = new RadioButton();
            radioButton_register = new RadioButton();
            label_login = new Label();
            label_password = new Label();
            label_title = new Label();
            menuStrip1 = new MenuStrip();
            homepageToolStripMenuItem = new ToolStripMenuItem();
            acctionToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_login
            // 
            textBox_login.Location = new Point(204, 150);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(369, 27);
            textBox_login.TabIndex = 0;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(204, 259);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(369, 27);
            textBox_password.TabIndex = 1;
            // 
            // button_log
            // 
            button_log.Font = new Font("Times New Roman", 10.8F);
            button_log.Location = new Point(341, 327);
            button_log.Name = "button_log";
            button_log.Size = new Size(121, 47);
            button_log.TabIndex = 2;
            button_log.Text = "Вхід";
            button_log.UseVisualStyleBackColor = true;
            button_log.Click += button_log_Click;
            // 
            // radioButton_authenticate
            // 
            radioButton_authenticate.AutoSize = true;
            radioButton_authenticate.Checked = true;
            radioButton_authenticate.Font = new Font("Times New Roman", 10.8F);
            radioButton_authenticate.Location = new Point(631, 62);
            radioButton_authenticate.Name = "radioButton_authenticate";
            radioButton_authenticate.Size = new Size(82, 24);
            radioButton_authenticate.TabIndex = 3;
            radioButton_authenticate.TabStop = true;
            radioButton_authenticate.Text = "Увійти";
            radioButton_authenticate.UseVisualStyleBackColor = true;
            radioButton_authenticate.CheckedChanged += radioButton_authenticate_CheckedChanged;
            // 
            // radioButton_register
            // 
            radioButton_register.AutoSize = true;
            radioButton_register.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButton_register.Location = new Point(631, 92);
            radioButton_register.Name = "radioButton_register";
            radioButton_register.Size = new Size(157, 24);
            radioButton_register.TabIndex = 4;
            radioButton_register.Text = "Зареєструватися";
            radioButton_register.UseVisualStyleBackColor = true;
            radioButton_register.CheckedChanged += radioButton_register_CheckedChanged;
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Font = new Font("Times New Roman", 10.8F);
            label_login.Location = new Point(204, 116);
            label_login.Name = "label_login";
            label_login.Size = new Size(55, 20);
            label_login.TabIndex = 5;
            label_login.Text = "Логін:";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Times New Roman", 10.8F);
            label_password.Location = new Point(204, 226);
            label_password.Name = "label_password";
            label_password.Size = new Size(69, 20);
            label_password.TabIndex = 6;
            label_password.Text = "Пароль:";
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_title.Location = new Point(341, 52);
            label_title.Name = "label_title";
            label_title.Size = new Size(71, 34);
            label_title.TabIndex = 7;
            label_title.Text = "Вхід";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homepageToolStripMenuItem, acctionToolStripMenuItem, searchToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // homepageToolStripMenuItem
            // 
            homepageToolStripMenuItem.Font = new Font("Times New Roman", 10.8F);
            homepageToolStripMenuItem.Name = "homepageToolStripMenuItem";
            homepageToolStripMenuItem.Size = new Size(85, 24);
            homepageToolStripMenuItem.Text = "Головна";
            homepageToolStripMenuItem.Click += homepageToolStripMenuItem_Click;
            // 
            // acctionToolStripMenuItem
            // 
            acctionToolStripMenuItem.Font = new Font("Times New Roman", 10.8F);
            acctionToolStripMenuItem.Name = "acctionToolStripMenuItem";
            acctionToolStripMenuItem.Size = new Size(62, 24);
            acctionToolStripMenuItem.Text = "Акції";
            acctionToolStripMenuItem.Click += acctionToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Font = new Font("Times New Roman", 10.8F);
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(77, 24);
            searchToolStripMenuItem.Text = "Пошук";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // Register_or_AuthenticatePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_title);
            Controls.Add(label_password);
            Controls.Add(label_login);
            Controls.Add(radioButton_register);
            Controls.Add(radioButton_authenticate);
            Controls.Add(button_log);
            Controls.Add(textBox_password);
            Controls.Add(textBox_login);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Register_or_AuthenticatePage";
            Text = "Register or Authenticate Page";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_login; // Поле для введення логіну        
        private TextBox textBox_password; // Поле для введення паролю
        private Button button_log; // Кнопка для входу або реєстрації користувача
        private RadioButton radioButton_authenticate; // Перемикач для вибору методу аутентифікації
        private RadioButton radioButton_register; // Перемикач для вибору методу реєстрації
        private Label label_login; // Підпис для поля введення логіну
        private Label label_password; // Підпис для поля введення паролю
        private Label label_title;  // Підпис з заголовком форми
        private MenuStrip menuStrip1; // Меню для навігації по програмі        
        private ToolStripMenuItem homepageToolStripMenuItem; // Пункт меню для переходу на домашню сторінку        
        private ToolStripMenuItem acctionToolStripMenuItem; // Пункт меню для доступу до функцій програми              
        private ToolStripMenuItem searchToolStripMenuItem; // Пункт меню для запуску функції пошуку
    }
}
