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

        private void addpromotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPromotionPage add = new AddPromotionPage(isAuthenticated);
            add.Show();
            this.Hide();
        }

        private void editpromotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPromotionPage edit = new EditPromotionPage();
            edit.Show();
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

        private void button_log_exit_Click(object sender, EventArgs e)
        {
            Register_or_AuthenticatePage register = new Register_or_AuthenticatePage(false);
            register.Show();
            this.Hide();
        }

        private void отриматиСпискиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManagePage fileManagePage = new FileManagePage();
            fileManagePage.Show();
            this.Hide();
        }
    }
}
