using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using NUnit.Framework;
using SportsStore.Controllers;
using SportsStore.Models.Repository;
using SportsStore.Models;

namespace SportsStore.Tests
{
    [TestFixture]
    public class ProductControllerTests
    {
        [Test]
        public void Can_Paginate()
        {
            // Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.GetProducts()).Returns(new[]
            {
                new Product {ProductID = 1, Name = "P1"},
                new Product {ProductID = 2, Name = "P2"},
                new Product {ProductID = 3, Name = "P3"},
                new Product {ProductID = 4, Name = "P4"},
                new Product {ProductID = 5, Name = "P5"}
            });
            ProductController controller = new ProductController(mock.Object) {PageSize = 3};
            // Act
            IEnumerable<Product> result =controller.List(2).ViewData.Model as IEnumerable<Product>;
            // Assert
            Product[] prodArray = result.ToArray();
            Assert.True(prodArray.Length == 2);
            Assert.AreEqual("P4", prodArray[0].Name);
            Assert.AreEqual("P5", prodArray[1].Name);
        }
    }
}
