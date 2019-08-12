using System;
using OpenQA.Selenium;

namespace Web.TestFramework
{
    public interface IWebDriverFactory
    {
        IWebDriver Create();
    }
}
