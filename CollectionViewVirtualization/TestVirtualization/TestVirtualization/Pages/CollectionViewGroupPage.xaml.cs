using TestVirtualization.ViewModels;
using Xamarin.Forms;

namespace TestVirtualization.Pages
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