using Microsoft.Playwright;

namespace PlaywrightBase.Web.Core
{
    public abstract class BasePage(IPage page)
    {
        protected readonly IPage Page = page;
    }
}
