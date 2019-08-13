using Web.Tests.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Web.Tests
{
    [TestClass]
    public class GoogleHomePageTest : WebTest
    {
        private void ExampleTestBehaviour() {
            Driver.Navigate().GoToUrl(BaseUrl);
            var homePage = new GoogleHomePage(Driver);
            Assert.IsTrue(homePage.Doodle.Displayed);
        }
        [TestMethod]
        public void Test_01()
        {
            ExampleTestBehaviour();
        }

        [TestMethod]
        public void Test_02()
        {
            ExampleTestBehaviour();
        }

        [TestMethod]
        public void Test_03()
        {
            ExampleTestBehaviour();
        }

        [TestMethod]
        public void Test_04()
        {
            ExampleTestBehaviour();
        }

        [TestMethod]
        public void Test_05()
        {
            ExampleTestBehaviour();
        }

        [TestMethod]
        public void Test_06()
        {
            ExampleTestBehaviour();
        }

        [TestMethod]
        public void Test_07()
        {
            ExampleTestBehaviour();
        }

        [TestMethod]
        public void Test_08()
        {
            ExampleTestBehaviour();
        }

        [TestMethod]
        public void Test_09()
        {
            ExampleTestBehaviour();
        }
    }
}
