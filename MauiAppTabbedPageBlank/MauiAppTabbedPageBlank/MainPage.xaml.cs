namespace MauiAppTabbedPageBlank;

public partial class MainPage : ContentPage
{
    private readonly TabbedPageExample _tabbedPage;

	public MainPage(TabbedPageExample tabbedPage)
	{
		InitializeComponent();

        _tabbedPage = tabbedPage;
	}

    private void ButtonPushPage_OnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Page2());
    }

    private void ButtonAddTab_OnClicked(object sender, EventArgs e)
    {
        _tabbedPage.AddTab();
    }
}