using Microsoft.Maui.Controls;

namespace MauiAppCollectionViewReorder
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();

            BindingContext = new ItemsGroupedViewModel();
        }
    }
}
