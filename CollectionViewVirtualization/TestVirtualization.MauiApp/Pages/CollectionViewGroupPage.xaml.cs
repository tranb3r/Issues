using Microsoft.Maui.Controls;
using TestVirtualization.MauiApp.ViewModels;

namespace TestVirtualization.MauiApp.Pages
{
    public partial class CollectionViewGroupPage : ContentPage
    {
        public CollectionViewGroupPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            BindingContext = new ViewModelGroups();
        }
    }
}