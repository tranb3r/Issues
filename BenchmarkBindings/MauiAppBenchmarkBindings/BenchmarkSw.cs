using System;
using ClassLibrary1;
using System.Diagnostics;
using Microsoft.Maui.Controls;

namespace MauiAppBenchmarkBindings
{
    internal class BenchmarkSw : BenchmarkSwBase
    {
        protected override long Run(Func<MyViewModel, View> action)
        {
            var vm = new MyViewModel
            {
                Title = "Hello world"
            };
            var i = 0L;
            var sw = Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < N)
            {
                _ = action(vm);
                ++i;
            }
            return i;
        }
    }
}
