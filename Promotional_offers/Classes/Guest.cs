using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotional_offers.Classes
{
    public class Guest : IPromotionSearch
    {
        public Guest()
        {

        }

        // Поведінка: Перегляд акційних пропозицій без авторизації
        public void ViewPromotions(Promotion promotion)
        {
            if (promotion != null)
            {
                promotion.DisplayDetails(false);
            }
            else
            {
                Console.WriteLine("Пропозиція не знайдена.");
            }
        }

        // Реєстрація нового користувача
        public bool Register(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Реєстрація не вдалася: Email або пароль порожні або складаються лише з пропусків.");
                return false; // Якщо email або пароль порожні або складаються лише з пропусків, повертаємо false
            }

            if (RegisteredUser.registeredUsers.Any(user => user.Email == email))
            {
                Console.WriteLine("Реєстрація не вдалася: Користувач з такою адресою електронної пошти вже існує.");
                return false; // Якщо користувач з такою адресою електронної пошти вже зареєстрований, повертаємо false
            }

            // Створюємо нового зареєстрованого користувача та додаємо його до списку зареєстрованих користувачів
            var newUser = new RegisteredUser(email, password);
            RegisteredUser.registeredUsers.Add(newUser);
            Console.WriteLine("Реєстрація успішна.");
            return true; // Реєстрація пройшла успішно, повертаємо true
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
    }
}
