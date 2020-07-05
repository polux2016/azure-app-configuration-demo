using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;

namespace azure_app_configuration_demo
{
    class Program
    {
        const string ConnectionString = "Endpoint=https://appconfigurationfortest.azconfig.io;Id=3+ar-l0-s0:x+k3i+fPcIP55+86uGn5;Secret=RRTcyLITVEhM1llwoXeCmHwIE8LHNGc7YR5+CddUoos=";
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.AddAzureAppConfiguration(ConnectionString);

            var config = builder.Build();
            Console.WriteLine(config["TestApp:Settings:Message"] ?? "Hello world!");
        }
    }
}
