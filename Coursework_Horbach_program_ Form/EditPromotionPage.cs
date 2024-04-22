using Promotional_offers.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_Horbach_program__Form
{
    public partial class EditPromotionPage : Form
    {
        private bool isAuthenticated;

        public EditPromotionPage()
        {
            InitializeComponent();
        }

        private void button_add_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Зображення (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    pictureBox_photo.Image = Image.FromFile(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка завантаження зображення: " + ex.Message);
                }
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(textBox_ID.Text, out id))
            {
                MessageBox.Show("Введіть дійсний ідентифікатор рекламної акції.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Admin admin = new Admin("", "");

            var validPromotions = admin.GetValidPromotions();

            var promotion = validPromotions.FirstOrDefault(p => p.ID == id);
            if (promotion == null)
            {
                MessageBox.Show("Промокод с указанным ID не найден", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBox_ID.Text = promotion.ID.ToString();
            textBox_promocode.Text = promotion.Code;
            dateTimePicker_data.Value = promotion.ExpiryDate;
            textBox_shop.Text = promotion.Shop;
            pictureBox_photo.ImageLocation = promotion.Photo;
            comboBox_category.SelectedItem = promotion.Category;
            textBox_description.Text = promotion.Description;

            textBox_shop.Visible = true;
            textBox_description.Visible = true;
            textBox_promocode.Visible = true;
            dateTimePicker_data.Visible = true;
            pictureBox_photo.Visible = true;
            comboBox_category.Visible = true;
            label_shop.Visible = true;
            label_category.Visible = true;
            label_promocode.Visible = true;
            label_data.Visible = true;
            label_description.Visible = true;
            button_add_photo.Visible = true;
            button_save.Visible = true;

            if (!string.IsNullOrEmpty(promotion.Photo) && File.Exists(promotion.Photo))
            {
                pictureBox_photo.ImageLocation = promotion.Photo;
            }
            else
            {
                MessageBox.Show("Зображення не знайдено або шлях до зображення недійсний.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearPromotionFields()
        {
            textBox_ID.Text = "";
            textBox_shop.Text = "";
            comboBox_category.SelectedIndex = -1;
            textBox_promocode.Text = "";
            dateTimePicker_data.Value = DateTime.Now;
            pictureBox_photo.Image = null;
            textBox_description.Text = "";
        }

        private void EditPromotionPage_Load(object sender, EventArgs e)
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

            comboBox_category.Items.Clear();

            foreach (string category in categories)
            {
                comboBox_category.Items.Add(category);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox_ID.Text);
                string store = textBox_shop.Text;
                string category = comboBox_category.SelectedItem.ToString();
                string promoCode = textBox_promocode.Text;
                DateTime expirationDate = dateTimePicker_data.Value;
                string photo = pictureBox_photo.ImageLocation;
                string description = textBox_description.Text;

                Admin admin = new Admin("", "");
                bool isPromotionEdited = admin.EditPromotion(id, store, category, promoCode, expirationDate, photo, description);

                if (isPromotionEdited)
                {
                    MessageBox.Show("Зміни успішно збережено.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearPromotionFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void addpromotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPromotionPage edit = new AddPromotionPage(isAuthenticated);
            edit.Show();
            this.Hide();
        }

        private void deletepromotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletePromotionPage deletePromotionPage = new DeletePromotionPage();
            deletePromotionPage.Show();
            this.Hide();
        }

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

        private void отриматиСпискиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManagePage fileManagePage = new FileManagePage();
            fileManagePage.Show();
            this.Hide();
        }

        private void button_log_exit_Click(object sender, EventArgs e)
        {
            Register_or_AuthenticatePage register = new Register_or_AuthenticatePage(false);
            register.Show();
            this.Hide();
        }
    }
}
