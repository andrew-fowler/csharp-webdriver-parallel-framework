using Web.Tests.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Web.Tests.Bases;


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

        [TestMethod]
        public void Test_10()
        {
            ExampleTestBehaviour();
        }

        [TestMethod]
        public void Test_11()
        {
            ExampleTestBehaviour();
        }

        [TestMethod]
        public void Test_12()
        {
            ExampleTestBehaviour();
        }

        [TestMethod]
        public void Test_13()
        {
            ExampleTestBehaviour();
        }

        [TestMethod]
        public void Test_14()
        {
            ExampleTestBehaviour();
        }

        [TestMethod]
        public void Test_15()
        {
            ExampleTestBehaviour();
        }

        [TestMethod]
        public void Test_16()
        {
            ExampleTestBehaviour();
        }

        [TestMethod]
        public void Test_17()
        {
            ExampleTestBehaviour();
        }

        [TestMethod]
        public void Test_18()
        {
            ExampleTestBehaviour();
        }

        [TestMethod]
        public void Test_19()
        {
            ExampleTestBehaviour();
        }

        [TestMethod]
        public void Test_20()
        {
            ExampleTestBehaviour();
        }
    }
}
