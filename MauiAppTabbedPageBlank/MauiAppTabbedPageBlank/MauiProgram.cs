using Maui.FixesAndWorkarounds;

namespace MauiAppTabbedPageBlank;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureMauiWorkarounds(false)
            .ConfigureTabbedPageWorkarounds();

		return builder.Build();
	}
}
