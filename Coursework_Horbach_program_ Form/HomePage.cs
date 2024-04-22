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
    public partial class HomePage : Form
    {
        private string login;
        private string password;
        private bool isAuthenticated;

        public HomePage(string login, string password, bool isAuthenticated)
        {
            InitializeComponent();
            this.login = login;
            this.password = password;
            this.isAuthenticated = isAuthenticated;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            if (isAuthenticated)
            {
                button_log_exit.Text = "Вийти";
            }
            else
            {
                button_log_exit.Text = "Реєстрація/авторизація";
            }

            Admin admin = new Admin("", "");
            var listPromotions = admin.GetValidPromotions();

            int panelWidth = panel_acction.Width;
            int pictureBoxWidth = 100;
            int labelDescriptionWidth = 124;
            int buttonWidth = 100;
            int horizontalSpacing = 23;
            int verticalSpacing = 50;
            int promotionsPerRow = 5;
            int maxElements = 12;

            int availableWidth = panelWidth - (horizontalSpacing * (promotionsPerRow + 1));

            int pictureBoxX = 23;
            int pictureBoxY = 13;
            int pictureBoxCount = 0;
            int labelCount = 0;
            int buttonCount = 0;

            foreach (var promotion in listPromotions)
            {
                if (pictureBoxCount >= maxElements || labelCount >= maxElements || buttonCount >= maxElements)
                {
                    break;
                }


                PictureBox pictureBox = new PictureBox();
                Label labelDescription = new Label();
                Button buttonGoToAction = new Button();
                Button buttonGoAllPromotion = new Button();


                pictureBox.ImageLocation = promotion.Photo;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Location = new Point(pictureBoxX, pictureBoxY);
                pictureBox.Width = pictureBoxWidth;
                pictureBox.Height = 50;
                panel_acction.Controls.Add(pictureBox);


                labelDescription.Text = promotion.Description;
                labelDescription.Location = new Point(pictureBoxX, pictureBoxY + pictureBox.Height + 10);
                labelDescription.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 204);
                labelDescription.Width = labelDescriptionWidth;
                labelDescription.Height = 60;
                panel_acction.Controls.Add(labelDescription);


                buttonGoToAction.Text = "До акції";
                buttonGoToAction.Tag = promotion;
                buttonGoToAction.Location = new Point(pictureBoxX, pictureBoxY + pictureBox.Height + labelDescription.Height + 20);
                buttonGoToAction.Width = buttonWidth;
                buttonGoToAction.Height = 27;
                buttonGoToAction.Click += buttonGoToAction_Click;
                panel_acction.Controls.Add(buttonGoToAction);


                buttonGoAllPromotion.Text = "Перейти до всіх акцій";
                buttonGoAllPromotion.Location = new Point(285, 366);
                buttonGoAllPromotion.Width = 202;
                buttonGoAllPromotion.Height = 38;
                buttonGoAllPromotion.Click += buttonGoAllPromotion_Click;
                panel_acction.Controls.Add(buttonGoAllPromotion);

                pictureBoxX += pictureBoxWidth + horizontalSpacing;

                pictureBoxCount++;
                labelCount++;
                buttonCount++;

                if (pictureBoxX + pictureBoxWidth + horizontalSpacing > panelWidth)
                {
                    pictureBoxX = 23;
                    pictureBoxY += pictureBox.Height + labelDescription.Height + buttonGoToAction.Height + verticalSpacing;
                }
            }
        }

        private void buttonGoToAction_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Promotion promotion = (Promotion)button.Tag;
            ViewdetailsPromotionPage viewPromotion = new ViewdetailsPromotionPage(promotion.ID, promotion.Shop, promotion.Category, promotion.Description, promotion.Photo, promotion.ExpiryDate, promotion.Code, login, password, isAuthenticated);
            viewPromotion.Show();
            this.Hide();
        }

        private void buttonGoAllPromotion_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AcctionPage acction = new AcctionPage(login, password, isAuthenticated);
            acction.Show();
            this.Hide();
        }

        private void button_log_exit_Click(object sender, EventArgs e)
        {
            Register_or_AuthenticatePage acctive = new Register_or_AuthenticatePage(false);
            acctive.Show();
            this.Hide();
        }

        private void acctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcctionPage acctionPage = new AcctionPage(login, password, isAuthenticated);
            acctionPage.Show();
            this.Hide();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPromotionPage searchPromotionPage = new SearchPromotionPage(login, password, isAuthenticated);
            searchPromotionPage.Show();
            this.Hide();
        }
    }
}
