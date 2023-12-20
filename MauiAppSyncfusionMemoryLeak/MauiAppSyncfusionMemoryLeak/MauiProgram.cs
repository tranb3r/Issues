using Syncfusion.Maui.Core.Hosting;

namespace MauiAppSyncfusionMemoryLeak
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .ConfigureSyncfusionCore()
                .UseMauiApp<App>();

            return builder.Build();
        }
    }
}
