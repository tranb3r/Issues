using ClassLibrary2;
using Microsoft.Maui.Controls;

namespace ClassLibrary1
{
    public partial class App : Application
    {
        public App(IMyViewModel myViewModel)
        {
            InitializeComponent();

            MainPage = new MainPage(myViewModel);
        }
    }
}
