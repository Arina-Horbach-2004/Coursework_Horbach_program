using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;
using Promotional_offers;
using Promotional_offers.Classes;

namespace PromotionoffersTest
{
    [TestClass]
    public class PromotionTests
    {
        // Перевірка, що використання дійсного промокоду повертає true
        [TestMethod]
        public void UsePromotion_ValidPromoCode_ReturnsTrue()
        {
            // Arrange
            Promotion promotion = new Promotion(1, "Shop", "Category", "123ABC", DateTime.Now.AddDays(1), "photo", "Весняні Знижки до 10.04. Товари дешевше навіть на 30%!");

            // Act
            bool result = promotion.UsePromotion("123ABC");

            // Assert
            Assert.IsTrue(result);
        }

        // Перевірка, що використання недійсного промокоду повертає false
        [TestMethod]
        public void UsePromotion_InvalidPromoCode_ReturnsFalse()
        {
            // Arrange
            Promotion promotion = new Promotion(1, "Shop", "Category", "123ABC", DateTime.Now.AddDays(1), "photo", "Весняні Знижки до 10.04. Товари дешевше навіть на 30%!");

            // Act
            bool result = promotion.UsePromotion("456DEF");

            // Assert
            Assert.IsFalse(result);
        }

        // Перевірка успішного створення нової пропозиції
        [TestMethod]
        public void CreatePromotion_NewPromotion_CreatesSuccessfully()
        {
            // Arrange
            int id = 1;
            string shop = "Shop";
            string category = "Category";
            string code = "123ABC";
            DateTime expiryDate = DateTime.Now.AddDays(1);
            string photo = "photo";
            string decription = "Весняні Знижки до 10.04. Товари дешевше навіть на 30%!";

            // Act
            bool result = Promotion.CreatePromotion(id, shop, category, code, expiryDate, photo, decription);

            // Assert
            Assert.IsTrue(result);
        }

        // Перевірка, що створення промоакції з існуючим ідентифікатором повертає false
        [TestMethod]
        public void CreatePromotion_PromotionWithExistingID_ReturnsFalse()
        {
            // Arrange
            int id = 1;
            string shop = "Shop";
            string category = "Category";
            string code = "123ABC";
            DateTime expiryDate = DateTime.Now.AddDays(1);
            string photo = "photo";
            string decription = "Весняні Знижки до 10.04. Товари дешевше навіть на 30%!";

            // Create the first promotion
            Promotion.CreatePromotion(id, shop, category, code, expiryDate, photo, decription);
            Assert.ThrowsException<Exception>(() => Promotion.CreatePromotion(id, shop, category, code, expiryDate, photo, decription));
    }

        // Перевірка успішного редагування існуючої промоакції
        [TestMethod]
        public void EditPromotion_PromotionExists_EditsSuccessfully()
        {
            // Arrange
            int id = 1;
            string shop = "Shop";
            string category = "Category";
            string code = "123ABC";
            DateTime expiryDate = DateTime.Now.AddDays(1);
            string photo = "photo";
            string decription = "Весняні Знижки до 10.04. Товари дешевше навіть на 30%!";

            // Create and add a promotion to the promotions list
            Promotion.CreatePromotion(id, shop, category, code, expiryDate, photo, decription);

            // New values for editing
            string newShop = "NewShop";
            string newCategory = "NewCategory";
            string newCode = "456DEF";
            DateTime newExpiryDate = DateTime.Now.AddDays(2);
            string newPhoto = "newphoto";
            string newdecription = "ПОПУЛЯРНІ СНІКЕРСИ ЗНИЖКИ ДО -30% на вибрані товари";

            // Act
            Promotion promotion = new Promotion(id, shop, category, code, expiryDate, photo, decription);
            bool result = promotion.EditPromotion(id, newShop, newCategory, newCode, newExpiryDate, newPhoto, newdecription);

            // Assert
            Assert.IsTrue(result);
        }

        // Перевірка, що редагування неіснуючої промоакції повертає false
        [TestMethod]
        public void EditPromotion_PromotionDoesNotExist_ReturnsFalse()
        {
            // Arrange
            int id = 1;
            string shop = "Shop";
            string category = "Category";
            string code = "123ABC";
            DateTime expiryDate = DateTime.Now.AddDays(1);
            string photo = "photo";
            string decription = "Весняні Знижки до 10.04. Товари дешевше навіть на 30%!";

            Promotion promotion = new Promotion(id, shop, category, code, expiryDate, photo, decription);

            // Act
            bool result = promotion.EditPromotion(id, shop, category, code, expiryDate, photo, decription);

            // Assert
            Assert.IsFalse(result);
        }

        // Перевірка успішного видалення промоакції та додавання її до списку видалених промоакцій
        [TestMethod]
        public void DeletePromotion_PromotionExists_DeletesAndAddsToDeletedPromotions()
        {
            // Arrange
            DateTime expiryDate = DateTime.Now.AddDays(7); // Отримуємо поточну дату і додаємо до неї 7 днів
            var promotion = new Promotion(1, "Shop A", "Electronics", "CODE1", expiryDate, "photo1.jpg", "Description 1");
            Promotion.CreatePromotion(promotion.ID, promotion.Shop, promotion.Category, promotion.Code, expiryDate, promotion.Photo, promotion.Description);

            // Act
            bool result = Promotion.DeletePromotion(1);

            // Assert
            Assert.IsTrue(result); // Перевірка, що промокод був успішно видалений

            // Перевірка, чи промокод дійсно був доданий до списку видалених промокодів
            Assert.IsTrue(Promotion.deletedPromotions.Any(p => p.ID == promotion.ID && p.ExpiryDate == expiryDate));
        }

        // Тест на видалення промокоду, якщо промокод не існує: повертає false і не вносить змін
        [TestMethod]
        public void DeletePromotion_PromotionDoesNotExist_ReturnsFalseAndNoChanges()
        {
            DateTime expiryDate = DateTime.Now.AddDays(7);
            // Arrange
            var promotion = new Promotion(1, "Shop A", "Electronics", "CODE1", expiryDate, "photo1.jpg", "Description 1");
            Promotion.CreatePromotion(promotion.ID, promotion.Shop, promotion.Category, promotion.Code, expiryDate, promotion.Photo, promotion.Description);

            // Act
            bool result = Promotion.DeletePromotion(2);

            // Assert
            Assert.IsFalse(result); // Перевірка, що метод повернув false, оскільки промокод не був знайдений
            CollectionAssert.DoesNotContain(Promotion.GetValidPromotions(), promotion); // Перевірка, що список активних промокодів не змінився
            CollectionAssert.DoesNotContain(Promotion.deletedPromotions, promotion); // Перевірка, що список видалених промокодів не змінився
        }

        // Тест на відображення детальної інформації для аутентифікованого користувача
        [TestMethod]
        public void DisplayDetails_AuthenticatedUser_DisplaysDetailedInformation()
        {
            // Arrange
            int id = 1;
            string shop = "Магазин";
            string category = "Категорія";
            string code = "123ABC";
            DateTime expiryDate = DateTime.Now.AddDays(1);
            string photo = "Фото";
            string description = "Весняні Знижки до 10.04. Товари дешевше навіть на 30%!";

            Promotion promotion = new Promotion(id, shop, category, code, expiryDate, photo, description);

            // Перенаправлення виводу консолі в StringWriter для його захоплення
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                promotion.DisplayDetails(isAuthenticated: true);

                // Assert
                string expectedOutput = $"Детальна інформація про акційну пропозицію:\r\n" +
                                        $"Магазин: {shop}\r\n" +
                                        $"Категорія: {category}\r\n" +
                                        $"Промокод: {code}\r\n" +
                                        $"Дата закінчення: {expiryDate}\r\n" +
                                        $"Фото: {photo}\r\n" +
                                        $"Опис: {description}\r\n";

                Assert.AreEqual(expectedOutput, sw.ToString());
            }
        }

        // Тест на відображення детальної інформації для неаутентифікованого користувача
        [TestMethod]
        public void DisplayDetails_UnauthenticatedUser_Success()
        {
            // Arrange
            var promotion = new Promotion(1, "Shop A", "Electronics", "CODE1", DateTime.Now.AddDays(7), "photo1.jpg", "Description 1");

            // Act
            Console.WriteLine("Відображення деталей для неаутентифікованого користувача:");
            promotion.DisplayDetails(false);
        }

        // Тест на отримання рядка з активними промокодами
        [TestMethod]
        public void GetActivePromotionsAsString_ReturnsStringWithActivePromotions()
        {
            // Arrange
            var promotion1 = new Promotion(1, "Shop1", "Category1", "Code1", DateTime.Now.AddDays(1), "Photo1", "Description1");
            var promotion2 = new Promotion(2, "Shop2", "Category2", "Code2", DateTime.Now.AddDays(2), "Photo2", "Description2");
            Promotion.promotionsList.Add(promotion1);
            Promotion.promotionsList.Add(promotion2);

            // Очікуваний результат
            string expectedPromotion1 = $"ID: {promotion1.ID}, Shop: {promotion1.Shop}, Category: {promotion1.Category}, Code: {promotion1.Code}, ExpiryDate: {promotion1.ExpiryDate.ToString("dd.MM.yyyy")}, Photo: {promotion1.Photo}, Description: {promotion1.Description}";
            string expectedPromotion2 = $"ID: {promotion2.ID}, Shop: {promotion2.Shop}, Category: {promotion2.Category}, Code: {promotion2.Code}, ExpiryDate: {promotion2.ExpiryDate.ToString("dd.MM.yyyy")}, Photo: {promotion2.Photo}, Description: {promotion2.Description}";
            string expected = $"{expectedPromotion1}{Environment.NewLine}{expectedPromotion2}";

            // Act
            var result = Promotion.GetActivePromotionsAsString();

            // Assert
            StringAssert.Contains(result, expected);
        }

        // Тест на отримання рядка без активних промокодів, якщо вони відсутні
        [TestMethod]
        public void GetActivePromotionsAsString_ReturnsNoActivePromotions_WhenNoneExist()
        {
            // Arrange
            Promotion.promotionsList.Clear();

            // Act
            var result = Promotion.GetActivePromotionsAsString();

            // Assert
            Assert.AreEqual("Немає активних промокодів.", result);
        }

        // Тест на отримання рядка з видаленими промокодами
        [TestMethod]
        public void GetDeletedPromotionsAsString_ReturnsStringWithDeletedPromotions()
        {
            // Arrange
            var promotion1 = new Promotion(1, "Shop1", "Category1", "Code1", DateTime.Now.AddDays(1), "Photo1", "Description1");
            var promotion2 = new Promotion(2, "Shop2", "Category2", "Code2", DateTime.Now.AddDays(2), "Photo2", "Description2");
            Promotion.deletedPromotions.Add(promotion1);
            Promotion.deletedPromotions.Add(promotion2);

            // Очікуваний результат
            string expectedPromotion1 = $"ID: {promotion1.ID}, Shop: {promotion1.Shop}, Category: {promotion1.Category}, Code: {promotion1.Code}, ExpiryDate: {promotion1.ExpiryDate.ToString("dd.MM.yyyy")}, Photo: {promotion1.Photo}, Description: {promotion1.Description}";
            string expectedPromotion2 = $"ID: {promotion2.ID}, Shop: {promotion2.Shop}, Category: {promotion2.Category}, Code: {promotion2.Code}, ExpiryDate: {promotion2.ExpiryDate.ToString("dd.MM.yyyy")}, Photo: {promotion2.Photo}, Description: {promotion2.Description}";
            string expected = $"{expectedPromotion1}{Environment.NewLine}{expectedPromotion2}";

            // Actsx
            var result = Promotion.GetDeletedPromotionsAsString();

            // Assert
            StringAssert.Contains(result, expected);
        }

        // Тест на отримання рядка без видалених промокодів, якщо вони відсутні
        [TestMethod]
        public void GetDeletedPromotionsAsString_NoDeletedPromotions_ReturnsMessage()
        {
            // Arrange
            Promotion.deletedPromotions.Clear();

            // Очікуваний результат
            string expected = "Немає видалених промокодів.";

            // Act
            var result = Promotion.GetDeletedPromotionsAsString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Тест на клонування промокоду з різним ID
        [TestMethod]
        public void Clone_ReturnsClonedPromotionWithDifferentID()
        {
            // Arrange
            var originalPromotion = new Promotion(1, "Shop", "Category", "123ABC", DateTime.Now.AddDays(1), "photo", "Description");

            // Act
            var clonedPromotion = (Promotion)originalPromotion.Clone();

            // Assert
            Assert.AreNotEqual(originalPromotion.ID, clonedPromotion.ID);
            Assert.AreEqual(originalPromotion.Shop, clonedPromotion.Shop);
            Assert.AreEqual(originalPromotion.Category, clonedPromotion.Category);
            Assert.AreEqual(originalPromotion.Code, clonedPromotion.Code);
            Assert.AreEqual(originalPromotion.ExpiryDate, clonedPromotion.ExpiryDate);
            Assert.AreEqual(originalPromotion.Photo, clonedPromotion.Photo);
            Assert.AreEqual(originalPromotion.Description, clonedPromotion.Description);
        }
    }
}