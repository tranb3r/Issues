namespace MauiAppCv2Overlap;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>();

		// iOS: CollectionViewHandler2 (CV2) is the default since .NET 10 and reproduces the bug.
		// To compare with the legacy CV1 handler (where the bug disappears), uncomment the line below.
		//builder.ConfigureMauiHandlers(h => h.AddHandler<Microsoft.Maui.Controls.CollectionView, Microsoft.Maui.Controls.Handlers.Items.CollectionViewHandler>());

		return builder.Build();
	}
}
