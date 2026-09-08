namespace MauiAppCv2Overlap;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState activationState) => new Window(new MainPage());
}
