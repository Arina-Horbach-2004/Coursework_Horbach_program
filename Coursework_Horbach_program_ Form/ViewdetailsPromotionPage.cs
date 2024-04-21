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

        private void acctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcctionPage acctionPage = new AcctionPage(login, password, isAuthenticated);
            acctionPage.Show();
            this.Hide();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPromotionPage searchpage = new SearchPromotionPage(login, password, false);
            searchpage.Show();
            this.Hide();
        }

        private void button_log_exit_Click(object sender, EventArgs e)
        {
            Register_or_AuthenticatePage loginForm = new Register_or_AuthenticatePage(false);
            loginForm.Show();
            this.Hide();
        }
    }
}
