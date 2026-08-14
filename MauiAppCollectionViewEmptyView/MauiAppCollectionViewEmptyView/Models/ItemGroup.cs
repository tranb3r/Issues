using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace MauiAppCollectionViewEmptyView.Models
{
    public class ItemGroup : ObservableCollection<string>
    {
        public string Title { get; }

        public string? FooterText => Count == 0 ? "This group is empty." : null;

        public ItemGroup(string title, IEnumerable<string> items) : base(items)
        {
            Title = title;
        }

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            base.OnCollectionChanged(e);
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(FooterText)));
        }
    }
}
