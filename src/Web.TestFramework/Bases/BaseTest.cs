using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Web.TestFramework.Factories;

[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.MethodLevel)]
namespace Web.TestFramework.Bases
{
    [TestClass]
    public class BaseTest
    {
        private static IWebDriverFactory _factory;
        private static Uri _baseUrl;
        private static ThreadLocal<WebDriverWrapper> _driver = new ThreadLocal<WebDriverWrapper>(() => new WebDriverWrapper(_factory));

        public IWebDriver Driver => _driver.Value.WrappedDriver;

        public Uri BaseUrl => _baseUrl;

        public TestContext TestContext { get; set; }

        public static void AssemblyInitialize(TestContext context)
        {
            var executableLocation = (string)context.Properties["ExecutableLocation"];
            var webDriverType = (string)context.Properties["WebDriver"];
            var baseUrl = (string)context.Properties["BaseUrl"];
            var commandTimeout = int.Parse((string)context.Properties["CommandTimeout"]);
            var seleniumHost = (string)context.Properties["SeleniumHost"];
            var headless = bool.Parse((string)context.Properties["Headless"]);

            var workingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            switch (webDriverType)
            {
                case "firefox":
                    var firefoxOptions = new FirefoxOptions();
                    firefoxOptions.BrowserExecutableLocation = executableLocation;
                    firefoxOptions.AddArguments(new string[]
                    {
                    });
                    if (headless)
                        firefoxOptions.AddArgument("--headless");
                    _factory = new FirefoxDriverFactory(workingDirectory, firefoxOptions, TimeSpan.FromSeconds(commandTimeout));
                    break;
                case "chrome":
                    var chromeOptions = new ChromeOptions();
                    var args = new List<string>()
                    {
                        "--no-sandbox",
                        "--disable-gpu",
                    };
                    if (headless)
                        args.Add("--headless");
                    chromeOptions.AddArguments(args.ToArray());

                    _factory = new ChromeDriverFactory(workingDirectory, chromeOptions, TimeSpan.FromSeconds(commandTimeout));
                    break;
                default:
                    throw new ArgumentException($"Driver type specified in config ('{webDriverType}') not recognised.");
            }

            _baseUrl = new Uri(baseUrl);
        }

        [TestInitialize]
        public virtual void TestInitialize()
        {
        }

        [TestCleanup]
        public virtual void TestCleanup()
        {
            _driver.Value.DisposeWrapped();
        }

        
        public static void AssemblyCleanup()
        {
            _driver.Dispose();
        }
    }
}
