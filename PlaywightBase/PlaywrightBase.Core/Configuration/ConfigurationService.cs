using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace PlaywrightBase.Core.Configuration
{
    public class ConfigurationService
    {
        private static readonly Lazy<IConfigurationRoot> Root = new(() => InitializeConfiguration(), isThreadSafe: true);

        // Once the IConfigurationRoot is initialized, access to the configuration is fast, without additional locking overhead.
        public static TSection? GetSection<TSection>()
            where TSection : class, new()
        {
            string sectionName = typeof(TSection).Name;
            return Root.Value.GetSection(sectionName).Get<TSection>(); // Access the configuration safely through Lazy.Value
        }

        // Configuration initialization will only happen when it is accessed for the first time, potentially improving performance if the configuration is not always needed.
        private static IConfigurationRoot InitializeConfiguration()
        {
            var settingsFileName = "appsettings.json";
            string? executionDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var settingsFilePath = Path.Combine(executionDir ?? throw new Exception(), settingsFileName);

            var builder = new ConfigurationBuilder();
            if (File.Exists(settingsFilePath))
            {
                builder.AddJsonFile(settingsFilePath, optional: true, reloadOnChange: true);
            }
            else
            {
                throw new FileNotFoundException($"Configuration file '{settingsFileName}' not found in '{executionDir}'.");
            }

            return builder.Build();
        }
    }
}
