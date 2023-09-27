using Microsoft.Maui.Controls.Hosting;

namespace TestVirtualization.MauiApp
{
    public static class MauiProgram
    {
        public static Microsoft.Maui.Hosting.MauiApp CreateMauiApp()
        {
            var builder = Microsoft.Maui.Hosting.MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>();

            return builder.Build();
        }
    }
}