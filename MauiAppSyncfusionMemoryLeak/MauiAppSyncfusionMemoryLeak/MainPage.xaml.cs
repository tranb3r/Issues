namespace MauiAppSyncfusionMemoryLeak
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Default_OnClicked(object? sender, EventArgs e)
        {
            NavigateTo(new Page1_Default());
        }

        private void Button_SfProgressBar_OnClicked(object? sender, EventArgs e)
        {
            NavigateTo(new Page2_SfProgressBar());
        }

        private void Button_SfTextInputLayout_OnClicked(object? sender, EventArgs e)
        {
            NavigateTo(new Page3_SfTextInputLayout());
        }

        private void Button_SfEffectsView_OnClicked(object? sender, EventArgs e)
        {
            NavigateTo(new Page4_SfEffectsView());
        }

        private void NavigateTo(Page page)
        {
            Application.Current.MainPage.Navigation.PushAsync(page);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            GC.Collect();
            MemoryLabelRef.Text = $"Memory: {GC.GetTotalMemory(false)}";
        }
    }
}
