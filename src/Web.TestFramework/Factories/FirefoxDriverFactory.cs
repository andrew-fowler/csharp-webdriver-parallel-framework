using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        public FirefoxDriverFactory(TestContext context)
        {
            _options = new FirefoxOptions();
            _options.BrowserExecutableLocation = (string)context.Properties["ExecutableLocation"];
            _options.AddArguments(new string[]{});

            if (bool.Parse((string)context.Properties["Headless"]))
                _options.AddArgument("--headless");

            _driverDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            _commandTimeout = TimeSpan.FromSeconds(int.Parse((string)context.Properties["CommandTimeout"]));
        }

        public IWebDriver Create()
        {
            return new FirefoxDriver(_driverDirectory, _options, _commandTimeout);
        }
    }
}
