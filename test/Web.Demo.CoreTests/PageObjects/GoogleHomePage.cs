using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Web.Demo.CoreTests.PageObjects
{
    public class GoogleHomePage : CorePage
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
