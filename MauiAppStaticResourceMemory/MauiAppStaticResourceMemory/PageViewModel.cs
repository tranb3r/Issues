using System.Collections.ObjectModel;

namespace MauiAppStaticResourceMemory
{
    internal class PageViewModel
    {
        public ObservableCollection<string> Items { get; }

        public PageViewModel()
        {
            Items = [];
            for (var i = 0; i < 200; ++i)
            {
                Items.Add($"Item {i}");
            }
        }
    }
}
