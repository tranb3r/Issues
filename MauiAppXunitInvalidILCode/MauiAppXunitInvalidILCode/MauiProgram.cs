using System.Reflection;
using ClassLibraryTests;
using Xunit.Runners.Maui;

namespace MauiAppXunitInvalidILCode
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            return MauiApp
                .CreateBuilder()
                .ConfigureTests(new TestOptions
                {
                    Assemblies =
                    {
                        typeof(TestClass1).GetTypeInfo().Assembly
                    }
                })
                .UseVisualRunner()
                .Build();
        }
    }
}
