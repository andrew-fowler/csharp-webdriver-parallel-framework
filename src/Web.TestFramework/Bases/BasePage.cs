using System;
using OpenQA.Selenium;

namespace Web.TestFramework
{
    public class BasePage
    {
        private readonly IWebDriver driver;

        protected IWebDriver Driver
        {
            get { return driver; }
        }
        
        public BasePage(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }
    }
}
