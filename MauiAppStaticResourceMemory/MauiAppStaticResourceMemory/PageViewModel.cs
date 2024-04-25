using System.Collections.ObjectModel;

namespace MauiAppStaticResourceMemory
{
    internal class PageViewModel
    {
        public ObservableCollection<ItemViewModel> Items { get; }

        public PageViewModel()
        {
            Items = [];
            for (var i = 0; i < 50; ++i)
            {
                Items.Add(new ItemViewModel($"Item {i}"));
            }
        }
    }
}
