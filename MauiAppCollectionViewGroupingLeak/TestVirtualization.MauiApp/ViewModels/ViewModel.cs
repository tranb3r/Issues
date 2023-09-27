using System.Collections.Generic;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using MvvmHelpers;
using TestVirtualization.MauiApp.Models;

namespace TestVirtualization.MauiApp.ViewModels
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
