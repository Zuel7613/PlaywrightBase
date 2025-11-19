using PlaywrightBase.Core.Configuration;
using PlaywrightBase.Core.Configuration.Models;

namespace PlaywrightBase.Example.Settings
{
    public static class SettingsServices
    {
        public static string BaseUrl
        {
            get 
            {
                var url = ConfigurationService.GetSection<WebSettings>()?.baseURL;
                ArgumentNullException.ThrowIfNull(url);
                return url;
            } 
        }
        public static string Username
        {
            get
            {
                var username = ConfigurationService.GetSection<WebSettings>()?.username;
                ArgumentNullException.ThrowIfNull(username);
                return username;
            }
        }
        public static string Password
        {
            get
            {
                var password = ConfigurationService.GetSection<WebSettings>()?.password;
                ArgumentNullException.ThrowIfNull(password);
                return password;
            }
        }
    }
}
