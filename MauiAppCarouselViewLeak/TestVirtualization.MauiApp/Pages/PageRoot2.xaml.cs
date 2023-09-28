using System;

namespace TestVirtualization.MauiApp.Pages;

public partial class PageRoot2
{
	public PageRoot2()
	{
		InitializeComponent();
	}

    private void Button_OnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Page2());
    }
}