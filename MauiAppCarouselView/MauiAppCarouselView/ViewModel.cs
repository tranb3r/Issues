using System.Collections.ObjectModel;

namespace MauiAppCarouselView
{
    internal class ViewModel
    {
        public ObservableCollection<string> ItemList { get; set; }

        public ViewModel()
        {
            ItemList = new ObservableCollection<string>
            {
                "Paris",
                //"London"
            };
        }
    }
}
