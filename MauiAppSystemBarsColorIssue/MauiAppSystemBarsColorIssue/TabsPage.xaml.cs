using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace MauiAppSystemBarsColorIssue;

public partial class TabsPage
{
	public TabsPage()
	{
		InitializeComponent();

		Children.Add(new NavigationPage(new MainPage())
        {
            BarBackgroundColor = Colors.LightBlue,
            BarTextColor = Colors.DarkBlue
        });
	}
}