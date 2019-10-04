using OpenQA.Selenium;
using System;
using Web.TestFramework.Factories;

namespace Web.TestFramework
{
    public class WebDriverWrapper
    {
        private IWebDriver _wrappedDriver;
        private IWebDriverFactory _factory;

        public WebDriverWrapper(IWebDriverFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        public IWebDriver WrappedDriver => _wrappedDriver ?? (_wrappedDriver = _factory.Create());

        public void DisposeWrapped()
        {
            _wrappedDriver.Dispose();
            _wrappedDriver = null;
        }
    }
}
