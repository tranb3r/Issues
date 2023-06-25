using Plugin.Fingerprint.Abstractions;

namespace MauiSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAuthenticate(object sender, EventArgs e)
        {
            lblStatus.Text = "";

            var dialogConfig = new AuthenticationRequestConfiguration("My App", "Prove you have fingers!");

            var result = await Plugin.Fingerprint.CrossFingerprint.Current.AuthenticateAsync(dialogConfig);

            if (result.Authenticated)
            {
                await Navigation.PushAsync(new SecretView());
            }
            else
            {
                lblStatus.Text = $"{result.Status}: {result.ErrorMessage}";
            }
        }
    }
}