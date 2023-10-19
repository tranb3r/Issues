using ClassLibrary2;
using Microsoft.Maui.Controls;

namespace ClassLibrary1
{
    public partial class MainPage : ContentPage
    {
        public MainPage(IMyViewModel myViewModel)
        {
            InitializeComponent();

            BindingContext = myViewModel;
        }
    }
}
