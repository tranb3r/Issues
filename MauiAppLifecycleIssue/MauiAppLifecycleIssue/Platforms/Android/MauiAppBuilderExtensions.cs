using Microsoft.Maui.LifecycleEvents;

namespace MauiAppLifecycleIssue
{
    internal static class MauiAppBuilderExtensions
    {
        public static MauiAppBuilder ConfigureLifecycle(this MauiAppBuilder builder)
        {
            return builder.ConfigureLifecycleEvents(events =>
            {
                events.AddAndroid(android => android
                    .OnCreate((_, _) => LogLifecycleEvent(nameof(AndroidLifecycle.OnCreate)))
                    .OnStart(_ => LogLifecycleEvent(nameof(AndroidLifecycle.OnStart)))
                    .OnStop(_ => LogLifecycleEvent(nameof(AndroidLifecycle.OnStop)))
                    .OnDestroy(_ => LogLifecycleEvent(nameof(AndroidLifecycle.OnDestroy)))
                    .OnPause(_ => LogLifecycleEvent(nameof(AndroidLifecycle.OnPause)))
                    .OnResume(_ => LogLifecycleEvent(nameof(AndroidLifecycle.OnResume)))
                    .OnRestart(_ => LogLifecycleEvent(nameof(AndroidLifecycle.OnRestart))));
            });
        }

        private static void LogLifecycleEvent(string eventName)
        {
            Console.WriteLine($"Lifecycle: {eventName}");
        }
    }
}
