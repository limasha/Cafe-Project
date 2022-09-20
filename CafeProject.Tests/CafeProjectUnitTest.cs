using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Linq;
using System.Web.Mvc;
using CafeProject;
using CafeProject.Controllers;
using CafeProject.Models;


namespace CafeProject.Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class CafeProjectUnitTest
    {

        [TestMethod]
        public void Admin()
        {
            var expected = "";
            AdminController controller = new AdminController();
            var result = controller.Admin() as ViewResult;
            Assert.AreEqual(expected,result.ViewName);
        }

        [TestMethod]
        public void Create()
        {
            //Arrange
            var controller = new AdminController();

            //Act
            var result = controller.Create() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Details()
        {
            //Arrange
            var controller = new AdminController();
            var dbHandler = new ItemDbHandler();
            var model = new ItemList();
            //Act
            var result = controller.Details(7) as ViewResult;
            var expected = dbHandler.GetItemList();

            //Assert
            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void PlaceOrder()
        {
            PointofSaleController pointofSale = new PointofSaleController();
            var result = pointofSale.PlaceOrder() as ViewResult;
            Assert.IsNotNull(result); 
           
        }

        [TestMethod]
        public void OrderIndex()
        {
            PointofSaleController pointofSale = new PointofSaleController();
            var result = pointofSale.OrderIndex() as ViewResult;
            Assert.AreEqual("Item List Page", result.ViewBag.Message);

        }
    }
}
