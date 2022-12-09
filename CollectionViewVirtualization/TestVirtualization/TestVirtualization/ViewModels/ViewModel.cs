using System.Collections.Generic;
using System.Windows.Input;
using TestVirtualization.Models;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace TestVirtualization.ViewModels
{
    internal class ViewModel : IViewModel
    {
        private const int N = 100;

        public ObservableRangeCollection<object> ItemList { get; }
        public ICommand AddCommand { get; }

        public ViewModel()
        {
            ItemList = new ObservableRangeCollection<object>();
            AddCommand = new Command(Add);
        }

        private void Add()
        {
            var items = new List<object>();
            for (var i = 0; i < N; ++i)
            {
                items.Add(new Item1Model());
                items.Add(new Item2Model());
            }
            ItemList.AddRange(items);
        }
    }
}
