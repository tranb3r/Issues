using System;

namespace TestVirtualization.MauiApp.Pages;

public partial class Page1
{
    ~Page1() => Console.WriteLine("~Page1");

    public Page1()
	{
        Console.WriteLine("new Page1()");

        GC.Collect();

		InitializeComponent();

        BindingContext = new ViewModel();
    }
}