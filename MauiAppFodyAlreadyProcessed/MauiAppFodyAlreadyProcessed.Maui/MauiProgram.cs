using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using MauiAppFodyAlreadyProcessed.Lib;

namespace MauiAppFodyAlreadyProcessed.Maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var mauiApp = MauiApp
                .CreateBuilder()
                .UseMauiApp<App>()
                .Build();

            return mauiApp;
        }
    }
}