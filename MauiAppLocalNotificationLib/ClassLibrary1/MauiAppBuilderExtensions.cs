using CommunityToolkit.Maui;
using Plugin.LocalNotification;

namespace ClassLibrary1
{
    public static class MauiAppBuilderExtensions
    {
        public static MauiAppBuilder ConfigurePlugins(this MauiAppBuilder mauiAppBuilder)
        {
            return mauiAppBuilder
                .UseMauiCommunityToolkit()
                .UseLocalNotification();
        }
    }
}
