using Web.TestFramework;
using OpenQA.Selenium;

namespace Web.Tests
{
    public class WebPage : BasePage
    {
        public WebPage(IWebDriver driver) : base(driver)
        {
        }

        public string Title
        {
            get { return this.Driver.Title; }
        }
    }
}
