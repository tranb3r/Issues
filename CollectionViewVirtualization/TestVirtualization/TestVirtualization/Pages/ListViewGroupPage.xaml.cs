using TestVirtualization.ViewModels;
using Xamarin.Forms;

namespace TestVirtualization.Pages
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