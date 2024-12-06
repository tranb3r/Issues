using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.ObjectModel;

namespace MauiAppSwipeViewException
{
    public class ViewModel
    {
        public ObservableCollection<ItemModel> ItemList { get; set; }

        public ViewModel()
        {
            WeakReferenceMessenger.Default.Register<RemoveMessage>(this, (_, message) => RemoveItem(message.Item));

            ItemList = [];
            for (var i = 0; i < 200; ++i)
            {
                ItemList.Add(new ItemModel(i));
            }
        }

        private void RemoveItem(ItemModel item)
        {
            ItemList.Remove(item);
            GC.Collect();
        }
    }
}
