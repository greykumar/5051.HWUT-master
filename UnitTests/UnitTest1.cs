using HWUT.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Id_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Id);
        }


        [TestMethod]
        public void ProductModel_Set_Id_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            // Act
            result.Id = "10";
            // Assert
            Assert.AreEqual("10", result.Id);
        }


        [TestMethod]
        public void ProductModel_Get_Maker_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Maker);
        }


        [TestMethod]
        public void ProductModel_Set_Maker_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            // Act
            result.Maker = "Grey";

            // Assert
            Assert.AreEqual("Grey", result.Maker);
        }


        [TestMethod]
        public void ProductModel_Get_Image_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Image);
        }


        [TestMethod]
        public void ProductModel_Set_Image_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            // Act
            result.Image = "~/img/listing.jpg";

            // Assert
            Assert.AreEqual("~/img/listing.jpg", result.Image);
        }

        [TestMethod]
        public void ProductModel_Get_Url_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Url);
        }

        [TestMethod]
        public void ProductModel_Set_Url_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Url = "https://www.hackster.io/agent-hawking-1/book-light-dee7e4";

            // Assert
            Assert.AreEqual("https://www.hackster.io/agent-hawking-1/book-light-dee7e4", result.Url);
        }

        [TestMethod]
        public void ProductModel_Get_Title_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Title);
        }

        [TestMethod]
        public void ProductModel_Set_Title_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            // Act
            result.Title = "A beautiful switch-on book light";

            // Assert
            Assert.AreEqual("A beautiful switch-on book light", result.Title);
        }


        [TestMethod]
        public void ProductModel_Get_Description_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Description);
        }


        [TestMethod]
        public void ProductModel_Set_Description_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            // Act
            result.Description = "Never used, so not gross. I want $$$";

            // Assert
            Assert.AreEqual("Never used, so not gross. I want $$$", result.Description);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToString(), result.Date.ToString());
        }

        [TestMethod]
        public void ProductModel_Set_Date_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            // Act
            result.Date = new DateTime(2020, 05, 28);

            // Assert
            Assert.AreEqual("5/28/2020", result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Get_Sequence_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Sequence);
        }

        [TestMethod]
        public void ProductModel_Set_Sequence_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            // Act
            result.Sequence = "Sequence 1";

            // Assert
            Assert.AreEqual("Sequence 1", result.Sequence);
        }

        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("Unknown", result.Email);
        }

        [TestMethod]
        public void ProductModel_Set_Email_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            // Act
            result.Email = "koenigm@seattleu.edu";

            // Assert
            Assert.AreEqual("koenigm@seattleu.edu", result.Email);
        }

        [TestMethod]
        public void ProductModel_Get_Logistics_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Set_Logistics_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            // Act
            result.Logistics = "I will pickup";

            // Assert
            Assert.AreEqual("I will pickup", result.Logistics);
        }



        [TestMethod]
        public void ProductModel_Get_Ratings_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(5, result.Ratings[0]);
           
            
        }

        [TestMethod]
        public void ProductModel_Set_Ratings_ChangeElement_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            // Act

            result.Ratings[0] = 10;
            // Assert
           
            Assert.AreEqual(10, result.Ratings[0]);
            
        }


        [TestMethod]
        public void ProductModel_ToString_Serialize_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            // Act
            string str = JsonSerializer.Serialize<ProductModel>(result);

            // Assert
            Assert.AreEqual(str, result.ToString());
        }

        [TestMethod]
        public void ProductModel_AverageRatings_Default_Should_Equal_5()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(5, result.AverageRating());
        }


        [TestMethod]
        public void ProductModel_AverageRatings_NullRating_Should_Equal_0()
        {
            // Arrange
            var result = new ProductModel();
            // Act
            result.Ratings = null;

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_AverageRatings_CountIs0_Should_Equal_0()
        {
            // Arrange
            var result = new ProductModel();
            // Act
            result.Ratings = new int[] { };

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_AverageRatings_TotalIs0_Should_Equal_0()
        {
            // Arrange
            var result = new ProductModel();
            // Act
            result.Ratings[0] = 0;

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }
    }
}
