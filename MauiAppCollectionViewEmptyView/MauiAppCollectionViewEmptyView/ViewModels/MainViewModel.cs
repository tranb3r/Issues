using System.Collections.ObjectModel;
using System.Windows.Input;
using MauiAppCollectionViewEmptyView.Models;
using Microsoft.Maui.Controls;

namespace MauiAppCollectionViewEmptyView.ViewModels
{
    public class MainViewModel
    {
        private readonly Command _removeGroupCommand;
        private readonly Command<ItemGroup> _removeItemCommand;

        public ObservableCollection<ItemGroup> Groups { get; }

        public ICommand AddGroupCommand { get; }
        public ICommand RemoveGroupCommand => _removeGroupCommand;
        public ICommand AddItemCommand { get; }
        public ICommand RemoveItemCommand => _removeItemCommand;

        private int _groupCounter;
        private int _itemCounter;

        public MainViewModel()
        {
            Groups = new ObservableCollection<ItemGroup>();

            _groupCounter = 0;
            _itemCounter = 0;

            AddGroupCommand = new Command(AddGroup);
            AddItemCommand = new Command<ItemGroup>(AddItem);
            _removeGroupCommand = new Command(RemoveGroup, () => Groups.Count > 0);
            _removeItemCommand = new Command<ItemGroup>(RemoveItem, CanRemoveItem);

            Groups.CollectionChanged += (_, _) => _removeGroupCommand.ChangeCanExecute();
        }

        private void AddGroup()
        {
            _groupCounter++;
            _itemCounter++;
            Groups.Add(new ItemGroup($"Group {_groupCounter}", new[] { $"Item {_itemCounter}" }));
            _removeItemCommand.ChangeCanExecute();
        }

        private void RemoveGroup()
        {
            if (Groups.Count == 0)
            {
                return;
            }

            Groups.RemoveAt(Groups.Count - 1);
        }

        private void AddItem(ItemGroup group)
        {
            if (group is null)
            {
                return;
            }

            _itemCounter++;
            group.Add($"Item {_itemCounter}");
            _removeItemCommand.ChangeCanExecute();
        }

        private void RemoveItem(ItemGroup group)
        {
            if (group is null || group.Count == 0)
            {
                return;
            }

            group.RemoveAt(group.Count - 1);
            _removeItemCommand.ChangeCanExecute();
        }

        private bool CanRemoveItem(ItemGroup group)
            => group is not null && group.Count > 0;
    }
}
