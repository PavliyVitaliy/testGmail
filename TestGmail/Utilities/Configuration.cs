using Microsoft.Extensions.Configuration;
using System;

namespace TestGmail.Utilities
{
    /// <summary>
    /// All application configuration parameters.
    /// </summary>
    public class Configuration
    {
        public static Configuration Instance => new Configuration();

        private IConfigurationRoot Config => new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        private Configuration() { }

        public Uri Url => new Uri(this.Config["URL"]);
        public string Email => this.Config["email"];
        public string Password => this.Config["password"];

    }
}
