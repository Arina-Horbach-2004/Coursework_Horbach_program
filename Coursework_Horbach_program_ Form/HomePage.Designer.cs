namespace Coursework_Horbach_program__Form
{
    partial class HomePage
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
            головнаToolStripMenuItem = new ToolStripMenuItem();
            акціїToolStripMenuItem = new ToolStripMenuItem();
            пошукToolStripMenuItem = new ToolStripMenuItem();
            button_log_exit = new Button();
            panel_acction = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { головнаToolStripMenuItem, акціїToolStripMenuItem, пошукToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // головнаToolStripMenuItem
            // 
            головнаToolStripMenuItem.Font = new Font("Times New Roman", 10.8F);
            головнаToolStripMenuItem.Name = "головнаToolStripMenuItem";
            головнаToolStripMenuItem.Size = new Size(85, 24);
            головнаToolStripMenuItem.Text = "Головна";
            // 
            // акціїToolStripMenuItem
            // 
            акціїToolStripMenuItem.Font = new Font("Times New Roman", 10.8F);
            акціїToolStripMenuItem.Name = "акціїToolStripMenuItem";
            акціїToolStripMenuItem.Size = new Size(62, 24);
            акціїToolStripMenuItem.Text = "Акції";
            // 
            // пошукToolStripMenuItem
            // 
            пошукToolStripMenuItem.Font = new Font("Times New Roman", 10.8F);
            пошукToolStripMenuItem.Name = "пошукToolStripMenuItem";
            пошукToolStripMenuItem.Size = new Size(77, 24);
            пошукToolStripMenuItem.Text = "Пошук";
            // 
            // button_log_exit
            // 
            button_log_exit.Font = new Font("Times New Roman", 10.8F);
            button_log_exit.Location = new Point(590, 0);
            button_log_exit.Name = "button_log_exit";
            button_log_exit.Size = new Size(185, 28);
            button_log_exit.TabIndex = 1;
            button_log_exit.Text = "Реєстрація/авторизація";
            button_log_exit.UseVisualStyleBackColor = true;
            button_log_exit.Click += button_log_exit_Click;
            // 
            // panel_acction
            // 
            panel_acction.Location = new Point(0, 34);
            panel_acction.Name = "panel_acction";
            panel_acction.Size = new Size(800, 416);
            panel_acction.TabIndex = 2;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_acction);
            Controls.Add(button_log_exit);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem головнаToolStripMenuItem;
        private ToolStripMenuItem акціїToolStripMenuItem;
        private ToolStripMenuItem пошукToolStripMenuItem;
        private Button button_log_exit;
        private Panel panel_acction;
    }
}