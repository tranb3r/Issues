using Plugin.Firebase.Firestore.Platforms.Android.Extensions;

namespace MauiAppFirestoreExtensionAndroidxCollection
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var data = new Dictionary<string, Java.Lang.Object>
                {
                    { "name", new Java.Lang.String("Bulbasaur") }
                };
                var pokemon = data.Cast<Pokemon>();
                await DisplayAlert("Success", pokemon.Name, "Close");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Exception", ex.ToString(), "Close");
            }
        }
    }
}