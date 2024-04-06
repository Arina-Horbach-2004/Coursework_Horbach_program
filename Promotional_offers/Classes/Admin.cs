using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotional_offers.Classes
{
    public class Admin : IAdmin
    {
        // Спеціальний логін та пароль
        private static readonly string SpecialLogin = "administratorlogin@gmail.com";
        private static readonly string SpecialPassword = "adminpassword";

        // Характеристики класу Admin
        public string Email { get; set; }
        public string Password { get; set; }

        // Конструктор класу Admin
        public Admin(string email, string password)
        {
            Email = email;
            Password = password;
        }

        // Авторизація адміністратора
        public bool Authenticate(string login, string password)
        {
            // Перевірка дійсності вхідних даних
            if (login == SpecialLogin && password == SpecialPassword)
            {
                return true; // Успішна авторизація
            }
            else
            {
                return false; // Помилка при вході
            }
        }

        // Створення промокоду
        public bool CreatePromotion(int id, string store, string category, string promoCode, DateTime expirationDate, string photo, string description)
        {
            return Promotion.CreatePromotion(id, store, category, promoCode, expirationDate, photo, description);
        }

        // Редагування промокоду
        public bool EditPromotion(int id, string store, string category, string promoCode, DateTime expirationDate, string photo, string description)
        {
            Promotion promotion = new Promotion(id, store, category, promoCode, expirationDate, photo, description);
            return promotion.EditPromotion(id, store, category, promoCode, expirationDate, photo, description);
        }

        // Видаленя промокоду
        public bool DeletePromotion(int id)
        {
            return Promotion.DeletePromotion(id);
        }

        // Отримати список дійсних промокодів
        public List<Promotion> GetValidPromotions()
        {
            return Promotion.GetValidPromotions();
        }

        // Отримати список видалених промокодів
        public List<Promotion> GetDeletedPromotions()
        {
            return Promotion.deletedPromotions;
        }

        // Отримати список зареєстрованих користувачів
        public List<RegisteredUser> GetRegisteredUsers()
        {
            return RegisteredUser.registeredUsers;
        }


        // Метод для отримання інформації про активні промокоди у вигляді рядка
        public static string GetActivePromotionsAsString()
        {
            return Promotion.GetActivePromotionsAsString();
        }

        // Метод для отримання інформації про  зареєстрованих користувачів у вигляді рядка
        public static string GetRegisteredUsersAsString()
        {
            return RegisteredUser.GetRegisteredUsersAsString();
        }

        // Метод для отримання інформації про видалені промокоди у вигляді рядка
        public static string GetDeletedPromotionsAsString()
        {
            return Promotion.GetDeletedPromotionsAsString();
        }

        // Зберегти промокоди у файл JSON
        public void SavePromotionsToJson(string filePath)
        {
            try
            {
                JsonFileManager.SaveToJson(GetValidPromotions(), filePath);
                Console.WriteLine("Промокоди успішно збережено у файл JSON.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при збереженні промокодів у файл JSON: {ex.Message}");
            }
        }

        // Зчитати промокоди з файлу JSON
        public void LoadPromotionsFromJson(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    Promotion.promotionsList = JsonFileManager.LoadFromJson<Promotion>(filePath);
                    Console.WriteLine("Промокоди успішно завантажено з файлу JSON.");
                }
                else
                {
                    Console.WriteLine("Файл з промокодами не знайдено.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при завантаженні промокодів з файлу JSON: {ex.Message}");
            }
        }

        // Зберегти видалені промокоди у файл JSON
        public void SaveDeletedPromotionsToJson(string filePath)
        {
            try
            {
                JsonFileManager.SaveToJson(GetDeletedPromotions(), filePath);
                Console.WriteLine("Видалені промокоди успішно збережено у файл JSON.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при збереженні видалених промокодів у файл JSON: {ex.Message}");

            }
        }

        // Зчитати видалені промокоди з файлу JSON
        public void LoadDeletedPromotionsFromJson(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    Promotion.deletedPromotions = JsonFileManager.LoadFromJson<Promotion>(filePath);
                    Console.WriteLine("Видалені промокоди успішно завантажено з файлу JSON.");
                }
                else
                {
                    Console.WriteLine("Файл з видаленими промокодами не знайдено.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при завантаженні видалених промокодів з файлу JSON: {ex.Message}");
            }
        }

    }
}
