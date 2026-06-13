using PlaywrightBase.Example.PageObjectModel;
using PlaywrightBase.Web.Settings;
using PlaywrightBase.Web.Core;

namespace PlaywrightBase.Example.TestCases.Login
{
    public class SuccessLoginTests : BaseWebTest
    {

        [SetUp]
        public void Setup()
        {
        }
        

        [Test]
        public async Task BasicLoginTest()
        {
            LoginPage _loginPage = new(Page);
            Console.WriteLine($"Found values url: {SettingsServices.BaseUrl}, Username: {SettingsServices.Username}, Password: {SettingsServices.Password}");
            await Page.GotoAsync(SettingsServices.BaseUrl);
            await Expect(Page).ToHaveTitleAsync("Swag Labs");
            await _loginPage.Login(SettingsServices.Username, SettingsServices.Password);
            await Expect(Page).ToHaveURLAsync("https://www.saucedemo.com/inventory.html");
        }
    }
}
