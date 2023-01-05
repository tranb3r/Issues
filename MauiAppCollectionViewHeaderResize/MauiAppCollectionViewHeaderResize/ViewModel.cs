using System.Collections.ObjectModel;

namespace MauiAppCollectionViewHeaderResize
{
    internal class ViewModel
    {
        public ObservableCollection<string> ItemListHeader { get; set; }
        public ObservableCollection<string> ItemList { get; set; }

        public Command AddCommand => new (Add);

        public ViewModel()
        {
            ItemListHeader = new ObservableCollection<string>
            {
                "Paris",
                "London"
            };
            ItemList = new ObservableCollection<string>
            {
                "Red",
                "Blue",
                "Green"
            };
        }

        private void Add()
        {
            ItemListHeader.Add("Madrid");
        }
    }
}
