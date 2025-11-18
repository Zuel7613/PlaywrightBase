using PlaywrightBase.Core.Settings;
using ReportPortal.Serilog;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightBase.Core.Logger
{
    public static class Logger
    {
        private static readonly ILogger _logger;

        static Logger()
        {
            var loggerConfiguration = new LoggerConfiguration();
            if (GlobalSettings.LoggingSettings.IsEnabled)
            {
                if (GlobalSettings.LoggingSettings.IsConsoleLoggingEnabled)
                {
                    loggerConfiguration.WriteTo.Console(outputTemplate: GlobalSettings.LoggingSettings.OutputTemplate);
                }

                if (GlobalSettings.LoggingSettings.IsDebugLoggingEnabled)
                {
                    loggerConfiguration.WriteTo.Debug(outputTemplate: GlobalSettings.LoggingSettings.OutputTemplate);
                }

                if (GlobalSettings.LoggingSettings.IsFileLoggingEnabled)
                {
                    loggerConfiguration.WriteTo.File("unicorn-log.txt", rollingInterval: RollingInterval.Day, outputTemplate: GlobalSettings.LoggingSettings.OutputTemplate);
                }

                if (GlobalSettings.LoggingSettings.IsReportPortalLoggingEnabled)
                {
                    loggerConfiguration.WriteTo.ReportPortal();
                }
            }

            _logger = loggerConfiguration.CreateLogger();
        }
    }
}
