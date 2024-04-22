namespace Coursework_Horbach_program__Form
{
    partial class SearchPromotionPage
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
            button_log_exit = new Button();
            textBox_word = new TextBox();
            comboBox_category = new ComboBox();
            button_search = new Button();
            panel_acction = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
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
            // 
            // button_log_exit
            // 
            button_log_exit.Font = new Font("Times New Roman", 10.8F);
            button_log_exit.Location = new Point(578, 0);
            button_log_exit.Name = "button_log_exit";
            button_log_exit.Size = new Size(197, 28);
            button_log_exit.TabIndex = 15;
            button_log_exit.Text = "Реєстрація/авторизація";
            button_log_exit.UseVisualStyleBackColor = true;
            button_log_exit.Click += button_log_exit_Click;
            // 
            // textBox_word
            // 
            textBox_word.Font = new Font("Times New Roman", 13.8F);
            textBox_word.Location = new Point(121, 70);
            textBox_word.Name = "textBox_word";
            textBox_word.Size = new Size(385, 34);
            textBox_word.TabIndex = 16;
            // 
            // comboBox_category
            // 
            comboBox_category.Font = new Font("Times New Roman", 13.8F);
            comboBox_category.FormattingEnabled = true;
            comboBox_category.Location = new Point(121, 123);
            comboBox_category.Name = "comboBox_category";
            comboBox_category.Size = new Size(385, 34);
            comboBox_category.TabIndex = 17;
            // 
            // button_search
            // 
            button_search.Font = new Font("Times New Roman", 13.8F);
            button_search.Location = new Point(600, 67);
            button_search.Name = "button_search";
            button_search.Size = new Size(130, 37);
            button_search.TabIndex = 18;
            button_search.Text = "Пошук";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // panel_acction
            // 
            panel_acction.AutoScroll = true;
            panel_acction.Location = new Point(0, 168);
            panel_acction.Name = "panel_acction";
            panel_acction.Size = new Size(800, 282);
            panel_acction.TabIndex = 19;
            // 
            // SearchPromotionPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_acction);
            Controls.Add(button_search);
            Controls.Add(comboBox_category);
            Controls.Add(textBox_word);
            Controls.Add(button_log_exit);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "SearchPromotionPage";
            Text = "SearchPromotionPage";
            Load += SearchPromotionPage_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homepageToolStripMenuItem;
        private ToolStripMenuItem acctionToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private Button button_log_exit;
        private TextBox textBox_word;
        private ComboBox comboBox_category;
        private Button button_search;
        private Panel panel_acction;
    }
}