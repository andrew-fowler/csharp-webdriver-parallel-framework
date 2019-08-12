using System;
using Web.TestFramework;
using OpenQA.Selenium;

namespace Web.Demo.CoreTests
{
    public class CorePage : WebPage
    {
        public CorePage(IWebDriver driver, Uri baseUrl, string path) : base(driver, baseUrl, path)
        {
        }

        public string Title
        {
            get { return this.Driver.Title; }
        }
    }
}
