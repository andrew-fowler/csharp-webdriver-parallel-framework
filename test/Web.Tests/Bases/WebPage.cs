using OpenQA.Selenium;
using Web.TestFramework;
using Web.TestFramework.Bases;

namespace Web.Tests.Bases
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
