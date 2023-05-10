using MauiGestures;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace MauiAppTestCompiledBindings;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
            .AddAdvancedGestures()
            .UseMauiApp<App>();

		return builder.Build();
	}
}
