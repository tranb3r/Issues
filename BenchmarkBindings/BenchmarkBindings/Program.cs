using System;
using System.Diagnostics;
using ClassLibrary1;

namespace BenchmarkBindings
{
    internal class Program
    {
        static void Main()
        {
            const int n = 10 * 1000;

            var vm = new MyViewModel
            {
                Title = "Hello world"
            };

            var sw = new Stopwatch();

            var i = 0L;
            sw.Restart();
            while (sw.ElapsedMilliseconds < n)
            {
                _ = new MyViewXaml { BindingContext = vm };
                ++i;
            }
            Console.WriteLine($"Xaml: {i}");

            i = 0L;
            sw.Restart();
            while (sw.ElapsedMilliseconds < n)
            {
                _ = new MyViewXamlCompiledBindings { BindingContext = vm };
                ++i;
            }
            Console.WriteLine($"Xaml compiled bindings: {i}");

            i = 0L;
            sw.Restart();
            while (sw.ElapsedMilliseconds < n)
            {
                _ = new MyViewCSharp { BindingContext = vm };
                ++i;
            }
            Console.WriteLine($"C#: {i}");

            i = 0L;
            sw.Restart();
            while (sw.ElapsedMilliseconds < n)
            {
                _ = new MyViewCSharpTypedBindings { BindingContext = vm };
                ++i;
            }
            Console.WriteLine($"C# typed bindings: {i}");
        }
    }
}