using Newtonsoft.Json.Linq;
using Promotional_offers.Classes;
using System.Text.RegularExpressions;

namespace Coursework_Horbach_program__Form
{
    public partial class Register_or_AuthenticatePage : Form
    {

        public string login;
        public string password;
        private bool isAuthenticated = false;

        public Register_or_AuthenticatePage(bool isAuthenticated)
        {
            InitializeComponent();
            this.isAuthenticated = isAuthenticated;
        }

        private void button_log_Click(object sender, EventArgs e)
        {
            login = textBox_login.Text;
            password = textBox_password.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введіть дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(login))
            {
                MessageBox.Show("Некоректна адреса електронної пошти. Адреса повинна містити символ '@' та бути не менше трьох символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidPassword(password))
            {
                MessageBox.Show("Некоректний пароль. Пароль повинен містити не більше 10 символів та складатися лише з літер латинського алфавіту.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isAuthenticated = AuthenticateUser(login, password);

            if (isAuthenticated)
            {
                SearchPromotionPage searchPage = new SearchPromotionPage(login, password, isAuthenticated);
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[\w-]+(?:\.[\w-]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private bool IsValidPassword(string password)
        {
            return password.Length <= 14 && Regex.IsMatch(password, @"^[a-zA-Z]+$");
        }

        private bool AuthenticateUser(string login, string password)
        {
            bool isAuthenticated = false;
            if (radioButton_authenticate.Checked)
            {
                Admin admin = new Admin("", "");
                bool isAdminAuthenticated = admin.Authenticate(login, password);
                if (isAdminAuthenticated)
                {
                    isAdminAuthenticated = true;
                    MessageBox.Show("Ви увійшли як адміністратор.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminPage adminpage = new AdminPage(isAdminAuthenticated);
                    adminpage.Show();
                    this.Hide();
                }
                else
                {
                    RegisteredUser user = RegisteredUser.registeredUsers.FirstOrDefault(u => u.Email == login);

                    if (user != null && user.Authenticate(login, password))
                    {

                        isAuthenticated = true;
                        MessageBox.Show("Ви увійшли як зареєстрований користувач.");
                        HomePage userpage = new HomePage(login, password, isAuthenticated);
                        userpage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Невірний логін або пароль.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else if (radioButton_register.Checked)
            {
                try
                {
                    Guest guest = new Guest();
                    isAuthenticated = guest.Register(login, password);
                    MessageBox.Show("Регестрація успішна", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            return isAuthenticated;
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

        private void radioButton_register_CheckedChanged(object sender, EventArgs e)
        {
            label_title.Text = "Реєстрація";
        }

        private void radioButton_authenticate_CheckedChanged(object sender, EventArgs e)
        {
            label_title.Text = "Вхід";
        }
    }
}
