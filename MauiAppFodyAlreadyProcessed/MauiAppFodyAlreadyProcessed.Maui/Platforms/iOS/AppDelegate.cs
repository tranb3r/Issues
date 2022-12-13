using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace MauiAppFodyAlreadyProcessed.Maui.Platforms.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}