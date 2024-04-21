using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotional_offers.Classes
{
    public class RegisteredUser : PersonBase, IPromotionSearch
    {
        public virtual string Email
        {
            get => base.Email;
            set => base.Email = value;
        }

        public virtual string Password
        {
            get => base.Password;
            set => base.Password = value;
        }

        public static List<RegisteredUser> registeredUsers { get; } = new List<RegisteredUser>();
        public static List<string> usedPromoCodes = new List<string>();

        public RegisteredUser(string email, string password)
        {
            Email = email;
            Password = password;
            registeredUsers.Add(this);
        }

        // Авторизація користувача
        public bool Authenticate(string login, string password)
        {
            // Перевірка, чи є користувач з введеним логіном серед зареєстрованих
            RegisteredUser user = registeredUsers.Find(u => u.Email == login);
            if (user != null && user.Password == password)
            {
                Console.WriteLine("Успішний вхід.");
                return true; // Успішний вхід
            }
            else
            {
                Console.WriteLine("Помилка при вході. Невірний логін або пароль.");
                return false; // Помилка при вході
            }
        }

        // Перегляд детальної інформації про акційні пропозиції
        public void ViewPromotionDetails(Promotion promotion, bool isAuthenticated)
        {
            // Перевірка, чи пропозиція не є null
            if (promotion != null)
            {
                // Виклик методу виведення деталей пропозиції
                promotion.DisplayDetails(isAuthenticated);
            }
            else
            {
                Console.WriteLine("Пропозиція не знайдена.");
            }

        }

        public bool UsePromotionCode(string promoCode)
        {
            if (usedPromoCodes.Contains(promoCode))
            {
                Console.WriteLine("Цей промокод вже був використаний раніше.");
                return false;
            }
            else
            {
                usedPromoCodes.Add(promoCode);
                Console.WriteLine("Промокод успішно використаний.");
                return true;
            }
        }

        // Пошук промокоду
        public List<Promotion> SearchPromotions(string category, string keywords, List<Promotion> promotions)
        {
            if (string.IsNullOrWhiteSpace(category) && string.IsNullOrWhiteSpace(keywords))
            {
                Console.WriteLine("Не вказано категорію або ключові слова для пошуку.");
                return new List<Promotion>();
            }

            var filteredPromotions = promotions;

            if (!string.IsNullOrWhiteSpace(category))
            {
                filteredPromotions = filteredPromotions.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (!string.IsNullOrWhiteSpace(keywords))
            {
                var searchWords = keywords.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                filteredPromotions = filteredPromotions.Where(p =>
                    searchWords.Any(word => p.Description.Contains(word, StringComparison.OrdinalIgnoreCase)) ||
                    searchWords.Any(word => p.Shop.Contains(word, StringComparison.OrdinalIgnoreCase))
                ).ToList();
            }

            Console.WriteLine("Знайдені пропозиції:");
            foreach (var promotion in filteredPromotions)
            {
                Console.WriteLine($"Магазин: {promotion.Shop}, Категорія: {promotion.Category}, Опис: {promotion.Description}");
            }

            return filteredPromotions;
        }

        // Перевизначення методу Get_Full_Info
        public override string Get_Full_Info()
        {
            return $"RegisterUser: {base.Get_Full_Info()}";
        }

        public static string GetRegisteredUsersAsString()
        {
            if (registeredUsers.Any())
            {
                return string.Join(Environment.NewLine, registeredUsers.Select(u => u.Get_Full_Info()));
            }
            else
            {
                return "Немає зареєстрованих користувачів.";
            }
        }

    }
}
