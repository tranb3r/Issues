using AndroidX.Activity;
using AndroidX.Fragment.App;
using Microsoft.Maui.LifecycleEvents;
using Microsoft.Maui.Platform;

namespace MauiAppEdgeToEdge
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
				.ConfigureLifecycleEvents(lifecycleBuilder =>
				{
#if ANDROID
					lifecycleBuilder.AddAndroid(androidLifecycleBuilder =>
					{
						androidLifecycleBuilder.OnCreate((activity, savedInstance) =>
						{
							if (activity is ComponentActivity componentActivity)
							{
								// Enable Edge to Edge for the activity
								EdgeToEdge.Enable(componentActivity);

								// Also wire up a fragment lifecycle callback so we can enable edge to edge on fragments
								componentActivity.GetFragmentManager()?.RegisterFragmentLifecycleCallbacks(new MyFragmentLifecycleCallbacks((fragmentManager, fragment) =>
								{
									// Modals in MAUI in NET9 use DialogFragment
									{
										// Edge to Edge on the fragment's window
									if (fragment is AndroidX.Fragment.App.DialogFragment dialogFragment)
										dialogFragment.Dialog!.Window!.EnableEdgeToEdge(dialogFragment.Dialog!.Window!.DecorView!.Resources!);
									}
								}), false);
							}
						});
					});
#endif
				});

            return builder.Build();
        }
    }
}

#if ANDROID
public class MyFragmentLifecycleCallbacks(Action<FragmentManager, Fragment> onFragmentStarted) : FragmentManager.FragmentLifecycleCallbacks
{
	public override void OnFragmentStarted(FragmentManager fm, Fragment f)
	{
		onFragmentStarted?.Invoke(fm, f);
		base.OnFragmentStarted(fm, f);
	}
}
#endif