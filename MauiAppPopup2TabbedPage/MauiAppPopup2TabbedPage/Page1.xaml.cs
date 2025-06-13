using System;
using CommunityToolkit.Maui.Extensions;

namespace MauiAppPopup2TabbedPage
{
    public partial class Page1
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await this.ShowPopupAsync(new MyPopup());
        }
    }
}
