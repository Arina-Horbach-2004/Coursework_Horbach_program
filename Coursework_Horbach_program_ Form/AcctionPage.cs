﻿using Promotional_offers.Classes;
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
    public partial class AcctionPage : Form
    {

        private string login;
        private string password;
        private bool isAuthenticated;

        public AcctionPage(string login, string password, bool isAuthenticated)
        {
            InitializeComponent();
            this.login = login;
            this.password = password;
            this.isAuthenticated = isAuthenticated;
        }

        private void AcctionPage_Load(object sender, EventArgs e)
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
            int pictureBoxY = 13;
            int labelDescriptionY = 28;
            int buttonGoToActionY = 13;

            foreach (var promotion in listPromotions)
            {
                PictureBox pictureBox = new PictureBox();
                Label labelDescription = new Label();
                Button buttonGoToAction = new Button();

                pictureBox.ImageLocation = promotion.Photo;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Location = new Point(12, pictureBoxY);
                pictureBox.Width = 125;
                pictureBox.Height = 62;
                panel_acction.Controls.Add(pictureBox);

                labelDescription.Text = promotion.Description;
                labelDescription.Location = new Point(203, labelDescriptionY);
                labelDescription.Width = 67;
                labelDescription.Height = 26;
                panel_acction.Controls.Add(labelDescription);

                buttonGoToAction.Text = "До акції";
                buttonGoToAction.Tag = promotion;
                buttonGoToAction.Location = new Point(666, buttonGoToActionY);
                buttonGoToAction.Width = 101;
                buttonGoToAction.Height = 41;
                panel_acction.Controls.Add(buttonGoToAction);

                buttonGoToAction.Click += buttonGoToAction_Click;

                pictureBoxY += 79;
                labelDescriptionY += 79;
                buttonGoToActionY += 79;

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

        private void button_log_exit_Click(object sender, EventArgs e)
        {
            Register_or_AuthenticatePage loginForm = new Register_or_AuthenticatePage(false);
            loginForm.Show();
            this.Hide();
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

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPromotionPage searchpage = new SearchPromotionPage(login, password, false);
            searchpage.Show();
            this.Hide();
        }
    }
}
