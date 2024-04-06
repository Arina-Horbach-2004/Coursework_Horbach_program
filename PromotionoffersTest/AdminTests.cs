using Promotional_offers.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionoffersTest
{
    [TestClass]
    public class AdminTests
    {
        // Перевірка аутентифікації з коректними обліковими даними повертає true
        [TestMethod]
        public void Authenticate_CorrectCredentials_ReturnsTrue()
        {
            // Arrange
            string login = "administratorlogin@gmail.com";
            string password = "adminpassword";
            Admin admin = new Admin(login, password);

            // Act
            bool result = admin.Authenticate(login, password);

            // Assert
            Assert.IsTrue(result);
        }

        // Перевірка аутентифікації з некоректними обліковими даними повертає false
        [TestMethod]
        public void Authenticate_IncorrectCredentials_ReturnsFalse()
        {
            // Arrange
            string login = "invalidlogin@gmail.com";
            string password = "invalidpassword";
            Admin admin = new Admin(login, password);

            // Act
            bool result = admin.Authenticate(login, password);

            // Assert
            Assert.IsFalse(result);
        }

        //Перевірка створення промоакції з коректними вхідними даними успішно
        [TestMethod]
        public void CreatePromotion_ValidInput_CreatesPromotionSuccessfully()
        {
            // Arrange
            Admin admin = new Admin("admin@example.com", "adminpassword");
            int id = 1;
            string store = "Store";
            string category = "Category";
            string promoCode = "CODE123";
            DateTime expirationDate = DateTime.Now.AddDays(7);
            string photo = "photo.jpg";
            string decription = "Весняні Знижки до 10.04. Товари дешевше навіть на 30%!";

            // Act
            bool result = admin.CreatePromotion(id, store, category, promoCode, expirationDate, photo, decription);

            // Assert
            Assert.IsTrue(result);
        }

        // Перевірка редагування промоакції з коректними вхідними даними успішно
        [TestMethod]
        public void EditPromotion_ValidInput_EditsPromotionSuccessfully()
        {
            // Arrange
            Admin admin = new Admin("admin@example.com", "adminpassword");
            int id = 1;
            string store = "Store";
            string category = "Category";
            string promoCode = "CODE123";
            DateTime expirationDate = DateTime.Now.AddDays(7);
            string photo = "photo.jpg";
            string decription = "Весняні Знижки до 10.04. Товари дешевше навіть на 30%!";

            // Create promotion
            admin.CreatePromotion(id, store, category, promoCode, expirationDate, photo, decription);

            // New values for editing
            string newStore = "NewStore";
            string newCategory = "NewCategory";
            string newPromoCode = "NEWCODE";
            DateTime newExpirationDate = DateTime.Now.AddDays(14);
            string newPhoto = "newphoto.jpg";
            string newdecription = "ПОПУЛЯРНІ СНІКЕРСИ ЗНИЖКИ ДО -30% на вибрані товари";

            // Act
            bool result = admin.EditPromotion(id, newStore, newCategory, newPromoCode, newExpirationDate, newPhoto, newdecription);

            // Assert
            Assert.IsTrue(result);
        }

        // Перевірка успішного видалення промоакції та додавання її до списку видалених промоакцій
        [TestMethod]
        public void DeletePromotion_PromotionExists_DeletesAndAddsToDeletedPromotions()
        {
            DateTime expiryDate = DateTime.Now.AddDays(7); // Отримуємо поточну дату і додаємо до неї 7 днів
            var admin = new Admin("admin@example.com", "adminpassword");
            var promotionsList = new List<Promotion>
            {
                 new Promotion(1, "Shop A", "Electronics", "CODE1", expiryDate, "photo1.jpg", "Description 1"),
                  new Promotion(2, "Shop B", "Electronics", "CODE2", expiryDate, "photo2.jpg", "Description 2"),
                  new Promotion(3, "Shop C", "Electronics", "CODE3", expiryDate, "photo3.jpg", "Description 3")
            };

            foreach (var promotion in promotionsList)
            {
                Promotion.CreatePromotion(promotion.ID, promotion.Shop, promotion.Category, promotion.Code, promotion.ExpiryDate, promotion.Photo, promotion.Description);
            }

            // Act
            bool result = admin.DeletePromotion(1);

            // Assert
            Assert.IsTrue(result); // Перевірка, що промокод був успішно видалений

            // Перевірка, чи промокод дійсно був доданий до списку видалених промокодів
            Assert.IsTrue(Promotion.deletedPromotions.Any(p => p.ID == 1 && p.ExpiryDate == expiryDate));
        }

        // Перевірка  видалення неіснуючої промоакції
        [TestMethod]
        public void DeletePromotion_PromotionDoesNotExist_ReturnsFalse()
        {
            Admin admin = new Admin("admin@example.com", "adminpassword");
            // Arrange
            List<Promotion> promotionsList = new List<Promotion>
            {
                new Promotion(1, "Shop A", "Category A", "CODE1", DateTime.Now.AddDays(7), "photo1.jpg", "Description 1"),
                new Promotion(2, "Shop B", "Category B", "CODE2", DateTime.Now.AddDays(7), "photo2.jpg", "Description 2"),
                new Promotion(3, "Shop C", "Category C", "CODE3", DateTime.Now.AddDays(7), "photo3.jpg", "Description 3")
            };
            int idToDelete = 4;

            // Act
            bool result = admin.DeletePromotion(idToDelete);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(3, promotionsList.Count);
        }

        // Перевірка правильності генерації рядка з активними промоакціями
        [TestMethod]
        public void GetActivePromotionsAsString_ReturnsStringWithActivePromotions()
        {
            // Arrange
            var promotion1 = new Promotion(1, "Shop1", "Category1", "Code1", DateTime.Now.AddDays(1), "Photo1", "Description1");
            var promotion2 = new Promotion(2, "Shop2", "Category2", "Code2", DateTime.Now.AddDays(2), "Photo2", "Description2");
            Promotion.promotionsList.Add(promotion1);
            Promotion.promotionsList.Add(promotion2);

            // Expected result
            // Очікуваний результат
            string expectedPromotion1 = $"ID: {promotion1.ID}, Shop: {promotion1.Shop}, Category: {promotion1.Category}, Code: {promotion1.Code}, ExpiryDate: {promotion1.ExpiryDate.ToString("dd.MM.yyyy")}, Photo: {promotion1.Photo}, Description: {promotion1.Description}";
            string expectedPromotion2 = $"ID: {promotion2.ID}, Shop: {promotion2.Shop}, Category: {promotion2.Category}, Code: {promotion2.Code}, ExpiryDate: {promotion2.ExpiryDate.ToString("dd.MM.yyyy")}, Photo: {promotion2.Photo}, Description: {promotion2.Description}";
            string expected = $"{expectedPromotion1}{Environment.NewLine}{expectedPromotion2}";


            // Act
            var result = Admin.GetActivePromotionsAsString();

            // Assert
            StringAssert.Contains(result, expected);
        }

        // Перевірка повернення рядка з активними промоакціями, коли немає активних промоакцій.
        [TestMethod]
        public void GetActivePromotionsAsString_NoActivePromotions_ReturnsMessage()
        {
            // Arrange
            Promotion.promotionsList.Clear();

            // Expected result
            string expected = "Немає активних промокодів.";

            // Act
            var result = Admin.GetActivePromotionsAsString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Перевірка повернення рядка з видаленими промоакціями.
        [TestMethod]
        public void GetDeletedPromotionsAsString_ReturnsStringWithDeletedPromotions()
        {
            // Arrange
            var promotion1 = new Promotion(1, "Shop1", "Category1", "Code1", DateTime.Now.AddDays(1), "Photo1", "Description1");
            var promotion2 = new Promotion(2, "Shop2", "Category2", "Code2", DateTime.Now.AddDays(2), "Photo2", "Description2");
            Promotion.deletedPromotions.Add(promotion1);
            Promotion.deletedPromotions.Add(promotion2);

            // Expected result
            string expectedPromotion1 = $"ID: {promotion1.ID}, Shop: {promotion1.Shop}, Category: {promotion1.Category}, Code: {promotion1.Code}, ExpiryDate: {promotion1.ExpiryDate.ToString("dd.MM.yyyy")}, Photo: {promotion1.Photo}, Description: {promotion1.Description}";
            string expectedPromotion2 = $"ID: {promotion2.ID}, Shop: {promotion2.Shop}, Category: {promotion2.Category}, Code: {promotion2.Code}, ExpiryDate: {promotion2.ExpiryDate.ToString("dd.MM.yyyy")}, Photo: {promotion2.Photo}, Description: {promotion2.Description}";
            string expected = $"{expectedPromotion1}{Environment.NewLine}{expectedPromotion2}";

            // Act
            var result = Admin.GetDeletedPromotionsAsString();

            // Assert
            StringAssert.Contains(result, expected);
        }

        // Перевірка повернення повідомлення про відсутність видалених промоакцій.
        [TestMethod]
        public void GetDeletedPromotionsAsString_NoDeletedPromotions_ReturnsMessage()
        {
            // Arrange
            Promotion.deletedPromotions.Clear();

            // Expected result
            string expected = "Немає видалених промокодів.";

            // Act
            var result = Admin.GetDeletedPromotionsAsString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Перевірка повернення рядка з зареєстрованими користувачами.
        [TestMethod]
        public void GetRegisteredUsersAsString_ReturnsStringWithRegisteredUsers()
        {
            // Arrange
            var user1 = new RegisteredUser("user1@example.com", "password");
            var user2 = new RegisteredUser("user2@example.com", "passwor");

            string expectedUser1 = $"RegisterUser: {user1.Email} {user1.Password}";
            string expectedUser2 = $"RegisterUser: {user2.Email} {user2.Password}";
            //string expected = $"{expectedUser1}{Environment.NewLine}{expectedUser2}";

            // Act
            string result = Admin.GetRegisteredUsersAsString();

            // Assert
            Assert.IsTrue(result.Contains(expectedUser1));
            Assert.IsTrue(result.Contains(expectedUser2));
        }

        // Перевірка повернення повідомлення про відсутність зареєстрованих користувачів.
        [TestMethod]
        public void GetRegisteredUsersAsString_NoRegisteredUsers_ReturnsMessage()
        {
            // Arrange
            RegisteredUser.registeredUsers.Clear();

            // Expected result
            string expected = "Немає зареєстрованих користувачів.";

            // Act
            string result = Admin.GetRegisteredUsersAsString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Перевірка збереження промоакцій у форматі JSON.
        [TestMethod]
        public void SavePromotionsToJson_SuccessfullySavesPromotions()
        {
            // Arrange
            string filePath = "test_promotions.json";
            Admin admin = new Admin("admin@example.com", "adminpassword");
            admin.CreatePromotion(1, "Store A", "Category A", "CODE1", DateTime.Now.AddDays(7), "photo1.jpg", "Description 1");
            admin.CreatePromotion(2, "Store B", "Category B", "CODE2", DateTime.Now.AddDays(7), "photo2.jpg", "Description 2");

            // Act
            admin.SavePromotionsToJson(filePath);

            // Assert
            Assert.IsTrue(File.Exists(filePath));
        }

        // Перевірка завантаження промоакцій з JSON.
        [TestMethod]
        public void LoadPromotionsFromJson_SuccessfullyLoadsPromotions()
        {
            // Arrange
            string filePath = "test_promotions.json";
            Admin admin = new Admin("admin@example.com", "adminpassword");
            admin.CreatePromotion(1, "Store A", "Category A", "CODE1", DateTime.Now.AddDays(7), "photo1.jpg", "Description 1");
            admin.CreatePromotion(2, "Store B", "Category B", "CODE2", DateTime.Now.AddDays(7), "photo2.jpg", "Description 2");

            // Save promotions to JSON
            admin.SavePromotionsToJson(filePath);

            // Clear promotions list
            Promotion.promotionsList.Clear();

            // Act
            admin.LoadPromotionsFromJson(filePath);

            // Assert
            Assert.AreEqual(2, Promotion.promotionsList.Count);
        }

        // Перевірка збереження видалених промоакцій у форматі JSON.
        [TestMethod]
        public void SaveDeletedPromotionsToJson_SuccessfullySavesDeletedPromotions()
        {
            // Arrange
            string filePath = "test_deleted_promotions.json";
            Admin admin = new Admin("admin@example.com", "adminpassword");
            Promotion.deletedPromotions.Clear(); // Очищаем список удаленных промокодов
            Promotion.deletedPromotions.Add(new Promotion(1, "Shop A", "Category A", "CODE1", DateTime.Now.AddDays(-7), "photo1.jpg", "Description 1"));
            Promotion.deletedPromotions.Add(new Promotion(2, "Shop B", "Category B", "CODE2", DateTime.Now.AddDays(-7), "photo2.jpg", "Description 2"));

            // Act
            admin.SaveDeletedPromotionsToJson(filePath);

            // Assert
            Assert.IsTrue(File.Exists(filePath));
        }

        // Перевірка завантаження видалених промоакцій з JSON.
        [TestMethod]
        public void LoadDeletedPromotionsFromJson_SuccessfullyLoadsDeletedPromotions()
        {
            // Arrange
            string filePath = "test_deleted_promotions.json";
            Admin admin = new Admin("admin@example.com", "adminpassword");
            Promotion.deletedPromotions.Clear();
            string jsonContent = "[{\"ID\":1,\"Shop\":\"Shop A\",\"Category\":\"Category A\",\"Code\":\"CODE1\",\"ExpiryDate\":\"2024-03-29T09:00:00\",\"Photo\":\"photo1.jpg\",\"Description\":\"Description 1\"},{\"ID\":2,\"Shop\":\"Shop B\",\"Category\":\"Category B\",\"Code\":\"CODE2\",\"ExpiryDate\":\"2024-03-29T09:00:00\",\"Photo\":\"photo2.jpg\",\"Description\":\"Description 2\"}]";
            File.WriteAllText(filePath, jsonContent);

            // Act
            admin.LoadDeletedPromotionsFromJson(filePath);

            // Assert
            Assert.AreEqual(2, Promotion.deletedPromotions.Count);
            Assert.AreEqual(1, Promotion.deletedPromotions[0].ID);
            Assert.AreEqual("Shop A", Promotion.deletedPromotions[0].Shop);
            Assert.AreEqual("Category A", Promotion.deletedPromotions[0].Category);
            Assert.AreEqual("CODE1", Promotion.deletedPromotions[0].Code);
            Assert.AreEqual(DateTime.Parse("2024-03-29T09:00:00"), Promotion.deletedPromotions[0].ExpiryDate);
            Assert.AreEqual("photo1.jpg", Promotion.deletedPromotions[0].Photo);
            Assert.AreEqual("Description 1", Promotion.deletedPromotions[0].Description);
            Assert.AreEqual(2, Promotion.deletedPromotions[1].ID);
            Assert.AreEqual("Shop B", Promotion.deletedPromotions[1].Shop);
            Assert.AreEqual("Category B", Promotion.deletedPromotions[1].Category);
            Assert.AreEqual("CODE2", Promotion.deletedPromotions[1].Code);
            Assert.AreEqual(DateTime.Parse("2024-03-29T09:00:00"), Promotion.deletedPromotions[1].ExpiryDate);
            Assert.AreEqual("photo2.jpg", Promotion.deletedPromotions[1].Photo);
            Assert.AreEqual("Description 2", Promotion.deletedPromotions[1].Description);
        }
    }
}
