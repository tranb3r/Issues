using System;

namespace TestVirtualization.MauiApp.Pages;

public partial class Page1
{
	public Page1()
	{
		GC.Collect();

		InitializeComponent();

        BindingContext = new ViewModel();
    }
}