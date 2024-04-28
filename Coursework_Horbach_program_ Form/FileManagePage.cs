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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Coursework_Horbach_program__Form
{
    public partial class FileManagePage : Form
    {
        private bool isAuthenticated;
        public FileManagePage()
        {
            InitializeComponent();
        }

        // Метод отримання списків, який викликається при натисканні кнопки "Отримати"
        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin("", "");

            if (comboBox_list.SelectedItem == "Дійсні промокоди")
            {
                var validPromotions = admin.GetValidPromotions();

                listBox_result.Items.Clear();
                if (validPromotions.Count == 0)
                {
                    MessageBox.Show("Список діючих промокодів порожній.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (var promotion in validPromotions)
                    {
                        listBox_result.Items.Add(promotion.ToString());
                    }
                }
            }
            else if (comboBox_list.SelectedItem == "Видалені промокоди")
            {
                var deletedPromotions = admin.GetDeletedPromotions();
                listBox_result.Items.Clear();
                if (deletedPromotions.Count == 0)
                {
                    MessageBox.Show("Список видалених промокодів порожній.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (var promotion in deletedPromotions)
                    {
                        listBox_result.Items.Add(promotion.ToString());
                    }
                }
            }
            else if (comboBox_list.SelectedItem == "Зареєстровані користувачі")
            {
                var registeredUsers = admin.GetRegisteredUsers();

                listBox_result.Items.Clear();

                if (registeredUsers.Count == 0)
                {
                    MessageBox.Show("Список зареєстрованих користувачі порожній.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    foreach (var user in registeredUsers)
                    {
                        listBox_result.Items.Add(user.Get_Full_Info());
                    }
                }
            }
        }

        // Метод, який відповідає за перехід на сторінку додавання пропозиції
        private void addpromotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPromotionPage addPromotion = new AddPromotionPage(isAuthenticated);
            addPromotion.Show();
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
            DeletePromotionPage delete = new DeletePromotionPage();
            delete.Show();
            delete.Hide();
        }

        // Метод виходу з системи, який викликається при натисканні кнопки "Вийти"
        private void button_log_exit_Click(object sender, EventArgs e)
        {
            Register_or_AuthenticatePage acctive = new Register_or_AuthenticatePage(false);
            acctive.Show();
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
        private void завантадитиToolStripMenuItem1_Click(object sender, EventArgs e)
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
    }
}
