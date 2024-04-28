using Promotional_offers.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_Horbach_program__Form
{
    public partial class DeletePromotionPage : Form
    {
        private bool isAuthenticated;
        public DeletePromotionPage()
        {
            InitializeComponent();
        }

        // Метод пошуку пропозиції за допомогою ID, що викликається при натисканні кнопки "Пошук"
        private void button_search_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(textBox_ID.Text, out id))
            {
                MessageBox.Show("Будь ласка, введіть дійсний ідентифікатор рекламної акції.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Admin admin = new Admin("", "");

            var validPromotions = admin.GetValidPromotions();

            var promotion = validPromotions.FirstOrDefault(p => p.ID == id);
            if (promotion == null)
            {
                MessageBox.Show("Промокод із зазначеним ID не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listBox_acction_details.Items.Clear();

            listBox_acction_details.Items.Add(promotion.ToString());
            listBox_acction_details.Visible = true;
            button_delete.Visible = true;
        }

        // Метод видалення пропозиції, що викликається при натисканні кнопки "Видалити"
        private void button_delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox_ID.Text);
            Admin admin = new Admin("", "");
            bool isPromotionEdited = admin.DeletePromotion(id);

            if (isPromotionEdited)
            {
                MessageBox.Show("Пропозицію видалено!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox_acction_details.Items.Clear();
            }
            else
            {
                MessageBox.Show("Помилка збереження змін.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод, який відповідає за перехід на сторінку додавання пропозиції
        private void addpromotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPromotionPage add = new AddPromotionPage(isAuthenticated);
            add.Show();
            this.Hide();
        }

        // Метод, який відповідає за перехід на сторінку редагування пропозиції
        private void editpromotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPromotionPage edit = new EditPromotionPage();
            edit.Show();
            this.Hide();
        }

        // Метод, який відповідає за збереження активних промокодів в файл json
        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json";
            saveFileDialog.Title = "Save JSON File";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                string filepath = saveFileDialog.FileName;
                Admin admin = new Admin("", "");
                admin.SavePromotionsToJson(filepath);
            }
        }

        // Метод, який відповідає за завантаження активних промокодів з файлу json
        private void завантажитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                string filepath = openFileDialog.FileName;
                Admin admin = new Admin("", "");
                admin.LoadPromotionsFromJson(filepath);
            }
        }

        // Метод, який відповідає за збереження видаленних промокодів в файл json
        private void зберегтиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json";
            saveFileDialog.Title = "Save JSON File";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                string filepath = saveFileDialog.FileName;
                Admin admin = new Admin("", "");
                admin.SaveDeletedPromotionsToJson(filepath);
            }
        }

        // Метод, який відповідає за завантаження видалених промокодів з файлу json
        private void завантажитиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            openFileDialog.Title = "Open JSON File";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                string filepath = openFileDialog.FileName;
                Admin admin = new Admin("", "");
                admin.LoadDeletedPromotionsFromJson(filepath);
            }
        }

        // Метод виходу з системи, який викликається при натисканні кнопки "Вийти"
        private void button_log_exit_Click(object sender, EventArgs e)
        {
            Register_or_AuthenticatePage register = new Register_or_AuthenticatePage(false);
            register.Show();
            this.Hide();
        }

        // Метод, який відповідає за перехід на сторінку отримання списків
        private void отриматиСпискиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManagePage fileManagePage = new FileManagePage();
            fileManagePage.Show();
            this.Hide();
        }
    }
}
