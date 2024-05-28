using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;

namespace ConsoleAppSentryTag
{
    internal class Program
    {
        private const string Dsn = "INSERT YOUR DSN";

        static void Main()
        {
            Console.WriteLine("Default logger");
            TestLogger(CreateDefaultLogger());

            Console.WriteLine();

            Console.WriteLine("Serilog logger");
            TestLogger(CreateSerilogLogger());
        }

        static ILogger<Program> CreateDefaultLogger()
        {
            using var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
                builder.AddSentry(o => o.Dsn = Dsn);
            });
            var logger = loggerFactory.CreateLogger<Program>();
            return logger;
        }

        static ILogger<Program> CreateSerilogLogger()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.Console()
                .CreateLogger();
            var serviceProvider = new ServiceCollection()
                .AddLogging(builder =>
                {
                    builder.AddSerilog();
                    builder.AddSentry(o => o.Dsn = Dsn);
                })
                .BuildServiceProvider();
            var logger = serviceProvider.GetRequiredService<ILogger<Program>>();
            return logger;
        }

        static void TestLogger(ILogger<Program> logger)
        {
            logger.LogError("Test {Company.Foo}", 42);
        }
    }
}
