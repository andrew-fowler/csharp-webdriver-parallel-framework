using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Web.Tests.Model
{
    public class GoogleHomePage : BasePage
    {
        public GoogleHomePage(IWebDriver driver, Uri baseUrl, string path) : base(driver, baseUrl, path)
        {
        }

        public IWebElement Doodle
        {
            get { return this.Driver.FindElement(By.XPath(@"//*[@id=""hplogo""]")); }
        }
    }
}
