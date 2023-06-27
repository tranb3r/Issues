namespace MauiAppKeyboardNumeric;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void Button_OnClicked(object sender, EventArgs e)
    {
        await DisplayPromptAsync("Question", "What's 5 + 5?", initialValue: "10", maxLength: 3, keyboard: Keyboard.Numeric);
    }
}
