using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GoogleAdsMCP
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = Host.CreateApplicationBuilder(args);
            var token = builder.Configuration["token"];

            if (string.IsNullOrWhiteSpace(token))
            {
                throw new InvalidOperationException("--token is required");
            }

            builder.Services.AddMcpServer()
                .WithStdioServerTransport()
                .WithToolsFromAssembly();

            builder.Logging.AddConsole(options =>
            {
                options.LogToStandardErrorThreshold = LogLevel.Trace;
            });

            builder.Services.AddSingleton<ILogger>(sp =>
                sp.GetRequiredService<ILoggerFactory>().CreateLogger("GoogleAdsMCP")
            );

            builder.Services.AddSingleton(new GaqlApiClient(token));

            await builder
                .Build()
                .RunAsync();
        }
    }
}