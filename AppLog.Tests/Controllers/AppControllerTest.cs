using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppLog;
using AppLog.Controllers;

namespace AppLog.Tests.Controllers
{
    [TestClass]
    public class AppControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            AppController controller = new AppController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            AppController controller = new AppController();

            // Act
            ViewResult result = controller.About() as ViewResult;
        }
    }
}
