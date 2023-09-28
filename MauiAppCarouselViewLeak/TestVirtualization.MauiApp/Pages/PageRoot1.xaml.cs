using System;

namespace TestVirtualization.MauiApp.Pages;

public partial class PageRoot1
{
	public PageRoot1()
	{
		InitializeComponent();
	}

    private void Button_OnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Page1());
    }
}