using System;
using ClassLibrary1;
using System.Diagnostics;

namespace MauiAppBenchmarkBindings
{
    internal class Benchmark2 : BenchmarkBase
    {
        protected override long Run(Action<MyViewModel> action)
        {
            var vm = new MyViewModel
            {
                Title = "Hello world"
            };
            action(vm);
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
