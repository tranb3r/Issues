using MauiGestures;

namespace MauiAppSwipeViewAnimation;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .AddAdvancedGestures();

		return builder.Build();
	}
}
