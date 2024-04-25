using System;
using System.Timers;
using Microsoft.Maui.ApplicationModel;

namespace MauiAppStaticResourceMemory
{
    public partial class MainPage
    {
        private const int N = 191; // 190=ok 191=ko

        public MainPage()
        {
            InitializeComponent();

            BindingContext = new PageViewModel();

            StartMemoryTimer();

            InitResources();
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

        private void ButtonDecrease_OnClicked(object sender, EventArgs e)
        {
            var c = Resources.Count;
            Resources.Remove($"Int{c}");
            c--;
            CountLabelRef.Text = $"Resources: {c}";
        }

        private void ButtonIncrease_OnClicked(object sender, EventArgs e)
        {
            var c = Resources.Count;
            c++;
            Resources.Add($"Int{c}", c);
            CountLabelRef.Text = $"Resources: {c}";
        }

        private void InitResources()
        {
            for (var i = 1; i <= N; ++i)
            {
                Resources.Add($"Int{i}", i);
            }
            CountLabelRef.Text = $"Resources: {Resources.Count}";
        }
    }
}
