using Android.App;
using Android.Content.PM;
using Android.Util;
using AndroidX.Work;

namespace MauiAppWindowWasAlreadyCreated
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnDestroy()
        {
            base.OnDestroy();

            Log.Info("MauiAppWindowWasAlreadyCreated", "OnDestroy");
        }

        protected override void OnStart()
        {
            base.OnStart();

            Log.Info("MauiAppWindowWasAlreadyCreated", "OnStart");

            ScheduleJob();
        }

        private void ScheduleJob()
        {
            var workRequest = PeriodicWorkRequest.Builder
                .From<JobWorker>(TimeSpan.FromMinutes(5), TimeSpan.FromMinutes(5))
                .Build();

            WorkManager.GetInstance(Android.App.Application.Context)
                .EnqueueUniquePeriodicWork("MauiAppWindowWasAlreadyCreated", ExistingPeriodicWorkPolicy.CancelAndReenqueue, workRequest);
        }
    }
}