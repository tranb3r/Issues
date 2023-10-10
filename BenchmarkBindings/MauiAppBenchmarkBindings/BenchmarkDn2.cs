using System;
using ClassLibrary1;
using BenchmarkDotNet.Attributes;

namespace MauiAppBenchmarkBindings
{
    public class BenchmarkDn2
    {
        private MyViewModel _vmXaml;
        private MyViewXaml _viewXaml;

        private MyViewModel _vmXamlCompiledBindings;
        private MyViewXamlCompiledBindings _viewXamlCompiledBindings;

        private MyViewModel _vmCSharp;
        private MyViewCSharp _viewCSharp;

        private MyViewModel _vmCSharpTypedBindings;
        private MyViewCSharpTypedBindings _viewCSharpTypedBindings;

        [GlobalSetup(Target = nameof(RunXaml))]
        public void SetupXaml()
        {
            _vmXaml = new MyViewModel();
            _viewXaml = new MyViewXaml { BindingContext = _vmXaml };
        }

        [Benchmark]
        public void RunXaml()
        {
            _vmXaml.Title = $"Hello user {Guid.NewGuid()}";
        }

        [GlobalSetup(Target = nameof(RunXamlCompiledBindings))]
        public void SetupXamlCompiledBindings()
        {
            _vmXamlCompiledBindings = new MyViewModel();
            _viewXamlCompiledBindings = new MyViewXamlCompiledBindings { BindingContext = _vmXamlCompiledBindings };
        }

        [Benchmark]
        public void RunXamlCompiledBindings()
        {
            _vmXamlCompiledBindings.Title = $"Hello user {Guid.NewGuid()}";
        }

        [GlobalSetup(Target = nameof(RunCSharp))]
        public void SetupCSharp()
        {
            _vmCSharp = new MyViewModel();
            _viewCSharp = new MyViewCSharp { BindingContext = _vmCSharp };
        }

        [Benchmark]
        public void RunCSharp()
        {
            _vmCSharp.Title = $"Hello user {Guid.NewGuid()}";
        }

        [GlobalSetup(Target = nameof(RunCSharpTypedBindings))]
        public void SetupCSharpTypedBindings()
        {
            _vmCSharpTypedBindings = new MyViewModel();
            _viewCSharpTypedBindings = new MyViewCSharpTypedBindings { BindingContext = _vmCSharpTypedBindings };
        }

        [Benchmark]
        public void RunCSharpTypedBindings()
        {
            _vmCSharpTypedBindings.Title = $"Hello user {Guid.NewGuid()}";
        }
    }
}
