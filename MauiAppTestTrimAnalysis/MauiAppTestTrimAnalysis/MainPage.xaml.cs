namespace MauiAppTestTrimAnalysis
{
    public partial class MainPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MyViewModel();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
