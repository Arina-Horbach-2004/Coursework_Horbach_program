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

        public AdminPage(bool isAuthenticated)
        {
            InitializeComponent();
            this.isAuthenticated = isAuthenticated;
        }

        private void addpromotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPromotionPage add = new AddPromotionPage();
            add.Show();
            this.Hide();
        }

        private void editpromotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPromotionPage edit = new EditPromotionPage();
            edit.Show();
            this.Hide();
        }

        private void deletepromotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletePromotionPage deletePromotionPage = new DeletePromotionPage();
            deletePromotionPage.Show();
            this.Hide();
        }

        private void button_log_exit_Click(object sender, EventArgs e)
        {
            Register_or_AuthenticatePage register = new Register_or_AuthenticatePage(false);
            register.Show();
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

        private void givelistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManagePage fileManagePage = new FileManagePage();
            fileManagePage.Show();
            this.Hide();
        }
    }
}
