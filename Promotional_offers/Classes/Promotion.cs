using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using Promotional_offers.Classes;

namespace Promotional_offers.Classes
{
    public class Promotion : IPromotion, ICloneable
    {
        // Характеристики класу Promotion
        public int ID { get; set; }
        public string Shop { get; set; }
        public string Category { get; set; }
        public string Code { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public bool IsUsed { get; private set; }

        private static Random random = new Random();

        // Список дійсних промокодів
        public static List<Promotion> promotionsList = new List<Promotion>();

        // Список видалених промокодів 
        public static List<Promotion> deletedPromotions = new List<Promotion>();

        // Конструктор
        public Promotion(int id, string store, string category, string promoCode, DateTime expiryDate, string photo, string description)
        {
            ID = id;
            Shop = store;
            Category = category;
            Code = promoCode;
            ExpiryDate = expiryDate;
            Photo = photo;
            Description = description;
        }

        // Використання промокоду
        public bool UsePromotion(string promoCode)
        {
            // Перевірка, чи промокод вже був використаний
            if (IsUsed)
            {
                Console.WriteLine("Помилка: Цей промокод вже був використаний!");
                return false;
            }
            // Перевірка дійності промокоду
            if (promoCode == Code)
            {
                IsUsed = true;
                Console.WriteLine("Промокод успішно використано!");
                return true;
            }
            else
            {
                Console.WriteLine("Помилка: Недійсний промокод!");
                return false;
            }
        }

        // Створення промокоду
        public static bool CreatePromotion(int id, string shop, string category, string code, DateTime expiryDate, string photo, string description)
        {
            // Перевірка, чи існую промкод з таким самим ID
            if (promotionsList.Any(p => p.ID == id))
            {
                throw new("Помилка: Промокод з таким ID вже існує!");
            }
            if (expiryDate < DateTime.Now)
            {
                throw new("Дата закінчення промокоду не може бути менше ніж сьогоднішня!");

            }

            // Створення ногово промокоду з переданими параметрами
            Promotion new_promotion = new Promotion(id, shop, category, code, expiryDate, photo, description);
            promotionsList.Add(new_promotion);
            Console.WriteLine("Промокод успішно створено!");
            return true;
        }

        // Редагування промокоду 
        public bool EditPromotion(int id, string shop, string category, string code, DateTime expiryDate, string photo, string description)
        {
            // Пошук промокоду за ID
            Promotion promotion_edit = promotionsList.FirstOrDefault(p => p.ID == id);
            // Перевірка, чи був знайдений промокод з вказаним ID
            if (promotion_edit != null)
            {
                // Виконати редагування знайденого промокоду
                promotion_edit.Shop = shop;
                promotion_edit.Category = category;
                promotion_edit.Code = code;
                promotion_edit.ExpiryDate = expiryDate;
                promotion_edit.Photo = photo;
                promotion_edit.Description = description;

                Console.WriteLine($"Промокод з ID {id} успішно відредаговано.");
                return true;
            }
            else
            {
                Console.WriteLine($"Промокод з ID {id} не знайдено.");
                return false;
            }
        }
         
        // Видалення промокоду
        public static bool DeletePromotion(int id)
        {
            // Пошук промокоду за ID
            Promotion promotionToDelete = promotionsList.FirstOrDefault(promotion => promotion.ID == id);

            if (promotionToDelete != null)
            {
                // Видалення промокоду зі списку
                promotionsList.Remove(promotionToDelete);
                Console.WriteLine("Промокод успішно видалено!");

                // Додавання видаленого промокоду до списку видалених
                deletedPromotions.Add(promotionToDelete);
                return true;
            }
            else
            {
                Console.WriteLine("Помилка: Промокод із вказаним ID не знайдено!");
                return false;
            }
        }

        // Метод для виведення детальної інформації про пропозицію
        public void DisplayDetails(bool isAuthenticated)
        {
            // Перевірка, чи авторизований користувач
            if (isAuthenticated)
            {
                // Виведення детальної інформації про пропозицію для авторизованих користувачів
                Console.WriteLine("Детальна інформація про акційну пропозицію:");
                Console.WriteLine($"Магазин: {Shop}");
                Console.WriteLine($"Категорія: {Category}");
                Console.WriteLine($"Промокод: {Code}");
                Console.WriteLine($"Дата закінчення: {ExpiryDate}");
                Console.WriteLine($"Фото: {Photo}");
                Console.WriteLine($"Опис: {Description}");
            }
            else
            {
                // Виведення загальної інформації про пропозицію для гостей
                Console.WriteLine("Загальна інформація про акційну пропозицію:");
                Console.WriteLine($"Магазин: {Shop}");
                Console.WriteLine($"Категорія: {Category}");
                Console.WriteLine($"Дата закінчення: {ExpiryDate}");
                Console.WriteLine($"Фото: {Photo}");
                Console.WriteLine($"Опис: {Description}");
            }
        }

        public override string ToString()
        {
            return $"ID: {ID}, Shop: {Shop}, Category: {Category}, Code: {Code}, ExpiryDate: {ExpiryDate.ToString("dd.MM.yyyy")}, Photo: {Photo}, Description: {Description}";
        }

        public static List<Promotion> GetValidPromotions()
        {
            return promotionsList.Where(promotion => promotion.ExpiryDate > DateTime.Now).ToList();
        }

        // Метод для отримання інформації про активні промокоди у вигляді рядка
        public static string GetActivePromotionsAsString()
        {
            var activePromotions = promotionsList.Where(promotion => promotion.ExpiryDate > DateTime.Now).ToList();
            if (activePromotions.Any())
            {
                return string.Join(Environment.NewLine, activePromotions.Select(p => p.ToString()));
            }
            else
            {
                return "Немає активних промокодів.";
            }
        }

        // Перевизначення методу ToString для виведення інформації про видалені промокоди
        public static string GetDeletedPromotionsAsString()
        {
            if (deletedPromotions.Any())
            {
                return string.Join(Environment.NewLine, deletedPromotions.Select(p => p.ToString()));
            }
            else
            {
                return "Немає видалених промокодів.";
            }
        }

        public object Clone()
        {
            // Створюємо глибоку копію об'єкту
            Promotion clonedPromotion = new Promotion(ID, Shop, Category, Code, ExpiryDate, Photo, Description);

            // Генеруємо новий ID для клонованого промокоду
            clonedPromotion.ID = GenerateNewID();
            return clonedPromotion;
        }

        private static int GenerateNewID()
        {
            return random.Next(1, 100);
        }

    }
}
    
