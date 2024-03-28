using Microsoft.Maui.Controls;

namespace MauiAppCollectionViewReorder
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            BindingContext = new ItemsViewModel();
        }
    }
}
