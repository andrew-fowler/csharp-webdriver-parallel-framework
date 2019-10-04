using OpenQA.Selenium;

namespace Web.TestFramework.Factories
{
    public interface IWebDriverFactory
    {
        IWebDriver Create();
    }
}
