using System;
using ClassLibrary1;
using System.Diagnostics;

namespace MauiAppBenchmarkBindings
{
    internal class Benchmark : BenchmarkBase
    {
        protected override long Run(Action<MyViewModel> action)
        {
            var vm = new MyViewModel
            {
                Title = "Hello world"
            };
            var i = 0L;
            var sw = Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < N)
            {
                action(vm);
                ++i;
            }
            return i;
        }
    }
}
