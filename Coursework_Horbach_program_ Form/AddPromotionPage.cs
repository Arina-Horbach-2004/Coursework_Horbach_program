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
    public partial class AddPromotionPage : Form
    {
        // Поле для визначення, чи користувач автентифікований
        private bool isAuthenticated;

        // Конструктор класу, який ініціалізує новий екземпляр сторінки додавання пропозиції
        public AddPromotionPage(bool isAuthenticated)
        {
            InitializeComponent();
            this.isAuthenticated = isAuthenticated;
        }

        private string selectedImagePath = "";

        // Метод для додавання фото, який викликається при натисканні кнопки "Додати фото"
        private void button_add_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Зображення (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                try
                {
                    pictureBox_photo.Image = Image.FromFile(selectedImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка завантаження зображення: " + ex.Message);
                }
            }
        }

        // Метод збереження акції, який викликається при натисканні кнопки "Зберегти"
        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox_ID.Text);
                string store = textBox_shop.Text;
                string category = comboBox_category.SelectedItem.ToString();
                string promoCode = textBox_promocode.Text;
                DateTime expirationDate = dateTimePicker_data.Value;
                string photo = selectedImagePath;
                string description = textBox_description.Text;
                Admin admin = new Admin("", "");
                bool isPromotionCreated = admin.CreatePromotion(id, store, category, promoCode, expirationDate, photo, description);
                MessageBox.Show("Промокод створенно!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для очищення полів введення пропозиції
        private void ClearPromotionFields()
        {
            textBox_ID.Text = "";
            textBox_shop.Text = "";
            comboBox_category.SelectedIndex = -1;
            textBox_promocode.Text = "";
            dateTimePicker_data.Value = DateTime.Now;
            pictureBox_photo.Image = null;
        }

        // Метод, який викликається при завантаженні сторінки
        private void AddPromotionPage_Load(object sender, EventArgs e)
        {
            List<string> categories = new List<string>();
            categories.Add("Прикраси");
            categories.Add("Ігри");
            categories.Add("Їжа");
            categories.Add("Одяг та взуття");
            categories.Add("Зоотовари");
            categories.Add("Книги");
            categories.Add("Фільми та серіали");
            categories.Add("Музика");
            categories.Add("Косметика та догляд");

            comboBox_category.Items.Clear();

            foreach (string category in categories)
            {
                comboBox_category.Items.Add(category);
            }
        }

        // Метод клонування, який викликається при натисканні кнопки "Клонувати"
        private void button_clone_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox_ID.Text);
            string store = textBox_shop.Text;
            string category = comboBox_category.SelectedItem.ToString();
            string promoCode = textBox_promocode.Text;
            DateTime expirationDate = dateTimePicker_data.Value;
            string photo = selectedImagePath;
            string description = textBox_description.Text;

            Admin admin = new Admin("", "");

            var listPromotions = admin.GetValidPromotions();
            var promotion = listPromotions.FirstOrDefault(p => p.ID == id && p.Category == category && p.Shop == store && p.Code == promoCode && p.ExpiryDate == expirationDate && p.Photo == photo && p.Description == description);

            if (promotion != null)
            {
                Promotion clonedPromotion = new Promotion(id, store, category, promoCode, expirationDate, photo, description);

                var clonedPromotions = (Promotion)clonedPromotion.Clone();

                foreach (var property in typeof(Promotion).GetProperties())
                {
                    var value = property.GetValue(clonedPromotions);

                    property.SetValue(clonedPromotions, value);
                }

                textBox_ID.Text = clonedPromotions.ID.ToString();
                textBox_promocode.Text = clonedPromotions.Code;
                dateTimePicker_data.Value = clonedPromotions.ExpiryDate;
                textBox_shop.Text = clonedPromotions.Shop;
                pictureBox_photo.ImageLocation = clonedPromotions.Photo;
                comboBox_category.SelectedItem = clonedPromotions.Category;
                textBox_description.Text = clonedPromotions.Description;
                int id_new = int.Parse(textBox_ID.Text);
                string store_new = textBox_shop.Text;
                string category_new = comboBox_category.SelectedItem.ToString();
                string promoCode_new = textBox_promocode.Text;
                DateTime expirationDate_new = dateTimePicker_data.Value;
                string photo_new = selectedImagePath;
                string description_new = textBox_description.Text;
                bool isPromotionCreated1 = admin.CreatePromotion(id_new, store_new, category_new, promoCode_new, expirationDate_new, photo_new, description_new);
            }

            else
            {
                MessageBox.Show("Не вдалося створити акцію.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод очищення, який викликається при натисканні кнопки "Очистити"
        private void button_clear_Click(object sender, EventArgs e)
        {
            ClearPromotionFields();
        }

        // Метод виходу з системи, який викликається при натисканні кнопки "Вийти"
        private void button_log_exit_Click(object sender, EventArgs e)
        {
            Register_or_AuthenticatePage register = new Register_or_AuthenticatePage(false);
            register.Show();
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
        private void отриматиСпискиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManagePage fileManagePage = new FileManagePage();
            fileManagePage.Show();
            this.Hide();
        }
    }
}
