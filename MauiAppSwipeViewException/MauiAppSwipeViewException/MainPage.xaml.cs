using Microsoft.Maui.Controls;

namespace MauiAppSwipeViewException
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new ViewModel();
        }
    }
}
