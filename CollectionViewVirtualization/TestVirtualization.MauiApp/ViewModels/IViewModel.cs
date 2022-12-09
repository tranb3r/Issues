using System.Windows.Input;
using MvvmHelpers;

namespace TestVirtualization.MauiApp.ViewModels
{
    public interface IViewModel
    {
        ObservableRangeCollection<object> ItemList { get; }
        ICommand AddCommand { get; }
    }
}
