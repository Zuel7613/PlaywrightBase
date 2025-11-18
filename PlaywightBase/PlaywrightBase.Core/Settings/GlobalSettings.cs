using PlaywrightBase.Core.Secrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
