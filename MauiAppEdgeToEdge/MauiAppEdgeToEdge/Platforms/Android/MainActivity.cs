using Android.App;
using Android.Content.PM;
using Android.OS;
using AndroidX.Activity;
using AndroidX.Core.View;

namespace MauiAppEdgeToEdge
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            EdgeToEdge.Enable(this);

            //WindowCompat.SetDecorFitsSystemWindows(Window, false);
            //Window.SetStatusBarColor(global::Android.Graphics.Color.Transparent);
            //Window.SetNavigationBarColor(global::Android.Graphics.Color.Transparent);
        }
    }
}
