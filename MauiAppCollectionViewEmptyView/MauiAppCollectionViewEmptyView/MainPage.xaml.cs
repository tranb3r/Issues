using MauiAppCollectionViewEmptyView.ViewModels;

namespace MauiAppCollectionViewEmptyView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
