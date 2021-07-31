using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;
using QNATest;




namespace QNATest
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            
            HomeController controller = new HomeController();
           
            ViewResult result = controller.Index() as ViewResult;
            
            Assert.IsNotNull(result);
        }
        public void Privacy()
        {

            HomeController controller = new HomeController();

            ViewResult result = controller.Privacy() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
