using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace MauiAppBenchmarkBindings
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnButton1Clicked(object sender, EventArgs e)
        {
            await RunAsync(new Benchmark());
        }

        private async void OnButton2Clicked(object sender, EventArgs e)
        {
            await RunAsync(new Benchmark2());
        }

        private async Task RunAsync(BenchmarkBase benchmark)
        {
            LabelStatus.IsVisible = true;
            LabelResultXaml.Text = "";
            LabelResultXamlCompiledBindings.Text = "";
            LabelResultCSharp.Text = "";
            LabelResultCSharpTypedBindings.Text = "";
            ButtonRun1.IsEnabled = false;
            ButtonRun2.IsEnabled = false;
            await Task.Delay(10);

            var result = benchmark.RunXaml();
            LabelResultXaml.Text = $"Xaml: {result}";
            await Task.Delay(10);

            result = benchmark.RunXamlCompiledBindings();
            LabelResultXamlCompiledBindings.Text = $"Xaml compiled bindings: {result}";
            await Task.Delay(10);

            result = benchmark.RunCSharp();
            LabelResultCSharp.Text = $"C#: {result}";
            await Task.Delay(10);

            result = benchmark.RunCSharpTypedBindings();
            LabelResultCSharpTypedBindings.Text = $"C# typed bindings: {result}";
            await Task.Delay(10);

            LabelStatus.IsVisible = false;
            ButtonRun1.IsEnabled = true;
            ButtonRun2.IsEnabled = true;
        }
    }

}
