using Syncfusion.Maui.Core.Hosting;

namespace MauiAppSfTextInputLayout;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		return MauiApp.CreateBuilder()
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore()
            .Build();
	}
}
