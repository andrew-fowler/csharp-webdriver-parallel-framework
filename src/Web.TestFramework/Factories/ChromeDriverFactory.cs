using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Web.TestFramework.Factories
{
    public class ChromeDriverFactory : IWebDriverFactory
    {
        private readonly string _driverDirectory;
        private readonly ChromeOptions _options;
        private readonly TimeSpan _commandTimeout;

        public ChromeDriverFactory(string driverDirectory, ChromeOptions options, TimeSpan commandTimeout)
        {
            _driverDirectory = driverDirectory ?? throw new ArgumentNullException(nameof(driverDirectory));
            _options = options ?? throw new ArgumentNullException(nameof(options));
            _commandTimeout = commandTimeout;
        }

        public IWebDriver Create()
        {
            return new ChromeDriver(_driverDirectory, _options, _commandTimeout);
        }
    }
}
