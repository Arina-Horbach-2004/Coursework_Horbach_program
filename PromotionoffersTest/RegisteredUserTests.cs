using Promotional_offers.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionoffersTest
{
    [TestClass]
    public class RegisteredUserTests
    {
        // Тест на успішну автентифікацію з коректними обліковими даними
        [TestMethod]
        public void Authenticate_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            var user = new RegisteredUser("test@example.com", "password");
            RegisteredUser.registeredUsers.Add(user);

            // Act
            bool result = user.Authenticate("test@example.com", "password");

            // Assert
            Assert.IsTrue(result);
        }

        // Тест на автентифікацію з некоректними обліковими даними
        [TestMethod]
        public void Authenticate_InvalidCredentials_ReturnsFalse()
        {
            // Arrange
            var user = new RegisteredUser("test@example.com", "password");
            RegisteredUser.registeredUsers.Add(user);

            // Act
            bool result = user.Authenticate("test@example.com", "wrongpassword");

            // Assert
            Assert.IsFalse(result);
        }

        // Тест на обробку випадку, коли користувач не зареєстрований
        [TestMethod]
        public void Authenticate_UserNotRegistered_ReturnsFalse()
        {
            // Arrange
            var user = new RegisteredUser("test@example.com", "password");

            // Act
            bool result = user.Authenticate("invalid@example.com", "password");

            // Assert
            Assert.IsFalse(result);
        }

        // Тест на використання нового промокоду
        [TestMethod]
        public void UsePromotionCode_NewPromoCode_ReturnsTrue()
        {
            // Arrange
            var user = new RegisteredUser("test@example.com", "password");
            var usedPromoCodes = new List<string>();

            // Act
            bool result = user.UsePromotionCode("NEWCODE", usedPromoCodes);

            // Assert
            Assert.IsTrue(result);
        }

        // Тест на використання промокоду, який вже був використаний
        [TestMethod]
        public void UsePromotionCode_AlreadyUsedPromoCode_ReturnsFalse()
        {
            // Arrange
            var user = new RegisteredUser("test@example.com", "password");
            var usedPromoCodes = new List<string> { "USED1", "USED2" };

            // Act
            bool result = user.UsePromotionCode("USED1", usedPromoCodes);

            // Assert
            Assert.IsFalse(result);
        }

        // Тест на пошук акційних пропозицій за категорією
        [TestMethod]
        public void SearchPromotions_ByCategory_Success()
        {
            var user = new RegisteredUser("test@example.com", "password");
            RegisteredUser.registeredUsers.Add(user);
            var promotions = new List<Promotion>
            {
                new Promotion(1, "Shop A", "Electronics", "CODE1", DateTime.Now.AddDays(7), "photo1.jpg", "Description 1"),
                new Promotion(2, "Shop B", "Fashion", "CODE2", DateTime.Now.AddDays(5), "photo2.jpg", "Description 2")
            };
            // Act
            var result = user.SearchPromotions("Electronics", "", promotions);

            // Assert
            Assert.IsTrue(result.Count > 0);
        }

        // Тест на пошук акційних пропозицій за ключовими словами в описі
        [TestMethod]
        public void SearchPromotions_ByDescriptionKeywords_Success()
        {
            // Arrange
            var user = new RegisteredUser("test@example.com", "password");
            RegisteredUser.registeredUsers.Add(user);

            var promotions = new List<Promotion>
            {
                new Promotion(1, "Shop A", "Electronics", "CODE1", DateTime.Now.AddDays(7), "photo1.jpg", "Description 1"),
                 new Promotion(2, "Shop B", "Fashion", "CODE2", DateTime.Now.AddDays(5), "photo2.jpg", "Best deals on fruits and vegetables"),
                  new Promotion(3, "Shop C", "Food", "CODE3", DateTime.Now.AddDays(10), "photo3.jpg", "Best deals on fruits and vegetables")
            };
            // Act
            var result = user.SearchPromotions("", "deals fruits", promotions);

            // Assert
            Assert.IsTrue(result.Count > 0);
        }

        // Тест на обробку випадку, коли пошук не повертає результатів
        [TestMethod]
        public void SearchPromotions_NoResults()
        {
            // Arrange
            var user = new RegisteredUser("test@example.com", "password");
            RegisteredUser.registeredUsers.Add(user);

            var promotions = new List<Promotion>
            {
                new Promotion(1, "Shop A", "Electronics", "CODE1", DateTime.Now.AddDays(7), "photo1.jpg", "Description 1"),
                new Promotion(2, "Shop B", "Fashion", "CODE2", DateTime.Now.AddDays(5), "photo2.jpg", "Description 2")
            };
            // Act
            var result = user.SearchPromotions("Food", "", promotions);

            // Assert
            Assert.IsFalse(result.Count > 0);
        }

        // Тест на обробку випадку, коли категорія та ключові слова для пошуку порожні
        [TestMethod]
        public void SearchPromotions_EmptyCategoryAndKeywords_ReturnsEmptyList()
        {
            // Arrange
            var user = new RegisteredUser("test@example.com", "password");
            RegisteredUser.registeredUsers.Add(user);
            var promotions = new List<Promotion>
            {
                 new Promotion(1, "Shop A", "Electronics", "CODE1", DateTime.Now.AddDays(7), "photo1.jpg", "Description 1"),
                new Promotion(2, "Shop B", "Fashion", "CODE2", DateTime.Now.AddDays(5), "photo2.jpg", "Description 2")
            };
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                var result = user.SearchPromotions("", "", promotions);

                // Assert
                Assert.AreEqual(0, result.Count);
                Assert.AreEqual("Не вказано категорію або ключові слова для пошуку." + Environment.NewLine, sw.ToString());
            }

        }

        // Тест на перегляд деталей про акційну пропозицію з коректними даними
        [TestMethod]
        public void ViewPromotionDetails_ValidPromotion_Success()
        {
            // Arrange
            var user = new RegisteredUser("test@example.com", "password");
            RegisteredUser.registeredUsers.Add(user);
            var promotion = new Promotion(1, "Shop A", "Electronics", "CODE1", DateTime.Now.AddDays(7), "photo1.jpg", "Description 1");

            // Act
            Console.WriteLine("Viewing details for a valid promotion:");
            user.ViewPromotionDetails(promotion, true);
        }

        // Тест на обробку випадку, коли акційна пропозиція не існує
        [TestMethod]
        public void ViewPromotionDetails_NullPromotion_Failure()
        {
            // Arrange
            var user = new RegisteredUser("test@example.com", "password");
            RegisteredUser.registeredUsers.Add(user);

            // Act
            Console.WriteLine("Viewing details for a null promotion:");
            user.ViewPromotionDetails(null, true);
        }

        // Тест на отримання рядка з зареєстрованими користувачами
        [TestMethod]
        public void GetRegisteredUsersAsString_ReturnsStringWithRegisteredUsers()
        {
            // Arrange
            var user1 = new RegisteredUser("user1@example.com", "password");
            var user2 = new RegisteredUser("user2@example.com", "passwor");

            string expectedUser1 = $"RegisterUser: {user1.Email} {user1.Password}";
            string expectedUser2 = $"RegisterUser: {user2.Email} {user2.Password}";
            string expected = $"{expectedUser1}{Environment.NewLine}{expectedUser2}";

            // Act
            string result = RegisteredUser.GetRegisteredUsersAsString();

            // Assert
            Assert.IsTrue(result.Contains(expectedUser1));
            Assert.IsTrue(result.Contains(expectedUser2));
        }

        // Тест на отримання повідомлення, коли немає зареєстрованих користувачів
        [TestMethod]
        public void GetRegisteredUsersAsString_ReturnsMessageWhenNoRegisteredUsers()
        {
            // Arrange
            RegisteredUser.registeredUsers.Clear();

            // Act
            string result = RegisteredUser.GetRegisteredUsersAsString();

            // Assert
            StringAssert.Contains(result, "Немає зареєстрованих користувачів.");
        }
    }
}
