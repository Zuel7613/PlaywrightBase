using PlaywrightBase.Core.Secrets;

namespace PlaywrightBase.Core.Settings
{
    public class GlobalSettings
    {
        static GlobalSettings()
        {
            LoggingSettings = new LoggingSettings();
            SecretsSettings = new SecretsSettings();
        }

        public static LoggingSettings LoggingSettings { get; set; }
        public static SecretsSettings SecretsSettings { get; set; }
    }
}
