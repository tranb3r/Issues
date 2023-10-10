using System;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Analysers;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using Microsoft.Maui.Controls;

namespace MauiAppBenchmarkBindings
{
    public partial class BenchmarkDnPage : ContentPage
    {
        public BenchmarkDnPage()
        {
            InitializeComponent();
        }

        private async void OnButton1Clicked(object sender, EventArgs e)
        {
            await RunAsync<BenchmarkDn>();
        }

        private async void OnButton2Clicked(object sender, EventArgs e)
        {
            await RunAsync<BenchmarkDn2>();
        }

        private async Task RunAsync<T>()
        {
            SetIsRunning(true);

            try
            {
                var logger = new AccumulationLogger();
                await Task.Run(() =>
                {
                    IConfig config;
#if DEBUG
                    config = new DebugInProcessConfig();
#else
                    config = ManualConfig.CreateMinimumViable();
#endif
                    var summary = BenchmarkRunner.Run<T>(config);
                    MarkdownExporter.Console.ExportToLog(summary, logger);
                    ConclusionHelper.Print(logger,
                        summary.BenchmarksCases
                            .SelectMany(benchmark => benchmark.Config.GetCompositeAnalyser().Analyse(summary))
                            .Distinct()
                            .ToList());
                });
                SetSummary(logger.GetLog());
            }
            catch (Exception exc)
            {
                await DisplayAlert("Error", exc.StackTrace, "Ok");
            }
            finally
            {
                SetIsRunning(false);
            }
        }

        void SetIsRunning(bool isRunning)
        {
            Indicator.IsRunning = isRunning;
            ButtonRun1.IsEnabled = !isRunning;
            ButtonRun2.IsEnabled = !isRunning;
            LabelSummary.IsVisible = !isRunning;
        }

        void SetSummary(string text)
        {
            LabelSummary.Text = text;
            var size = LabelSummary.Measure(double.MaxValue, double.MaxValue).Request;
            LabelSummary.WidthRequest = size.Width;
            LabelSummary.HeightRequest = size.Height;
        }
    }
}
