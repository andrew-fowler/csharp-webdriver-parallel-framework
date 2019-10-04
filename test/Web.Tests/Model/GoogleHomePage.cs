using OpenQA.Selenium;
using Web.Tests.Bases;

namespace Web.Tests.Model
{
    public class GoogleHomePage : WebPage
    {
        public GoogleHomePage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement Doodle => Driver.FindElement(By.XPath(@"//*[@id='hplogo']"));
    }
}
