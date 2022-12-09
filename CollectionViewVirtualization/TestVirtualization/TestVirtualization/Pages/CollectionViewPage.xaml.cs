using TestVirtualization.ViewModels;
using Xamarin.Forms;

namespace TestVirtualization.Pages
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