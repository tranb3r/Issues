using System.Reflection;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ClassLibrary2
{
    public partial class MyViewModel : ObservableObject, IMyViewModel
    {
        [ObservableProperty]
//        [property: Obfuscation(Feature = "renaming", Exclude = true)]
        private int _count;

        [RelayCommand]
        private void Click()
        {
            Count++;
        }
    }
}
