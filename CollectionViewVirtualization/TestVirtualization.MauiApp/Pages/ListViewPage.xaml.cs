using Microsoft.Maui.Controls;
using TestVirtualization.MauiApp.ViewModels;

namespace TestVirtualization.MauiApp.Pages
{
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            BindingContext = new ViewModel();
        }
    }
}