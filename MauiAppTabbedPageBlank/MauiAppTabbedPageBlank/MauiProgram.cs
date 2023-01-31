using ShanedlerSamples;

namespace MauiAppTabbedPageBlank;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .ConfigureTabbedPageWorkarounds();

		return builder.Build();
	}
}
