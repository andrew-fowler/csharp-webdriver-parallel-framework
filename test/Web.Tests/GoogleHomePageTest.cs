using Web.Tests.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Web.Tests
{
    [TestClass]
    public class GoogleHomePageTest : BaseTest
    {
        [TestMethod]
        public void Test_01()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
            var homePage = new GoogleHomePage(Driver);
            Assert.IsTrue(homePage.Doodle.Displayed);
        }

        [TestMethod]
        public void Test_02()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
            var homePage = new GoogleHomePage(Driver);
            Assert.IsTrue(homePage.Doodle.Displayed);
        }

        [TestMethod]
        public void Test_03()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
            var homePage = new GoogleHomePage(Driver);
            Assert.IsTrue(homePage.Doodle.Displayed);
        }

        [TestMethod]
        public void Test_04()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
            var homePage = new GoogleHomePage(Driver);
            Assert.IsTrue(homePage.Doodle.Displayed);
        }

        [TestMethod]
        public void Test_05()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
            var homePage = new GoogleHomePage(Driver);
            Assert.IsTrue(homePage.Doodle.Displayed);
        }

        [TestMethod]
        public void Test_06()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
            var homePage = new GoogleHomePage(Driver);
            Assert.IsTrue(homePage.Doodle.Displayed);
        }

        [TestMethod]
        public void Test_07()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
            var homePage = new GoogleHomePage(Driver);
            Assert.IsTrue(homePage.Doodle.Displayed);
        }

        [TestMethod]
        public void Test_08()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
            var homePage = new GoogleHomePage(Driver);
            Assert.IsTrue(homePage.Doodle.Displayed);
        }

        [TestMethod]
        public void Test_09()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
            var homePage = new GoogleHomePage(Driver);
            Assert.IsTrue(homePage.Doodle.Displayed);
        }
    }
}
