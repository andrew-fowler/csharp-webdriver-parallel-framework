using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Web.TestFramework.Factories
{
    public class FirefoxDriverFactory : IWebDriverFactory
    {
        private readonly string _driverDirectory;
        private readonly FirefoxOptions _options;
        private readonly TimeSpan _commandTimeout;

        public FirefoxDriverFactory(string driverDirectory, FirefoxOptions options, TimeSpan commandTimeout)
        {
            _driverDirectory = driverDirectory ?? throw new ArgumentNullException(nameof(driverDirectory));
            _options = options ?? throw new ArgumentNullException(nameof(options));
            _commandTimeout = commandTimeout;
        }

        public IWebDriver Create()
        {
            return new FirefoxDriver(_driverDirectory, _options, _commandTimeout);
        }
    }
}
