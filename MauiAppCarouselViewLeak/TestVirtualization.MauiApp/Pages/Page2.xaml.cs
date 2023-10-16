using System;

namespace TestVirtualization.MauiApp.Pages;

public partial class Page2
{
    ~Page2() => Console.WriteLine("~Page2");

	public Page2()
	{
		Console.WriteLine("new Page2()");

		GC.Collect();

		InitializeComponent();

        BindingContext = new ViewModel();
    }
}