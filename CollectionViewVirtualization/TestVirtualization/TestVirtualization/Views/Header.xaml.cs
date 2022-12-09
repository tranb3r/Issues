using TestVirtualization.Models;
using Xamarin.Forms;

namespace TestVirtualization.Views
{
	public partial class Header : StackLayout
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