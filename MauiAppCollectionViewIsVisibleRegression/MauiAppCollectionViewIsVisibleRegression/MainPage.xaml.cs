using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace MauiAppCollectionViewIsVisibleRegression
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            CollectionViewRef.ItemsSource = new ObservableCollection<string>(Enumerable.Range(0, 1000).Select(i => $"Item {i}"));
            await Task.Delay(10000);
            CollectionViewRef.IsVisible = true;
        }
    }
}
