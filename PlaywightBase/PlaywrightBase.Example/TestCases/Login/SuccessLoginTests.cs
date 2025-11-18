using PlaywrightBase.Core.Configuration;
using PlaywrightBase.Core.Configuration.Models;
using PlaywrightBase.Core.Settings;
using PlaywrightBase.Example.PageObjectModel;
using PlaywrightBase.Web.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightBase.Example.TestCases.Login
{
    public class SuccessLoginTests : BaseWebTest
    {

        [Test]
        public async Task BasicLoginTest()
        {
            LoginPage _loginPage = new(Page);
            Console.WriteLine($"Found values url: {url}, Username: {username}, Password: {password}");
            if (string.IsNullOrEmpty(url))
                throw new NullReferenceException();
            await Page.GotoAsync(url);
            await Expect(Page).ToHaveTitleAsync("Swag Labs");
            await _loginPage.Login(username, password);
        }
    }
}
