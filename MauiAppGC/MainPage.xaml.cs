using System.Collections.ObjectModel;
using System.Globalization;

namespace MauiAppGC;

public class IndexToBrushConverter : IValueConverter
{
    static readonly Color[] Palette =
    [
        Color.FromArgb("#E53935"), Color.FromArgb("#8E24AA"), Color.FromArgb("#1E88E5"),
        Color.FromArgb("#00897B"), Color.FromArgb("#43A047"), Color.FromArgb("#FB8C00"),
    ];

    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        => new SolidColorBrush(Palette[(int)value! % Palette.Length]);

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        => throw new NotSupportedException();
}

public class HeavyItem
{
    static readonly string[] Categories = ["Design", "Dev", "QA", "Infra", "Docs", "UX"];
    static readonly string[] Statuses = ["Open", "In Progress", "Review", "Done", "Blocked"];
    static readonly string[] Priorities = ["P0", "P1", "P2", "P3"];

    public int Index { get; }
    public string Label { get; }
    public string Subtitle { get; }
    public string Initial { get; }
    public string Tag { get; }
    public string Score { get; }
    public double Progress { get; }
    public int ChipIndex1 { get; }
    public int ChipIndex2 { get; }
    public int ChipIndex3 { get; }
    public string Chip1 { get; }
    public string Chip2 { get; }
    public string Chip3 { get; }

    public HeavyItem(int index)
    {
        Index = index;
        Label = $"Item {index} — Lorem ipsum dolor sit amet";
        Subtitle = $"Subtitle {index} — consectetur adipiscing elit, sed do eiusmod";
        Initial = ((char)('A' + (index - 1) % 26)).ToString();
        Tag = $"tag-{index % 10}  •  category-{index % 5}  •  group-{index % 3}";
        Score = $"Score: {index % 1000}";
        Progress = (index % 100) / 100.0;
        ChipIndex1 = index;
        ChipIndex2 = index + 2;
        ChipIndex3 = index + 4;
        Chip1 = Categories[index % Categories.Length];
        Chip2 = Statuses[index % Statuses.Length];
        Chip3 = Priorities[index % Priorities.Length];
    }
}

public partial class MainPage : ContentPage
{
    readonly int[] _baseline = new int[3];
    IDispatcherTimer? _timer;

    public ObservableCollection<HeavyItem> Items { get; } = [];

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;

        for (int i = 0; i < 500; i++)
            Items.Add(new HeavyItem(i + 1));

        _timer = Dispatcher.CreateTimer();
        _timer.Interval = TimeSpan.FromMilliseconds(100);
        _timer.Tick += OnTick;
        _timer.Start();
    }

    void OnTick(object? sender, EventArgs e)
    {
        Gen0Label.Text = $"Gen0: {GC.CollectionCount(0) - _baseline[0]}";
        Gen1Label.Text = $"Gen1: {GC.CollectionCount(1) - _baseline[1]}";
        Gen2Label.Text = $"Gen2: {GC.CollectionCount(2) - _baseline[2]}";
    }

    void OnReset(object? sender, EventArgs e)
    {
        GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced, blocking: true);
        GC.WaitForPendingFinalizers();
        GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced, blocking: true);
        _baseline[0] = GC.CollectionCount(0);
        _baseline[1] = GC.CollectionCount(1);
        _baseline[2] = GC.CollectionCount(2);
    }

    void OnScrollToStart(object? sender, EventArgs e)
        => Cv.ScrollTo(0, animate: true);

    void OnScrollToEnd(object? sender, EventArgs e)
        => Cv.ScrollTo(Items.Count - 1, position: ScrollToPosition.End, animate: true);
}