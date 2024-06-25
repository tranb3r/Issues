using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using Sentry;

namespace MauiAppSegfault
{
    public static class MauiProgram
    {
        private const string Dsn = "INSERT YOUR DSN";

        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>();

            SentrySdk.Init(Dsn);

            return builder.Build();
        }
    }
}
