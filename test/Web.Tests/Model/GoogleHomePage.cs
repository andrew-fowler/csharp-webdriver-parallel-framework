using System;
using System.Collections.Generic;
using System.Text;
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
            get { return this.Driver.FindElement(By.XPath(@"//*[@id=""hplogo""]")); }
        }
    }
}
