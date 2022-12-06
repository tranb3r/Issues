using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiAppCollectionViewHeaderOrEmpty
{
    internal class ViewModel
    {
        private List<string> _cities = new()
        {
            "Paris",
            "New York",
            "Tokyo",
            "Berlin",
            "Madrid",
            "London"
        };
        private Random _random = new ();

        public ObservableCollection<string> ItemList { get; set; }

        public ICommand AddCommand => new Command(Add);
        public ICommand RemoveCommand => new Command(Remove);

        public ViewModel()
        {
            ItemList = new ObservableCollection<string>();
        }

        private void Add()
        {
            var city = _cities[_random.Next(_cities.Count)];
            ItemList.Add(city);
        }

        private void Remove()
        {
            ItemList.RemoveAt(ItemList.Count - 1);
        }
    }
}
