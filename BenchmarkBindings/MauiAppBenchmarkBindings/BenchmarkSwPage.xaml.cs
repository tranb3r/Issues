using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace MauiAppBenchmarkBindings
{
    public partial class BenchmarkSwPage : ContentPage
    {
        public BenchmarkSwPage()
        {
            InitializeComponent();
        }

        private async void OnButton1Clicked(object sender, EventArgs e)
        {
            await RunAsync(new BenchmarkSw());
        }

        private async void OnButton2Clicked(object sender, EventArgs e)
        {
            await RunAsync(new BenchmarkSw2());
        }

        private async Task RunAsync(BenchmarkSwBase benchmark)
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
            LabelResultXaml.Text = $"Xaml: {BenchmarkSwBase.N * 1000.0 / result:F2}μs";
            await Task.Delay(10);

            result = benchmark.RunXamlCompiledBindings();
            LabelResultXamlCompiledBindings.Text = $"Xaml compiled bindings: {BenchmarkSwBase.N * 1000.0 / result:F2}μs";
            await Task.Delay(10);

            result = benchmark.RunCSharp();
            LabelResultCSharp.Text = $"C#: {BenchmarkSwBase.N * 1000.0 / result:F2}μs";
            await Task.Delay(10);

            result = benchmark.RunCSharpTypedBindings();
            LabelResultCSharpTypedBindings.Text = $"C# typed bindings: {BenchmarkSwBase.N * 1000.0 / result:F2}μs";
            await Task.Delay(10);

            LabelStatus.IsVisible = false;
            ButtonRun1.IsEnabled = true;
            ButtonRun2.IsEnabled = true;
        }
    }

}
