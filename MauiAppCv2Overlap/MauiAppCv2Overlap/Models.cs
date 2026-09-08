using System.Collections.ObjectModel;

namespace MauiAppCv2Overlap;

public class Item
{
	public bool IsGroupB { get; set; }
	public string Text { get; set; } = "";
}

public class Group : ObservableCollection<Item>
{
	public string Name { get; }
	public Group(string name, IEnumerable<Item> items) : base(items)
	{
		Name = name;
	}
}

public class ItemTemplateSelector : DataTemplateSelector
{
	public DataTemplate GroupATemplate { get; set; } = null!;
	public DataTemplate GroupBTemplate { get; set; } = null!;

	protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		=> item is Item { IsGroupB: true } ? GroupBTemplate : GroupATemplate;
}
