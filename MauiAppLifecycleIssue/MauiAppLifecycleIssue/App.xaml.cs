namespace MauiAppLifecycleIssue
{
    public partial class App : Application
    {
        public App()
        {
            Console.WriteLine("App: Create");

            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Console.WriteLine("App: OnStart");
        }

        protected override void OnSleep()
        {
            Console.WriteLine("App: OnSleep");
        }

        protected override void OnResume()
        {
            Console.WriteLine("App: OnResume");
        }
    }
}
