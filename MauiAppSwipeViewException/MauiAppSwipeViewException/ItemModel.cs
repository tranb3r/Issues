using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace MauiAppSwipeViewException
{
    public partial class ItemModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ItemModel(int i)
        {
            Id = i;
            Title = "Hello";
        }

        [RelayCommand]
        private void Swipe()
        {
            WeakReferenceMessenger.Default.Send(new RemoveMessage(this));
        }
    }
}
