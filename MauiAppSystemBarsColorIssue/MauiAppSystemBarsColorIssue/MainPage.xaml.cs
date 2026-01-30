using System;
using CommunityToolkit.Maui.Core.Platform;
using CommunityToolkit.Maui.PlatformConfiguration.AndroidSpecific;
using Microsoft.Maui.Graphics;

namespace MauiAppSystemBarsColorIssue
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            StatusBar.SetColor(Colors.LightBlue);
            NavigationBar.SetColor(this, Colors.LightBlue);
        }
    }
}
