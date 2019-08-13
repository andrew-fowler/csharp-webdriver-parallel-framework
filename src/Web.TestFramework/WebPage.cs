using System;
using OpenQA.Selenium;

namespace Web.TestFramework
{
    public class WebPage
    {
        private readonly IWebDriver driver;

        protected IWebDriver Driver
        {
            get { return driver; }
        }
        
        public WebPage(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }
    }
}
