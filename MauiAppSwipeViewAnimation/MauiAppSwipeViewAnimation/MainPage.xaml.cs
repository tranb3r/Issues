namespace MauiAppSwipeViewAnimation;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        BindingContext = new ViewModel();
    }
}

