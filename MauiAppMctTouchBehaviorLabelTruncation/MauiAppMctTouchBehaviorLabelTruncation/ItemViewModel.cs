using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;

namespace MauiAppMctTouchBehaviorLabelTruncation
{
    internal partial class ItemViewModel
    {
        public string Title { get; }

        public ItemViewModel(string title)
        {
            Title = title;
        }

        [RelayCommand]
        public Task TapAsync()
        {
            return Application.Current.MainPage.DisplayAlert("Tap", Title, "OK");
        }
    }
}
