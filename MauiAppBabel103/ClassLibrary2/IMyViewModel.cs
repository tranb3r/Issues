using CommunityToolkit.Mvvm.Input;

namespace ClassLibrary2
{
    public interface IMyViewModel
    {
        public int Count { get; }

        public IRelayCommand ClickCommand { get; }
    }
}
