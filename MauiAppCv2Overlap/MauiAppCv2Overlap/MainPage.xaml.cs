using System.Collections.ObjectModel;

namespace MauiAppCv2Overlap;

public partial class MainPage : ContentPage
{
	public ObservableCollection<Group> Groups { get; }

	public MainPage()
	{
		var groupA = new Group("Section A", Enumerable.Range(0, 3)
			.Select(i => new Item
			{
				IsGroupB = false,
				Text = $"Row A {i}",
			}));

		var groupB = new Group("Section B", Enumerable.Range(0, 40)
			.Select(i => new Item
			{
				IsGroupB = true,
				Text = $"Row B {i:D2}",
			}));

		Groups = [groupA, groupB];

		InitializeComponent();
		BindingContext = this;
	}
}
