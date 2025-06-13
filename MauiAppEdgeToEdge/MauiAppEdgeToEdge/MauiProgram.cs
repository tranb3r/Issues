﻿#if ANDROID
using Android.OS;
using AndroidX.Activity;
using AndroidX.Fragment.App;

#endif
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
									if (fragment is AndroidX.Fragment.App.DialogFragment dialogFragment && dialogFragment.Activity is not null)
									{
										dialogFragment.Dialog?.Window?.EnableEdgeToEdge(dialogFragment.Dialog.Window.DecorView!.Resources!);

										// These don't seem to work, perhaps it's not getting the correct activity still
										// if (dialogFragment.Dialog.OwnerActivity is ComponentActivity dfComponentActivity)
										//	EdgeToEdge.Enable(dfComponentActivity);
										//EdgeToEdge.Enable(dialogFragment.Activity);
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
public class MyFragmentLifecycleCallbacks(Action<AndroidX.Fragment.App.FragmentManager, AndroidX.Fragment.App.Fragment> onFragmentStarted) : AndroidX.Fragment.App.FragmentManager.FragmentLifecycleCallbacks
{
	public override void OnFragmentStarted(AndroidX.Fragment.App.FragmentManager fm, AndroidX.Fragment.App.Fragment f)
	{
		onFragmentStarted?.Invoke(fm, f);
		base.OnFragmentStarted(fm, f);
	}
}
#endif