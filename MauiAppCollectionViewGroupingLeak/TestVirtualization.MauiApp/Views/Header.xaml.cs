using Microsoft.Maui.Controls;
using TestVirtualization.MauiApp.Models;

namespace TestVirtualization.MauiApp.Views
{
	public partial class Header : HorizontalStackLayout
	{
		public Header ()
		{
			InitializeComponent ();
		}

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

			Counters.Instance.Reset();
        }
    }
}