using System;
using ClassLibrary1;
using Microsoft.Maui.Controls;

namespace MauiAppBenchmarkBindings
{
    internal abstract class BenchmarkSwBase
    {
        public const int N = 10 * 1000;

        public long RunXaml()
        {
            return Run(vm => new MyViewXaml { BindingContext = vm });
        }

        public long RunXamlCompiledBindings()
        {
            return Run(vm => new MyViewXamlCompiledBindings { BindingContext = vm });
        }

        public long RunCSharp()
        {
            return Run(vm => new MyViewCSharp { BindingContext = vm });
        }

        public long RunCSharpTypedBindings()
        {
            return Run(vm => new MyViewCSharpTypedBindings { BindingContext = vm });
        }

        protected abstract long Run(Func<MyViewModel, View> action);
    }
}
