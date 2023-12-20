namespace MauiAppSyncfusionMemoryLeak
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("xxxxxxxxx");

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
