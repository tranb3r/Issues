namespace MauiAppLifecycleIssue
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnFinishClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Finish activity");

            Platform.CurrentActivity?.Finish();
        }
    }
}
