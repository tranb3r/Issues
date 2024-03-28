using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MauiAppCollectionViewReorder
{
    internal class ItemsViewModel
    {
        public ObservableCollection<Item> ItemsList { get; } =
        [
            new Item("Item 1"),
            new Item("Item 2"),
            new Item("Item 3"),
            new Item("Item 4")
        ];

        public ICommand MoveDownCommand { get; }
        public ICommand MoveUpCommand { get; }

        public ItemsViewModel()
        {
            MoveDownCommand = new Command<Item>(item => Move(item, 1));
            MoveUpCommand = new Command<Item>(item => Move(item, -1));
        }

        private void Move(Item item, int shift)
        {
            var oldIndex = ItemsList.IndexOf(item);
            var newIndex = oldIndex + shift;
            if (newIndex >= 0 && newIndex < ItemsList.Count)
            {
                ItemsList.Move(oldIndex, newIndex);
            }
        }
    }
}
