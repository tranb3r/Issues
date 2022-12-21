using ClassLibrary1;

namespace MauiAppLocalNotificationLib;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
    {
        return MauiApp.CreateBuilder()
            .UseMauiApp<App>()
            .ConfigurePlugins()
            .Build();
    }
}
