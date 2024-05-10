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
using System;
using System.Linq;

namespace Coursework_Horbach_program__Form
{
    public partial class SearchPromotionPage : Form
    {

        private string login;
        private string password;
        private bool isAuthenticated;

        public SearchPromotionPage(string login, string password, bool isAuthenticated)
        {
            InitializeComponent();
            this.login = login;
            this.password = password;
            this.isAuthenticated = isAuthenticated;
        }

        // Метод пошуку акцій за категорією або ключовими словами, що викликається при натисканні кнопки "Пошук"
        private void button_search_Click(object sender, EventArgs e)
        {
            string category = comboBox_category.Text;
            string keywords = textBox_word.Text;
            if (string.IsNullOrWhiteSpace(category) && string.IsNullOrWhiteSpace(keywords))
            {
                MessageBox.Show("Будь ласка, введіть інформацію для пошуку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

            Admin admin = new Admin("", "");
            var listPromotions = admin.GetValidPromotions();
            panel_acction.Controls.Clear();
            if (isAuthenticated)
            {
                RegisteredUser registeredUser = RegisteredUser.registeredUsers.FirstOrDefault(u => u.Email == login && u.Password == password);
                var filteredPromotions1 = registeredUser.SearchPromotions(category, keywords, listPromotions);

                panel_acction.AutoScroll = true;
                int pictureBoxY = 14;
                int labelDescriptionY = 35;
                int buttonGoToActionY = 20;

                foreach (var promotion in filteredPromotions1)
                {
                    PictureBox pictureBox = new PictureBox();
                    Label labelDescription = new Label();
                    Button buttonGoToAction = new Button();

                    pictureBox.ImageLocation = promotion.Photo;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Location = new Point(15, pictureBoxY);
                    pictureBox.Width = 125;
                    pictureBox.Height = 62;
                    panel_acction.Controls.Add(pictureBox);

                    labelDescription.Text = promotion.Description;
                    labelDescription.Location = new Point(176, labelDescriptionY);
                    labelDescription.AutoSize = true;
                    labelDescription.Width = 67;
                    labelDescription.Height = 26;
                    panel_acction.Controls.Add(labelDescription);

                    buttonGoToAction.Text = "До акції";
                    buttonGoToAction.Tag = promotion;
                    buttonGoToAction.Location = new Point(656, buttonGoToActionY);
                    buttonGoToAction.Width = 101;
                    buttonGoToAction.Height = 41;
                    panel_acction.Controls.Add(buttonGoToAction);

                    buttonGoToAction.Click += buttonGoToAction_Click;

                    pictureBoxY += 100;
                    labelDescriptionY += 95;
                    buttonGoToActionY += 94;
                }

            }
            else
            {
                Guest guest = new Guest();
                var filteredPromotions2 = guest.SearchPromotions(category, keywords, listPromotions);

                panel_acction.AutoScroll = true;
                int pictureBoxY = 14;
                int labelDescriptionY = 35;
                int buttonGoToActionY = 20;

                foreach (var promotion in filteredPromotions2)
                {
                    PictureBox pictureBox = new PictureBox();
                    Label labelDescription = new Label();
                    Button buttonGoToAction = new Button();

                    pictureBox.ImageLocation = promotion.Photo;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Location = new Point(15, pictureBoxY);
                    pictureBox.Width = 125;
                    pictureBox.Height = 62;
                    panel_acction.Controls.Add(pictureBox);

                    labelDescription.Text = promotion.Description;
                    labelDescription.Location = new Point(176, labelDescriptionY);
                    labelDescription.AutoSize = true;
                    labelDescription.Width = 67;
                    labelDescription.Height = 26;
                    panel_acction.Controls.Add(labelDescription);

                    buttonGoToAction.Text = "До акції";
                    buttonGoToAction.Tag = promotion;
                    buttonGoToAction.Location = new Point(656, buttonGoToActionY);
                    buttonGoToAction.Width = 101;
                    buttonGoToAction.Height = 41;
                    panel_acction.Controls.Add(buttonGoToAction);
                    buttonGoToAction.Click += buttonGoToAction_Click;

                    pictureBoxY += 100;
                    labelDescriptionY += 95;
                    buttonGoToActionY += 94;
                }
            }

        }

        // Метод, що відповідає за обробку події натискання кнопки "До акції"
        private void buttonGoToAction_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Promotion promotion = (Promotion)button.Tag;

            ViewdetailsPromotionPage viewPromotion = new ViewdetailsPromotionPage(promotion.ID, promotion.Shop, promotion.Category, promotion.Description, promotion.Photo, promotion.ExpiryDate, promotion.Code, login, password, isAuthenticated);
            viewPromotion.Show();
            this.Hide();
        }

        // Метод, що викликається при завантаженні сторінки пошуку промокодів
        private void SearchPromotionPage_Load(object sender, EventArgs e)
        {
            if (isAuthenticated)
            {
                button_log_exit.Text = "Вийти";
            }
            else
            {
                button_log_exit.Text = "Реєстрація/авторизація";
            }
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

        // Метод, що відповідає за перехід на головну сторінку
        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAuthenticated)
            {
                HomePage home = new HomePage(login, password, isAuthenticated);
                home.Show();
                this.Hide();
            }
            else
            {
                HomePage home = new HomePage(login, password, isAuthenticated);
                home.Show();
                this.Hide();
            }
        }

        // Метод, що відповідає за перехід на сторінку з акціями
        private void acctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcctionPage acctionPage = new AcctionPage(login, password, isAuthenticated);
            acctionPage.Show();
            this.Hide();
        }

        // Метод переходу на сторінку регестрації/ авторизиції, при  натисканні кнопки "Вийти"
        private void button_log_exit_Click(object sender, EventArgs e)
        {
            Register_or_AuthenticatePage loginForm = new Register_or_AuthenticatePage(false);
            loginForm.Show();
            this.Hide();
        }
    }
}
