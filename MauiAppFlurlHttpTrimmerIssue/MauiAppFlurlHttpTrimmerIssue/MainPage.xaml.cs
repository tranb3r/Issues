using Flurl.Http;

namespace MauiAppFlurlHttpTrimmerIssue
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await new TestFlurlHttp().RunAsync();
        }
    }
}