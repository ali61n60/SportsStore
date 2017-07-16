using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Routing;
using Moq;
using NUnit.Framework;
using SportsStore.Components;
using SportsStore.Models;
using SportsStore.Models.Repository;

namespace SportsStore.Tests
{
    [TestFixture]
    class NavigationMenuViewComponentTests
    {
        [Test]
        public void Can_Select_Categories()
        {
            // Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.GetProducts()).Returns(new[] {
                new Product {ProductID = 1, Name = "P1", Category = "Apples"},
                new Product {ProductID = 2, Name = "P2", Category = "Apples"},
                new Product {ProductID = 3, Name = "P3", Category = "Plums"},
                new Product {ProductID = 4, Name = "P4", Category = "Oranges"},
            });
            NavigationMenuViewComponent target =new NavigationMenuViewComponent(mock.Object);
            // Act = get the set of categories
            string[] results = ((IEnumerable<string>)(target.Invoke()
                as ViewViewComponentResult).ViewData.Model).ToArray();
            // Assert
            Assert.True(Enumerable.SequenceEqual(new[] { "Apples",
                "Oranges", "Plums" }, results));
        }

        [Test]
        public void Indicates_Selected_Category()
        {
            // Arrange
            string categoryToSelect = "Apples";
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.GetProducts()).Returns(new[] {
                new Product {ProductID = 1, Name = "P1", Category = "Apples"},
                new Product {ProductID = 4, Name = "P2", Category = "Oranges"},
            });
            NavigationMenuViewComponent target =new NavigationMenuViewComponent(mock.Object);
            target.ViewComponentContext = new ViewComponentContext
            {
                ViewContext = new ViewContext
                {
                    RouteData = new RouteData()
                }
            };
            target.RouteData.Values["category"] = categoryToSelect;
            // Action
            string result = (string)(target.Invoke() as
                ViewViewComponentResult).ViewData["SelectedCategory"];
            // Assert
            Assert.AreEqual(categoryToSelect, result);
        }
    }
}
