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
            var homePage = new GoogleHomePage(this.Driver, this.BaseUrl, "/");
            homePage.Navigate();
        }

        [TestMethod]
        public void Test_02()
        {
            var homePage = new GoogleHomePage(this.Driver, this.BaseUrl, "/");
            homePage.Navigate();
        }

        [TestMethod]
        public void Test_03()
        {
            var homePage = new GoogleHomePage(this.Driver, this.BaseUrl, "/");
            homePage.Navigate();
        }

        [TestMethod]
        public void Test_04()
        {
            var homePage = new GoogleHomePage(this.Driver, this.BaseUrl, "/");
            homePage.Navigate();
        }

        [TestMethod]
        public void Test_05()
        {
            var homePage = new GoogleHomePage(this.Driver, this.BaseUrl, "/");
            homePage.Navigate();
        }

        [TestMethod]
        public void Test_06()
        {
            var homePage = new GoogleHomePage(this.Driver, this.BaseUrl, "/");
            homePage.Navigate();
        }

        [TestMethod]
        public void Test_07()
        {
            var homePage = new GoogleHomePage(this.Driver, this.BaseUrl, "/");
            homePage.Navigate();
        }

        [TestMethod]
        public void Test_08()
        {
            var homePage = new GoogleHomePage(this.Driver, this.BaseUrl, "/");
            homePage.Navigate();
        }

        [TestMethod]
        public void Test_09()
        {
            var homePage = new GoogleHomePage(this.Driver, this.BaseUrl, "/");
            homePage.Navigate();
        }


        //[TestMethod]
        //public void GoogleHomePage_Visited_DoodleDisplayed()
        //{
        //     var homePage = new GoogleHomePage(this.Driver, this.BaseUrl, "/");
        //    homePage.Navigate();

        //    System.Threading.Thread.Sleep(10000);
        //    var displayed = homePage.Doodle.Displayed;

        //    Assert.IsTrue(displayed, "Doodle is not displayed");
        //}

        //[TestMethod]
        //public void GoogleHomePage_Visited_TitleIsGoogle()
        //{
        //    var homePage = new GoogleHomePage(this.Driver, this.BaseUrl, "/");
        //    homePage.Navigate();

        //    System.Threading.Thread.Sleep(10000);
        //    var text = homePage.Title;

        //    Assert.AreEqual("Google", text, false);
        //}
    }
}
