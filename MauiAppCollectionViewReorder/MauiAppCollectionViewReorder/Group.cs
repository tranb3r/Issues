using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MauiAppCollectionViewReorder
{
    internal class Group<T>(string title, IEnumerable<T> items) : ObservableCollection<T>(items)
    {
        public string Title { get; } = title;
    }
}
