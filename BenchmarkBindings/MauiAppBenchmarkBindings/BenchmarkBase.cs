using System;
using ClassLibrary1;

namespace MauiAppBenchmarkBindings
{
    internal abstract class BenchmarkBase
    {
        protected const int N = 10 * 1000;

        public long RunXaml()
        {
            return Run(vm => _ = new MyViewXaml { BindingContext = vm });
        }

        public long RunXamlCompiledBindings()
        {
            return Run(vm => _ = new MyViewXamlCompiledBindings { BindingContext = vm });
        }

        public long RunCSharp()
        {
            return Run(vm => _ = new MyViewCSharp { BindingContext = vm });
        }

        public long RunCSharpTypedBindings()
        {
            return Run(vm => _ = new MyViewCSharpTypedBindings { BindingContext = vm });
        }

        protected abstract long Run(Action<MyViewModel> action);
    }
}
