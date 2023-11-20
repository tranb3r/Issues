namespace MauiAppMaterialButtonAndCheckbox
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_TestButton_OnClicked(object? sender, EventArgs e)
        {
            Navigation.PushAsync(new PageButton());
        }

        private void Button_TestCheckbox_OnClicked(object? sender, EventArgs e)
        {
            Navigation.PushAsync(new PageCheckbox());
        }
    }
}
