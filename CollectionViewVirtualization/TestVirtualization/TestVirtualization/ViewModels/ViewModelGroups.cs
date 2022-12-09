using System.Collections.Generic;
using System.Windows.Input;
using TestVirtualization.Models;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace TestVirtualization.ViewModels
{
    internal class ViewModelGroups : IViewModel
    {
        private const int N = 100;

        public ObservableRangeCollection<object> ItemList { get; }
        public ICommand AddCommand { get; }

        public ViewModelGroups()
        {
            ItemList = new ObservableRangeCollection<object>();
            AddCommand = new Command(Add);
        }

        private void Add()
        {
            var items = new List<object>();
            for (var i = 0; i < N; ++i)
            {
                var item = new Item1Model { new () };
                items.Add(item);
            }
            ItemList.AddRange(items);
        }
    }
}
