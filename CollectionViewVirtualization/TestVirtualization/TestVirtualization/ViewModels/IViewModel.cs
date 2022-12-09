using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;

namespace TestVirtualization.ViewModels
{
    public interface IViewModel
    {
        ObservableRangeCollection<object> ItemList { get; }
        ICommand AddCommand { get; }
    }
}
