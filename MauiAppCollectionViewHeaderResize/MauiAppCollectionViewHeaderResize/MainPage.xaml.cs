using Microsoft.Maui.Controls.Internals;

namespace MauiAppCollectionViewHeaderResize;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        BindingContext = new ViewModel();
    }

    private void Button_OnClicked(object sender, EventArgs e)
    {
        if (CollectionViewRef.Header is VisualElement headerVisualElement)
        {
            headerVisualElement.InvalidateMeasureNonVirtual(InvalidationTrigger.Undefined);
        }
    }
}
