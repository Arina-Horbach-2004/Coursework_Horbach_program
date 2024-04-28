using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Promotional_offers.Classes;
using System.Windows.Forms;

namespace Coursework_Horbach_program__Form
{
    public partial class AdminPage : Form
    {
        private string login;
        private string password;
        private bool isAuthenticated;

        // Конструктор класу, який ініціалізує новий екземпляр сторінки адміністратора
        public AdminPage(bool isAuthenticated)
        {
            InitializeComponent();
            this.isAuthenticated = isAuthenticated;
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

        // Метод, який відповідає за перехід на сторінку видалення пропозиції
        private void deletepromotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletePromotionPage deletePromotionPage = new DeletePromotionPage();
            deletePromotionPage.Show();
            this.Hide();
        }

        // Метод виходу з системи, який викликається при натисканні кнопки "Вийти"
        private void button_log_exit_Click(object sender, EventArgs e)
        {
            Register_or_AuthenticatePage register = new Register_or_AuthenticatePage(false);
            register.Show();
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

        // Метод, який відповідає за перехід на сторінку отримання списків
        private void givelistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManagePage fileManagePage = new FileManagePage();
            fileManagePage.Show();
            this.Hide();
        }
    }
}
