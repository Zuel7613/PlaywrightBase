using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightBase.Web.Core
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class BaseWebTest : PageTest
    {
    }
}
