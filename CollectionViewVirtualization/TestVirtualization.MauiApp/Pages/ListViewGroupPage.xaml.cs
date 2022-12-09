using Microsoft.Maui.Controls;
using TestVirtualization.MauiApp.ViewModels;

namespace TestVirtualization.MauiApp.Pages
{
    public partial class ListViewGroupPage : ContentPage
    {
        public ListViewGroupPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            BindingContext = new ViewModelGroups();
        }
    }
}