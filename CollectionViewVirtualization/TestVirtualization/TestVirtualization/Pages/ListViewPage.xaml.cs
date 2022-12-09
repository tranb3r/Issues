using TestVirtualization.ViewModels;
using Xamarin.Forms;

namespace TestVirtualization.Pages
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