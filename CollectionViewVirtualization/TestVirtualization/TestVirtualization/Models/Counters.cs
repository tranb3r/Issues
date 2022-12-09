using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestVirtualization.Models
{
    internal class Counters : INotifyPropertyChanged
    {
        public static Counters Instance { get; } = new ();

        private Counters() { }

        private int _view1Count;
        public int View1Count
        {
            get => _view1Count;
            set
            {
                _view1Count = value;
                NotifyPropertyChanged();
            }
        }

        private int _view2Count;
        public int View2Count
        {
            get => _view2Count;
            set
            {
                _view2Count = value;
                NotifyPropertyChanged();
            }
        }

        public void Reset()
        {
            View1Count = 0;
            View2Count = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
