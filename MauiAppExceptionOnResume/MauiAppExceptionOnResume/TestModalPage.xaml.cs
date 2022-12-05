namespace MauiAppExceptionOnResume;

public partial class TestModalPage : ContentPage
{
	public TestModalPage()
	{
		InitializeComponent();
	}

    private void Button_OnClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PopModalAsync();
    }
}