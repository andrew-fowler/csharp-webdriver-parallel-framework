using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace Web.TestFramework
{
    [TestClass]
    public class WebTest
    {
        private static IWebDriverFactory factory;
        private static Uri baseUrl;
        private static ThreadLocal<WebDriverWrapper> driver = new ThreadLocal<WebDriverWrapper>(() => new WebDriverWrapper(factory));

        public IWebDriver Driver
        {
            get
            {
                return driver.Value.WrappedDriver;
            }
        }

        public Uri BaseUrl
        {
            get
            {
                return baseUrl;
            }
        }

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
                    WebTest.factory = new FirefoxDriverFactory(workingDirectory, firefoxOptions, TimeSpan.FromSeconds(commandTimeout));
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

                    WebTest.factory = new ChromeDriverFactory(workingDirectory, chromeOptions, TimeSpan.FromSeconds(commandTimeout));
                    break;
                default:
                    throw new ArgumentException($"Driver type specified in config ('{webDriverType}') not recognised.");
            }

            WebTest.baseUrl = new Uri(baseUrl);
        }

        [TestInitialize]
        public virtual void TestInitialize()
        {
        }

        [TestCleanup]
        public virtual void TestCleanup()
        {
            driver.Value.DisposeWrapped();
        }

        
        public static void AssemblyCleanup()
        {
            driver.Dispose();
        }
    }
}
