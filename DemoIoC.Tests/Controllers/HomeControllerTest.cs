using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DemoIoC.Domain;
using DemoIoC.Domain.Entities;
using DemoIoC.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DemoIoC.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private HomeController controller;
        private Mock<IProductService> productServiceMock;


        [TestInitialize]
        public void InicializaTeste()
        {
            productServiceMock = new Mock<IProductService>();
            controller = new HomeController(productServiceMock.Object);
        }

        [TestMethod]
        public void Index_retorna_coleção_de_produtos()
        {
            // arrange
            createGetAllActiveProductsStub();

            // act
            var result = controller.Index() as ViewResult;

            // assert
            Assert.IsInstanceOfType(result.Model, typeof(ICollection<Product>));
        }

      

        [TestMethod]
        public void Index_retorna_view_padrão()
        {
            // arrange
            createGetAllActiveProductsStub();

            // act
            var result = controller.Index() as ViewResult;

            // assert
            Assert.AreEqual(String.Empty, result.ViewName);
        }

        private void createGetAllActiveProductsStub()
        {
            productServiceMock.Setup(x => x.GetAllActiveProducts())
                .Returns(new List<Product>());
        }
    }
}
