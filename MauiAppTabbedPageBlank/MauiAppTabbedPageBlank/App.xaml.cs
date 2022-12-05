namespace MauiAppTabbedPageBlank;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new TabbedPageExample();
	}
}
