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
    public partial class ViewdetailsPromotionPage : Form
    {

        private string login;
        private string password;
        private bool isAuthenticated;

        // Конструктор класу, який ініціалізує новий екземпляр сторінки перегляду деталей промокоду
        public ViewdetailsPromotionPage(int id, string shop, string category, string description, string photo, DateTime data, string code, string login, string password, bool isAuthenticated)
        {
            InitializeComponent();
            textBox_shop.Text = shop;
            textBox_category.Text = category;
            textBox_description.Text = description;
            pictureBox_Photo.ImageLocation = photo;
            textBox_date.Text = data.ToString("dd.MM.yyyy");
            textBox_promocode.Text = code;
            this.password = password;
            this.login = login;
            this.isAuthenticated = isAuthenticated;

            if (isAuthenticated)
            {
                RegisteredUser registeredUser = RegisteredUser.registeredUsers.FirstOrDefault(u => u.Email == login && u.Password == password);
                Promotion promotion1 = new Promotion(id, shop, category, code, data, photo, description);
                registeredUser.ViewPromotionDetails(promotion1, isAuthenticated);
            }
            else
            {
                Guest guest = new Guest();
                Promotion promotion1 = new Promotion(id, shop, category, code, data, photo, description);
                guest.ViewPromotions(promotion1);
            }
        }


        private bool isPromoCodeGiven = false;

        // Метод зміни тексту кнопки "Вийти" / "Реєстрація/авторизація", що викликається при завантаженні сторінки перегляду деталей промокоду
        private void ViewdetailsPromotionPage_Load(object sender, EventArgs e)
        {
            if (isAuthenticated)
            {
                button_log_exit.Text = "Вийти";
            }
            else
            {
                button_log_exit.Text = "Реєстрація/авторизація";
            }
        }

        // Метод отримання промокоду, що викликається при натисканні кнопки "Отримати промокод"
        private void button_give_promocode_Click(object sender, EventArgs e)
        {
            if (isAuthenticated)
            {
                RegisteredUser registeredUser = RegisteredUser.registeredUsers.FirstOrDefault(u => u.Email == login && u.Password == password);

                textBox_promocode.Visible = true;
                label_code.Visible = true;
                isPromoCodeGiven = true;
            }
            else
            {

                MessageBox.Show("Для необхідно авторизуватися!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод використання промокоду, що викликається при натисканні кнопки "Використати промокод"
        private void button_use_promocode_Click(object sender, EventArgs e)
        {
            if (isAuthenticated)
            {
                if (isPromoCodeGiven)
                {

                    string promoCode = textBox_promocode.Text;

                    RegisteredUser registeredUser = RegisteredUser.registeredUsers.FirstOrDefault(u => u.Email == login && u.Password == password);

                    bool isPromotionUsed = registeredUser.UsePromotionCode(promoCode);

                    if (isPromotionUsed)
                    {
                        MessageBox.Show("Промокод успішно використано!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Цей промокод вже використано раніше!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Спочатку потрібно отримати промокод!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Для використання промокод необхідно авторизуватися!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Метод, що відповідає за перехід на сторінку пошуку акцій
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPromotionPage searchpage = new SearchPromotionPage(login, password, false);
            searchpage.Show();
            this.Hide();
        }

        // Метод виходу з системи, що відповідає за обробку події натискання кнопки "Вийти"
        private void button_log_exit_Click(object sender, EventArgs e)
        {
            Register_or_AuthenticatePage loginForm = new Register_or_AuthenticatePage(false);
            loginForm.Show();
            this.Hide();
        }
    }
}
