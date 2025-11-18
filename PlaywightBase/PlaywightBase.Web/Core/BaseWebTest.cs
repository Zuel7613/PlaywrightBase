using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using PlaywrightBase.Core.Configuration;
using PlaywrightBase.Core.Configuration.Models;
using PlaywrightBase.Core.Infastructure;

namespace PlaywrightBase.Web.Core
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class BaseWebTest : PageTest
    {
        protected string? url;
        protected string? username;
        protected string? password;

        [OneTimeSetUp]
        public void OneTimeWebSetUp()
        {
            url = ConfigurationService.GetSection<WebSettings>()?.baseURL;
            username = ConfigurationService.GetSection<WebSettings>()?.username;
            password = ConfigurationService.GetSection<WebSettings>()?.password;
        }
    }
}
