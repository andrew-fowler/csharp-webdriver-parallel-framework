using System;
using System.Net;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
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
            if ((string) TestContext.Properties["WebDriver"] == "remote")
            {
                if (TestContext.CurrentTestOutcome != UnitTestOutcome.Passed)
                {
                    var reqString = "{\"status\":\"failed\", \"reason\":\"\"}";

                    var requestData = Encoding.UTF8.GetBytes(reqString);
                    var myUri = new Uri(
                        $"https://www.browserstack.com/automate/sessions/{ ((RemoteWebDriver)Driver).SessionId.ToString()}.json");
                    var myWebRequest = WebRequest.Create(myUri);
                    var myHttpWebRequest = (HttpWebRequest) myWebRequest;
                    myWebRequest.ContentType = "application/json";
                    myWebRequest.Method = "PUT";
                    myWebRequest.ContentLength = requestData.Length;
                    using (var st = myWebRequest.GetRequestStream()) st.Write(requestData, 0, requestData.Length);

                    var myNetworkCredential = new NetworkCredential((string)TestContext.Properties["BrowserstackBrowser"], (string)TestContext.Properties["BrowserstackKey"]);
                    var myCredentialCache = new CredentialCache {{myUri, "Basic", myNetworkCredential}};
                    myHttpWebRequest.PreAuthenticate = true;
                    myHttpWebRequest.Credentials = myCredentialCache;

                    myWebRequest.GetResponse().Close();
                }
            }

            _driver.Value.DisposeWrapped();
        }

        
        public static void AssemblyCleanup()
        {
            _driver.Dispose();
        }
    }
}
