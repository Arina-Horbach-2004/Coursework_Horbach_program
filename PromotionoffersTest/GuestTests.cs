using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Promotional_offers.Classes;

namespace PromotionoffersTest
{

    [TestClass]
    public class GuestTests
    {
        // Тест на успішну реєстрацію нового користувача
        [TestMethod]
        public void Register_NewUser_SuccessfullyRegistered()
        {
            // Arrange
            var guest = new Guest();
            string email = "test@example.com";
            string password = "password";

            // Act
            bool result = guest.Register(email, password);

            // Assert
            Assert.IsTrue(result);
            Assert.IsTrue(RegisteredUser.registeredUsers.Any(user => user.Email == email));
        }

        // Тест на обробку випадку з порожнім електронним листом при реєстрації
        [TestMethod]
        public void Register_EmptyEmail_ReturnsFalse()
        {
            // Arrange
            var guest = new Guest();
            string email = "";
            string password = "password";

            Assert.ThrowsException<Exception>(() => guest.Register(email, password));
        }

        // Тест на обробку випадку, коли спробуємо зареєструвати користувача з вже зареєстрованою електронною поштою
        [TestMethod]
        public void Register_AlreadyRegisteredEmail_ReturnsFalse()
        {
            // Arrange
            var guest = new Guest();
            string email = "test@example.com";
            string password = "password";
            guest.Register(email, password); // Регистрируем пользователя

            Assert.ThrowsException<Exception>(() => guest.Register(email, password));
        }

        // Тест на перегляд існуючої акційної пропозиції
        [TestMethod]
        public void ViewPromotions_PromotionExists()
        {
            // Arrange
            var guest = new Guest();
            var promotion = new Promotion(1, "Shop A", "Electronics", "CODE1", DateTime.Now.AddDays(7), "photo1.jpg", "Description 1");

            // Act
            guest.ViewPromotions(promotion);
        }

        // Тест на перегляд неіснуючої акційної пропозиції
        [TestMethod]
        public void ViewPromotions_PromotionDoesNotExist()
        {
            // Arrange
            var guest = new Guest();
            Promotion promotion = null;

            // Act
            guest.ViewPromotions(promotion);
        }

        // Тест на пошук акційних пропозицій за категорією
        [TestMethod]
        public void SearchPromotions_ByCategory_Success()
        {
            var guest = new Guest();
            var promotions = new List<Promotion>
            {
                new Promotion(1, "Shop A", "Electronics", "CODE1", DateTime.Now.AddDays(7), "photo1.jpg", "Description 1"),
                new Promotion(2, "Shop B", "Fashion", "CODE2", DateTime.Now.AddDays(5), "photo2.jpg", "Description 2")
            };
            // Act
            var result = guest.SearchPromotions("Electronics", "", promotions);

            // Assert
            Assert.IsTrue(result.Count > 0);
        }

        // Тест на пошук акційних пропозицій за ключовими словами в описі
        [TestMethod]
        public void SearchPromotions_ByDescriptionKeywords_Success()
        {
            // Arrange
            var guest = new Guest();
            var promotions = new List<Promotion>
            {
                new Promotion(1, "Shop A", "Electronics", "CODE1", DateTime.Now.AddDays(7), "photo1.jpg", "Description 1"),
                new Promotion(2, "Shop B", "Fashion", "CODE2", DateTime.Now.AddDays(5), "photo2.jpg", "Best deals on fruits and vegetables"),
                  new Promotion(3, "Shop C", "Food", "CODE3", DateTime.Now.AddDays(10), "photo3.jpg", "Best deals on fruits and vegetables")
            };
            // Act
            var result = guest.SearchPromotions("", "deals fruits", promotions);

            // Assert
            Assert.IsTrue(result.Count > 0);
        }

        // Тест на обробку випадку, коли пошук не повертає результатів
        [TestMethod]
        public void SearchPromotions_NoResults()
        {
            // Arrange
            var guest = new Guest();

            var promotions = new List<Promotion>
            {
                 new Promotion(1, "Shop A", "Electronics", "CODE1", DateTime.Now.AddDays(7), "photo1.jpg", "Description 1"),
                  new Promotion(2, "Shop B", "Fashion", "CODE2", DateTime.Now.AddDays(5), "photo2.jpg", "Description 2")
            };
            // Act
            var result = guest.SearchPromotions("Food", "", promotions);

            // Assert
            Assert.IsFalse(result.Count > 0);
        }

        // Тест на обробку випадку, коли категорія та ключові слова для пошуку порожні
        [TestMethod]
        public void SearchPromotions_EmptyCategoryAndKeywords_ReturnsEmptyList()
        {
            // Arrange
            var guest = new Guest();
            var promotions = new List<Promotion>
            {
                new Promotion(1, "Shop A", "Electronics", "CODE1", DateTime.Now.AddDays(7), "photo1.jpg", "Description 1"),
                  new Promotion(2, "Shop B", "Fashion", "CODE2", DateTime.Now.AddDays(5), "photo2.jpg", "Description 2")
            };
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                var result = guest.SearchPromotions("", "", promotions);

                // Assert
                Assert.AreEqual(0, result.Count);
                Assert.AreEqual("Не вказано категорію або ключові слова для пошуку." + Environment.NewLine, sw.ToString());
            }
        }
    }
}
