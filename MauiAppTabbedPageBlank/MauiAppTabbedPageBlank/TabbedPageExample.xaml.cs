using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using TabbedPage = Microsoft.Maui.Controls.TabbedPage;

namespace MauiAppTabbedPageBlank;

public partial class TabbedPageExample : TabbedPage
{
	public TabbedPageExample()
	{
        //On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetIsSmoothScrollEnabled(false);
        //On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetIsSwipePagingEnabled(false);
        //On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetOffscreenPageLimit(5);

        var dashboardNav = new NavigationPage(new MainPage())
        {
            Title = "Page 1",
            IconImageSource = "dotnet_bot.svg"
        };

        var discoverNav = new NavigationPage(new MainPage())
        {
            Title = "Page 2",
            IconImageSource = "dotnet_bot.svg"
        };

        var myDecksNav = new NavigationPage(new MainPage())
        {
            Title = "Page 3",
            IconImageSource = "dotnet_bot.svg"
        };

        var settingsNav = new NavigationPage(new MainPage())
        {
            Title = "Page 4",
            IconImageSource = "dotnet_bot.svg"
        };

        var testPageNav = new NavigationPage(new MainPage())
        {
            Title = "Page 5",
            IconImageSource = "dotnet_bot.svg"
        };

        Children.Add(dashboardNav);
        Children.Add(discoverNav);
        Children.Add(myDecksNav);
        Children.Add(settingsNav);
        Children.Add(testPageNav);

        InitializeComponent();
	}
}