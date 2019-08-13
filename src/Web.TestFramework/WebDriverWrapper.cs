using OpenQA.Selenium;
using System;

namespace Web.TestFramework
{
    public class WebDriverWrapper
    {
        private IWebDriver wrappedDriver;
        private IWebDriverFactory factory;

        public WebDriverWrapper(IWebDriverFactory factory)
        {
            this.factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        public IWebDriver WrappedDriver
        {
            get
            {
                if (wrappedDriver == null)
                {
                    wrappedDriver = factory.Create();
                }

                return wrappedDriver;
            }
        }

        public void DisposeWrapped()
        {
            wrappedDriver.Dispose();
            wrappedDriver = null;
        }
    }
}
