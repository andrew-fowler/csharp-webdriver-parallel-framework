using System;
using System.IO;
using System.Reflection;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
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
            var webDriverType = (string)context.Properties["WebDriver"];
            //var seleniumHost = (string)context.Properties["SeleniumHost"];

            switch (webDriverType)
            {
                case "remote":
                    _factory = new BrowserstackDriverFactory(context);
                    break;

                case "firefox":
                    _factory = new FirefoxDriverFactory(context);
                    break;
                case "chrome":
                    _factory = new ChromeDriverFactory(context);
                    break;
                default:
                    throw new ArgumentException($"Driver type specified in config ('{webDriverType}') not recognised.");
            }

            _baseUrl = new Uri((string)context.Properties["BaseUrl"]);
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
