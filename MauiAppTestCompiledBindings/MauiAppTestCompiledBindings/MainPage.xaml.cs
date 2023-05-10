namespace MauiAppTestCompiledBindings;

public partial class MainPage
{
	public MainPage()
	{
		InitializeComponent();

        BindingContext = new MainViewModel();
    }
}

