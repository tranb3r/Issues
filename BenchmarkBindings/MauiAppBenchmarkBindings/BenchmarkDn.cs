using ClassLibrary1;
using BenchmarkDotNet.Attributes;

namespace MauiAppBenchmarkBindings
{
    public class BenchmarkDn
    {
        private MyViewModel _vm;

        [GlobalSetup]
        public void Setup()
        {
            _vm = new MyViewModel
            {
                Title = "Hello world"
            };
        }

        [Benchmark]
        public void RunXaml()
        {
            _ = new MyViewXaml { BindingContext = _vm };
        }

        [Benchmark]
        public void RunXamlCompiledBindings()
        {
            _ = new MyViewXamlCompiledBindings { BindingContext = _vm };
        }

        [Benchmark]
        public void RunCSharp()
        {
            _ = new MyViewCSharp { BindingContext = _vm };
        }

        [Benchmark]
        public void RunCSharpTypedBindings()
        {
            _ = new MyViewCSharpTypedBindings { BindingContext = _vm };
        }
    }
}
