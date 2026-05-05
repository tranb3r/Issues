namespace MauiAppScrollToRegression;

public class MyItem
{
    public string Name { get; set; } = string.Empty;
}

public class ItemGroup : List<MyItem>
{
    public string Key { get; set; } = string.Empty;
}

public partial class MainPage : ContentPage
{
    private readonly List<ItemGroup> _groups;

    public MainPage()
    {
        InitializeComponent();

        _groups = [];
        for (int g = 1; g <= 5; g++)
        {
            var group = new ItemGroup { Key = $"Group {g}" };
            for (int i = 1; i <= 10; i++)
                group.Add(new MyItem { Name = $"Group {g} — Item {i}" });
            _groups.Add(group);
        }

        MyCollectionView.ItemsSource = _groups;
    }

    private void OnScrollToStart(object? sender, EventArgs e)
    {
        MyCollectionView.ScrollTo(0);
    }

    private void OnScrollToFirstItem(object? sender, EventArgs e)
    {
        var firstGroup = _groups[0];
        MyCollectionView.ScrollTo(firstGroup[0], firstGroup, ScrollToPosition.Start, animate: true);
    }

    private void OnScrollToLastItem(object? sender, EventArgs e)
    {
        var lastGroup = _groups[^1];
        MyCollectionView.ScrollTo(lastGroup[^1], lastGroup, ScrollToPosition.End, animate: true);
    }

    private void OnScrollToEnd(object? sender, EventArgs e)
    {
        MyCollectionView.ScrollTo(54);
    }
}
