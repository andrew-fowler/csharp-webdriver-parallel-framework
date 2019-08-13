using Web.TestFramework;
using OpenQA.Selenium;

namespace Web.Tests
{
    public class BasePage : WebPage
    {
        public BasePage(IWebDriver driver) : base(driver)
        {
        }

        public string Title
        {
            get { return this.Driver.Title; }
        }
    }
}
