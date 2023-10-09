using Microsoft.Maui.Hosting;
using CommunityToolkit.Maui.Markup;

namespace MauiAppBenchmarkBindings
{
    public static class MauiAppBuilderExtensions
    {
        public static MauiAppBuilder ConfigureClassLibrary1(this MauiAppBuilder builder)
        {
            return builder
                .UseMauiCommunityToolkitMarkup();
        }
    }
}
