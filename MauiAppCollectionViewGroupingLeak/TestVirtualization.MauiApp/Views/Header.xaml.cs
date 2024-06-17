using System;
using System.Timers;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using TestVirtualization.MauiApp.Models;

namespace TestVirtualization.MauiApp.Views
{
	public partial class Header : HorizontalStackLayout
	{
		public Header ()
		{
			InitializeComponent ();

            StartMemoryTimer();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

			Counters.Instance.Reset();
        }

        private void StartMemoryTimer()
        {
            var timer = new Timer(1000);
            timer.Elapsed += (_, _) =>
            {
                var memory = GC.GetTotalMemory(false) / 1024d / 1024d;
                MainThread.BeginInvokeOnMainThread(() => MemLabelRef.Text = $"Mem: {memory:F1} MB");
            };
            timer.Start();
        }

        private void ButtonGC_OnClicked(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}