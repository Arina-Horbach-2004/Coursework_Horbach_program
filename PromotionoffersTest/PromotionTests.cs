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
        // ��������, �� ������������ ������� ��������� ������� true
        [TestMethod]
        public void UsePromotion_ValidPromoCode_ReturnsTrue()
        {
            // Arrange
            Promotion promotion = new Promotion(1, "Shop", "Category", "123ABC", DateTime.Now.AddDays(1), "photo", "������ ������ �� 10.04. ������ ������� ����� �� 30%!");

            // Act
            bool result = promotion.UsePromotion("123ABC");

            // Assert
            Assert.IsTrue(result);
        }

        // ��������, �� ������������ ��������� ��������� ������� false
        [TestMethod]
        public void UsePromotion_InvalidPromoCode_ReturnsFalse()
        {
            // Arrange
            Promotion promotion = new Promotion(1, "Shop", "Category", "123ABC", DateTime.Now.AddDays(1), "photo", "������ ������ �� 10.04. ������ ������� ����� �� 30%!");

            // Act
            bool result = promotion.UsePromotion("456DEF");

            // Assert
            Assert.IsFalse(result);
        }

        // �������� �������� ��������� ���� ����������
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
            string decription = "������ ������ �� 10.04. ������ ������� ����� �� 30%!";

            // Act
            bool result = Promotion.CreatePromotion(id, shop, category, code, expiryDate, photo, decription);

            // Assert
            Assert.IsTrue(result);
        }

        // ��������, �� ��������� ���������� � �������� ��������������� ������� false
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
            string decription = "������ ������ �� 10.04. ������ ������� ����� �� 30%!";

            // Create the first promotion
            Promotion.CreatePromotion(id, shop, category, code, expiryDate, photo, decription);
            Assert.ThrowsException<Exception>(() => Promotion.CreatePromotion(id, shop, category, code, expiryDate, photo, decription));
    }

        // �������� �������� ����������� ������� ����������
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
            string decription = "������ ������ �� 10.04. ������ ������� ����� �� 30%!";

            // Create and add a promotion to the promotions list
            Promotion.CreatePromotion(id, shop, category, code, expiryDate, photo, decription);

            // New values for editing
            string newShop = "NewShop";
            string newCategory = "NewCategory";
            string newCode = "456DEF";
            DateTime newExpiryDate = DateTime.Now.AddDays(2);
            string newPhoto = "newphoto";
            string newdecription = "�������Ͳ �Ͳ����� ������ �� -30% �� ������ ������";

            // Act
            Promotion promotion = new Promotion(id, shop, category, code, expiryDate, photo, decription);
            bool result = promotion.EditPromotion(id, newShop, newCategory, newCode, newExpiryDate, newPhoto, newdecription);

            // Assert
            Assert.IsTrue(result);
        }

        // ��������, �� ����������� �������� ���������� ������� false
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
            string decription = "������ ������ �� 10.04. ������ ������� ����� �� 30%!";

            Promotion promotion = new Promotion(id, shop, category, code, expiryDate, photo, decription);

            // Act
            bool result = promotion.EditPromotion(id, shop, category, code, expiryDate, photo, decription);

            // Assert
            Assert.IsFalse(result);
        }

        // �������� �������� ��������� ���������� �� ��������� �� �� ������ ��������� ����������
        [TestMethod]
        public void DeletePromotion_PromotionExists_DeletesAndAddsToDeletedPromotions()
        {
            // Arrange
            DateTime expiryDate = DateTime.Now.AddDays(7); // �������� ������� ���� � ������ �� �� 7 ���
            var promotion = new Promotion(1, "Shop A", "Electronics", "CODE1", expiryDate, "photo1.jpg", "Description 1");
            Promotion.CreatePromotion(promotion.ID, promotion.Shop, promotion.Category, promotion.Code, expiryDate, promotion.Photo, promotion.Description);

            // Act
            bool result = Promotion.DeletePromotion(1);

            // Assert
            Assert.IsTrue(result); // ��������, �� �������� ��� ������ ���������

            // ��������, �� �������� ����� ��� ������� �� ������ ��������� ���������
            Assert.IsTrue(Promotion.deletedPromotions.Any(p => p.ID == promotion.ID && p.ExpiryDate == expiryDate));
        }

        // ���� �� ��������� ���������, ���� �������� �� ����: ������� false � �� ������� ���
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
            Assert.IsFalse(result); // ��������, �� ����� �������� false, ������� �������� �� ��� ���������
            CollectionAssert.DoesNotContain(Promotion.GetValidPromotions(), promotion); // ��������, �� ������ �������� ��������� �� �������
            CollectionAssert.DoesNotContain(Promotion.deletedPromotions, promotion); // ��������, �� ������ ��������� ��������� �� �������
        }

        // ���� �� ����������� �������� ���������� ��� ����������������� �����������
        [TestMethod]
        public void DisplayDetails_AuthenticatedUser_DisplaysDetailedInformation()
        {
            // Arrange
            int id = 1;
            string shop = "�������";
            string category = "��������";
            string code = "123ABC";
            DateTime expiryDate = DateTime.Now.AddDays(1);
            string photo = "����";
            string description = "������ ������ �� 10.04. ������ ������� ����� �� 30%!";

            Promotion promotion = new Promotion(id, shop, category, code, expiryDate, photo, description);

            // ��������������� ������ ������ � StringWriter ��� ���� ����������
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                promotion.DisplayDetails(isAuthenticated: true);

                // Assert
                string expectedOutput = $"�������� ���������� ��� ������� ����������:\r\n" +
                                        $"�������: {shop}\r\n" +
                                        $"��������: {category}\r\n" +
                                        $"��������: {code}\r\n" +
                                        $"���� ���������: {expiryDate}\r\n" +
                                        $"����: {photo}\r\n" +
                                        $"����: {description}\r\n";

                Assert.AreEqual(expectedOutput, sw.ToString());
            }
        }

        // ���� �� ����������� �������� ���������� ��� ������������������� �����������
        [TestMethod]
        public void DisplayDetails_UnauthenticatedUser_Success()
        {
            // Arrange
            var promotion = new Promotion(1, "Shop A", "Electronics", "CODE1", DateTime.Now.AddDays(7), "photo1.jpg", "Description 1");

            // Act
            Console.WriteLine("³���������� ������� ��� ������������������� �����������:");
            promotion.DisplayDetails(false);
        }

        // ���� �� ��������� ����� � ��������� �����������
        [TestMethod]
        public void GetActivePromotionsAsString_ReturnsStringWithActivePromotions()
        {
            // Arrange
            var promotion1 = new Promotion(1, "Shop1", "Category1", "Code1", DateTime.Now.AddDays(1), "Photo1", "Description1");
            var promotion2 = new Promotion(2, "Shop2", "Category2", "Code2", DateTime.Now.AddDays(2), "Photo2", "Description2");
            Promotion.promotionsList.Add(promotion1);
            Promotion.promotionsList.Add(promotion2);

            // ���������� ���������
            string expectedPromotion1 = $"ID: {promotion1.ID}, Shop: {promotion1.Shop}, Category: {promotion1.Category}, Code: {promotion1.Code}, ExpiryDate: {promotion1.ExpiryDate.ToString("dd.MM.yyyy")}, Photo: {promotion1.Photo}, Description: {promotion1.Description}";
            string expectedPromotion2 = $"ID: {promotion2.ID}, Shop: {promotion2.Shop}, Category: {promotion2.Category}, Code: {promotion2.Code}, ExpiryDate: {promotion2.ExpiryDate.ToString("dd.MM.yyyy")}, Photo: {promotion2.Photo}, Description: {promotion2.Description}";
            string expected = $"{expectedPromotion1}{Environment.NewLine}{expectedPromotion2}";

            // Act
            var result = Promotion.GetActivePromotionsAsString();

            // Assert
            StringAssert.Contains(result, expected);
        }

        // ���� �� ��������� ����� ��� �������� ���������, ���� ���� ������
        [TestMethod]
        public void GetActivePromotionsAsString_ReturnsNoActivePromotions_WhenNoneExist()
        {
            // Arrange
            Promotion.promotionsList.Clear();

            // Act
            var result = Promotion.GetActivePromotionsAsString();

            // Assert
            Assert.AreEqual("���� �������� ���������.", result);
        }

        // ���� �� ��������� ����� � ���������� �����������
        [TestMethod]
        public void GetDeletedPromotionsAsString_ReturnsStringWithDeletedPromotions()
        {
            // Arrange
            var promotion1 = new Promotion(1, "Shop1", "Category1", "Code1", DateTime.Now.AddDays(1), "Photo1", "Description1");
            var promotion2 = new Promotion(2, "Shop2", "Category2", "Code2", DateTime.Now.AddDays(2), "Photo2", "Description2");
            Promotion.deletedPromotions.Add(promotion1);
            Promotion.deletedPromotions.Add(promotion2);

            // ���������� ���������
            string expectedPromotion1 = $"ID: {promotion1.ID}, Shop: {promotion1.Shop}, Category: {promotion1.Category}, Code: {promotion1.Code}, ExpiryDate: {promotion1.ExpiryDate.ToString("dd.MM.yyyy")}, Photo: {promotion1.Photo}, Description: {promotion1.Description}";
            string expectedPromotion2 = $"ID: {promotion2.ID}, Shop: {promotion2.Shop}, Category: {promotion2.Category}, Code: {promotion2.Code}, ExpiryDate: {promotion2.ExpiryDate.ToString("dd.MM.yyyy")}, Photo: {promotion2.Photo}, Description: {promotion2.Description}";
            string expected = $"{expectedPromotion1}{Environment.NewLine}{expectedPromotion2}";

            // Actsx
            var result = Promotion.GetDeletedPromotionsAsString();

            // Assert
            StringAssert.Contains(result, expected);
        }

        // ���� �� ��������� ����� ��� ��������� ���������, ���� ���� ������
        [TestMethod]
        public void GetDeletedPromotionsAsString_NoDeletedPromotions_ReturnsMessage()
        {
            // Arrange
            Promotion.deletedPromotions.Clear();

            // ���������� ���������
            string expected = "���� ��������� ���������.";

            // Act
            var result = Promotion.GetDeletedPromotionsAsString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        // ���� �� ���������� ��������� � ����� ID
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