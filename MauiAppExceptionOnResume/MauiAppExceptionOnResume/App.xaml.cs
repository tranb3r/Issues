namespace MauiAppExceptionOnResume;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new MainPage();
    }

    protected override void OnResume()
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new TestModalPage()).FireAndForget();
    }
}
