using CommunityToolkit.Maui.Alerts;

namespace MauiAppSnackbar
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var toast = Snackbar.Make("Hello");

            try
            {
                await toast.Show();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Exception", ex.ToString(), "Cancel");
            }
        }
    }
}
