using CommunityToolkit.Mvvm.ComponentModel;

namespace ClassLibrary1
{
    public partial class MyViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title;
    }
}
