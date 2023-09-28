using Microsoft.Maui.Controls;
using TestVirtualization.MauiApp.Pages;

namespace TestVirtualization.MauiApp
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            Children.Add(new NavigationPage(new PageRoot1()) { Title = "Page1" });
            Children.Add(new NavigationPage(new PageRoot2()) { Title = "Page2" });
        }
    }
}