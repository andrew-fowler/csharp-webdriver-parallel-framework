using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        public ChromeDriverFactory(TestContext context)
        {
            _options = new ChromeOptions();
            var args = new List<string>()
            {
                "--no-sandbox",
                "--disable-gpu",
            };
            if (bool.Parse((string)context.Properties["Headless"]))
                args.Add("--headless");
            _options.AddArguments(args.ToArray());
            _driverDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            _commandTimeout = TimeSpan.FromSeconds(int.Parse((string)context.Properties["CommandTimeout"]));
        }

        public IWebDriver Create()
        {
            return new ChromeDriver(_driverDirectory, _options, _commandTimeout);
        }
    }
}
