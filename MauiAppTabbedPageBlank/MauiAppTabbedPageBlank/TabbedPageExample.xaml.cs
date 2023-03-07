using TabbedPage = Microsoft.Maui.Controls.TabbedPage;

namespace MauiAppTabbedPageBlank;

public partial class TabbedPageExample : TabbedPage
{
    private int _tabsCount;

	public TabbedPageExample()
    {
        AddTab();

        InitializeComponent();
	}

    public void AddTab()
    {
        _tabsCount++;
        var tab = new NavigationPage(new MainPage(this))
        {
            Title = $"Page {_tabsCount}"
        };
        Children.Add(tab);
    }
}