using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Web.TestFramework.Factories
{
    public class RemoteDriverFactory : IWebDriverFactory
    {
        private readonly Uri _host;
        private readonly ICapabilities _capabilities;
        private readonly TimeSpan _commandTimeout;

        public RemoteDriverFactory(Uri host, ICapabilities capabilities, TimeSpan commandTimeout)
        {
            _host = host ?? throw new ArgumentNullException(nameof(host));
            _capabilities = capabilities ?? throw new ArgumentNullException(nameof(capabilities));
            _commandTimeout = commandTimeout;
        }

        public IWebDriver Create()
        {
            return new RemoteWebDriver(_host, _capabilities, _commandTimeout);
        }
    }
}
