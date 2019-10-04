using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Web.TestFramework.Factories
{
    class BrowserstackDriverFactory : IWebDriverFactory
    {
        private readonly Uri _host;
        private readonly ICapabilities _capabilities;
        private readonly TimeSpan _commandTimeout;

        public BrowserstackDriverFactory(Uri host, ICapabilities capabilities, TimeSpan commandTimeout)
        {
            _host = host ?? throw new ArgumentNullException(nameof(host));
            _capabilities = capabilities ?? throw new ArgumentNullException(nameof(capabilities));
            _commandTimeout = commandTimeout;
        }

        public BrowserstackDriverFactory(TestContext context)
        {
            var desiredCapabilities = new DesiredCapabilities();
            desiredCapabilities.SetCapability("browser", (string)context.Properties["BrowserstackBrowser"]);
            desiredCapabilities.SetCapability("browser_version", (string)context.Properties["BrowserstackBrowserVersion"]);
            desiredCapabilities.SetCapability("os", (string)context.Properties["BrowserstackOperatingSystem"]);
            desiredCapabilities.SetCapability("os_version", (string)context.Properties["BrowserstackOperatingSystemVersion"]);
            desiredCapabilities.SetCapability("resolution", (string)context.Properties["BrowserstackResolution"]);
            desiredCapabilities.SetCapability("browserstack.user", (string)context.Properties["BrowserstackUser"]);
            desiredCapabilities.SetCapability("browserstack.key", (string)context.Properties["BrowserstackKey"]);
            desiredCapabilities.SetCapability("name", "Prototype");
            desiredCapabilities.SetCapability("browserstack.debug", "true");
            desiredCapabilities.SetCapability("browserstack.local", "true");
            _capabilities = desiredCapabilities;

            _host = new Uri((string)context.Properties["BrowserstackHost"]);
            _commandTimeout = TimeSpan.FromSeconds(int.Parse((string)context.Properties["CommandTimeout"]));
        }

        public IWebDriver Create()
        {
            var driver = new RemoteWebDriver(_host, _capabilities, _commandTimeout);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            return driver;
        }
    }
}
