using OpenQA.Selenium;

namespace Web.Tests.Model
{
    public class GoogleHomePage : BasePage
    {
        public GoogleHomePage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement Doodle
        {
            get { return Driver.FindElement(By.XPath(@"//*[@id=""hplogo""]")); }
        }
    }
}
