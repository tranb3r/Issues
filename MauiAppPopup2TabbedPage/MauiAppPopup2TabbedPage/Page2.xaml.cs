using CommunityToolkit.Maui.Extensions;
using System;

namespace MauiAppPopup2TabbedPage
{
    public partial class Page2
    {
        public Page2()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await this.ShowPopupAsync(new MyPopup());
        }
    }
}
