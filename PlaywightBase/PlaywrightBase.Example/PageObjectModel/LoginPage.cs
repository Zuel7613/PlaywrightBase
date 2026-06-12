using Microsoft.Playwright;
using PlaywrightBase.Web.Settings;
using PlaywrightBase.Web.Core;

namespace PlaywrightBase.Example.PageObjectModel
{
    public class LoginPage(IPage page) : BasePage(page)
    {
        private ILocator _username => Page.GetByPlaceholder("Username");
        private ILocator _password => Page.GetByPlaceholder("Password");
        private ILocator _loginButton => Page.GetByText("Login");

        public async Task GotoAsync()
        {
            var url = SettingsServices.BaseUrl;
            await Page.GotoAsync(url);
        }
        public async Task Login(string username, string password)
        {
            await _username.FillAsync(username);
            await _password.FillAsync(password);
            await _loginButton.ClickAsync();
        }
    }
}
