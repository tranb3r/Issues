using System.Windows.Input;

namespace MauiAppSwipeViewAnimation
{
    internal class ViewModel
    {
        public ICommand LongPressCommand => new Command(LongPress);

        public void LongPress()
        {
            Console.WriteLine("Long press");
        }
    }
}
