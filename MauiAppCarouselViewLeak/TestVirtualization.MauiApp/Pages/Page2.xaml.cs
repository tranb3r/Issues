using System;

namespace TestVirtualization.MauiApp.Pages;

public partial class Page2
{
	public Page2()
	{
		GC.Collect();

		InitializeComponent();

        BindingContext = new ViewModel();
    }
}