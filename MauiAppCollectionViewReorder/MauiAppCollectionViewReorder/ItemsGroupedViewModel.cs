using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MauiAppCollectionViewReorder
{
    internal class ItemsGroupedViewModel
    {
        public ObservableCollection<Group<Item>> ItemsList { get; } =
        [
            new Group<Item>("Group 1",
            [
                new Item("Item 1")
            ]),
            new Group<Item>("Group 2",
            [
                new Item("Item 2"),
                new Item("Item 3"),
                new Item("Item 4"),
                new Item("Item 5")
            ]),
            new Group<Item>("Group 3",
            [
                new Item("Item 6"),
                new Item("Item 7")
            ])
        ];

        public ICommand MoveItemDownCommand { get; }
        public ICommand MoveItemUpCommand { get; }

        public ICommand MoveGroupDownCommand { get; }
        public ICommand MoveGroupUpCommand { get; }

        public ItemsGroupedViewModel()
        {
            MoveItemDownCommand = new Command<Item>(item => MoveItem(item, 1));
            MoveItemUpCommand = new Command<Item>(item => MoveItem(item, -1));

            MoveGroupDownCommand = new Command<Group<Item>>(group => MoveGroup(group, 1));
            MoveGroupUpCommand = new Command<Group<Item>>(group => MoveGroup(group, -1));
        }

        private void MoveItem(Item item, int shift)
        {
            foreach (var group in ItemsList)
            {
                var oldIndex = group.IndexOf(item);
                if (oldIndex == -1)
                {
                    continue;
                }
                var newIndex = oldIndex + shift;
                if (newIndex >= 0 && newIndex < group.Count)
                {
                    group.Move(oldIndex, newIndex);
                }
                break;
            }
        }

        private void MoveGroup(Group<Item> group, int shift)
        {
            var oldIndex = ItemsList.IndexOf(group);
            var newIndex = oldIndex + shift;
            if (newIndex >= 0 && newIndex < ItemsList.Count)
            {
                ItemsList.Move(oldIndex, newIndex);
            }
        }
    }
}
