using Microsoft.Maui.Controls;
using TestVirtualization.MauiApp.ViewModels;

namespace TestVirtualization.MauiApp.Pages
{
    public partial class CollectionViewPage : ContentPage
    {
        public CollectionViewPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            BindingContext = new ViewModel();
        }
    }
}