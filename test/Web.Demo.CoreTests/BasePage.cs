using System;
using Web.TestFramework;
using OpenQA.Selenium;

namespace Web.Tests
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
