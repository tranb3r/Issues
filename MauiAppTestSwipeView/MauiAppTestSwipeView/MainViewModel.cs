using System.Windows.Input;

namespace MauiAppTestSwipeView
{
    internal class MainViewModel
    {
        public ICommand ExecuteCommand { get; }

        public MainViewModel()
        {
            ExecuteCommand = new Command(() => Console.WriteLine("----- Swiped ----"));
        }
    }
}
