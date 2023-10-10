using System;
using ClassLibrary1;
using System.Diagnostics;
using Microsoft.Maui.Controls;

namespace MauiAppBenchmarkBindings
{
    internal class BenchmarkSw2 : BenchmarkSwBase
    {
        protected override long Run(Func<MyViewModel, View> action)
        {
            var vm = new MyViewModel
            {
                Title = "Hello world"
            };
            var view = action(vm);
            var i = 0L;
            var sw = Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < N)
            {
                vm.Title = $"Hello user {i++}";
            }
            return i;
        }
    }
}
