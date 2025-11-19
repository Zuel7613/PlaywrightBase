using PlaywrightBase.Example.PageObjectModel;
using PlaywrightBase.Example.Settings;
using PlaywrightBase.Web.Core;

namespace PlaywrightBase.Example.TestCases
{
    public class ExampleBaseTest : BaseWebTest
    {
        protected LoginPage loginPage;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            loginPage = new(Page);
            await loginPage.Login(SettingsServices.Username, SettingsServices.Password);
        }
    }
}
