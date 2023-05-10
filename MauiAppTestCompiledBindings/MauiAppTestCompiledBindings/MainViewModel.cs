using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MauiAppTestCompiledBindings
{
    internal class MainViewModel
    {
        public ICommand ClickCommand { get; }

        public MainViewModel()
        {
            ClickCommand = new Command(() => System.Console.WriteLine("Clicked"));
        }
    }
}
