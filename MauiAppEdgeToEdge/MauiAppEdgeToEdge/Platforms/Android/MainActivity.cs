using Android.App;
using Android.Content.PM;
using Android.OS;
using AndroidX.Activity;
using AndroidX.Core.View;
using AndroidX.Fragment.App;
using Google.Android.Material.AppBar;

namespace MauiAppEdgeToEdge
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
		//protected override void OnCreate(Bundle? savedInstanceState)
		//{
		//	base.OnCreate(savedInstanceState);

		//	var appBarLayout = FindViewById<AppBarLayout>(Resource.Id.navigationlayout_appbar);

		//	appBarLayout?.SetFitsSystemWindows(true);

		//	var contentLayout = FindViewById<FragmentContainerView>(Resource.Id.navigationlayout_content);

		//	contentLayout?.SetFitsSystemWindows(true);
		//}
	}
}
