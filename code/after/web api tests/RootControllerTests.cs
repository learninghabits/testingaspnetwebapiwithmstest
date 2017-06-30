using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using testing_asp_web_api_mstest.Controllers;

namespace web_api_tests
{
    [TestClass]
    public class RootControllerTests
    {
        [TestMethod]
        public void RootController_Get_WillReturnString()
        {
            var controller = new RootController();
            var message = controller.Get();
            Assert.AreEqual("API is ready to receive requests", message);
        }
    }
}



