using System.Collections.ObjectModel;
using Java.Lang;

namespace MauiAppMctTouchBehaviorLabelTruncation
{
    internal class PageViewModel
    {
        public ObservableCollection<ItemViewModel> Items { get; }

        public PageViewModel()
        {
            Items = [];
            for (var i = 0; i < 17; ++i)
            {
                var j = Math.Pow(10, i);
                Items.Add(new ItemViewModel($"Item {j}"));
            }
        }
    }
}
