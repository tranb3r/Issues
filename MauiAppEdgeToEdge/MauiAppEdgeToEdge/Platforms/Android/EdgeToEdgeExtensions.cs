using Android.Content.Res;
using Android.Views;
using AndroidX.Core.View;
using System;

namespace MauiAppEdgeToEdge;

internal static class ActivityExtensions
{
	static global::Android.Graphics.Color DefaultLightScrim = global::Android.Graphics.Color.Argb(0xe6, 0xFF, 0xFF, 0xFF);
	static global::Android.Graphics.Color DefaultDarkScrim = global::Android.Graphics.Color.Argb(0x80, 0x1b, 0x1b, 0x1b);


	public static void EnableEdgeToEdge(this global::Android.App.Activity activity)
		=> activity.EnableEdgeToEdge(
			SystemBarStyle.Auto(global::Android.Graphics.Color.Transparent, global::Android.Graphics.Color.Transparent),
			SystemBarStyle.Auto(DefaultLightScrim, DefaultDarkScrim));

	public static void EnableEdgeToEdge(this global::Android.App.Activity activity, SystemBarStyle statusBarStyle, SystemBarStyle navigationBarStyle)
		=> activity.Window?.EnableEdgeToEdge(activity.Resources!, statusBarStyle, navigationBarStyle);

	public static void EnableEdgeToEdge(this global::Android.Views.Window window, global::Android.Content.Res.Resources resources)
		=> window.EnableEdgeToEdge(resources,
			SystemBarStyle.Auto(global::Android.Graphics.Color.Transparent, global::Android.Graphics.Color.Transparent),
			SystemBarStyle.Auto(DefaultLightScrim, DefaultDarkScrim));

	public static void EnableEdgeToEdge(this global::Android.Views.Window window, global::Android.Content.Res.Resources resources, SystemBarStyle statusBarStyle, SystemBarStyle navigationBarStyle)
	{
		var res = resources;
		var view = window!.DecorView;
		var statusBarIsDark = statusBarStyle.DetectDarkMode(res!);
		var navigationBarIsDark = navigationBarStyle.DetectDarkMode(res!);

		IEdgeToEdge impl;

		if (OperatingSystem.IsAndroidVersionAtLeast(30))
			impl = new EdgeToEdge30();
		else if (OperatingSystem.IsAndroidVersionAtLeast(29))
			impl = new EdgeToEdgeApi29();
		else if (OperatingSystem.IsAndroidVersionAtLeast(28))
			impl = new EdgeToEdgeApi28();
		else if (OperatingSystem.IsAndroidVersionAtLeast(26))
			impl = new EdgeToEdgeApi26();
		else if (OperatingSystem.IsAndroidVersionAtLeast(23))
			impl = new EdgeToEdgeApi23();
		else if (OperatingSystem.IsAndroidVersionAtLeast(21))
			impl = new EdgeToEdgeApi21();
		else
			impl = new EdgeToEdgeBase();

		impl.Setup(statusBarStyle, navigationBarStyle, window, view, statusBarIsDark, navigationBarIsDark);

		impl.AdjustLayoutInDisplayCutoutMode(window!);
	}
}


internal class SystemBarStyle
{
	public SystemBarStyle(global::Android.Graphics.Color lightScrim, global::Android.Graphics.Color darkScrim, UiMode nightMode, Func<global::Android.Content.Res.Resources, bool> detectDarkMode)
	{
		LightScrim = lightScrim;
		DarkScrim = darkScrim;
		NightMode = nightMode;
		DetectDarkMode = detectDarkMode;
	}

	public static SystemBarStyle Auto(global::Android.Graphics.Color lightScrim, global::Android.Graphics.Color darkScrim)
		=> new SystemBarStyle(lightScrim, darkScrim, UiMode.NightUndefined, res =>
			(res.Configuration!.UiMode & UiMode.NightMask) == UiMode.NightYes);

	public static SystemBarStyle Dark(global::Android.Graphics.Color scrim)
		=> new SystemBarStyle(scrim, scrim, UiMode.NightYes, res => true);

	public static SystemBarStyle Light(global::Android.Graphics.Color scrim, global::Android.Graphics.Color darkScrim)
		=> new SystemBarStyle(scrim, darkScrim, UiMode.NightNo, res => false);

	public global::Android.Graphics.Color LightScrim { get; private set; }
	public global::Android.Graphics.Color DarkScrim { get; private set; }

	public UiMode NightMode { get; private set; }

	public Func<Resources, bool> DetectDarkMode { get; private set; }

	public global::Android.Graphics.Color GetScrim(bool isDark)
	{
		return isDark ? DarkScrim : LightScrim;
	}

	public global::Android.Graphics.Color GetScrimWithEnforcedContrast(bool isDark)
	{
		if (NightMode == UiMode.NightUndefined)
			return global::Android.Graphics.Color.Transparent;

		if (isDark)
			return DarkScrim;

		return LightScrim;
	}
}

internal interface IEdgeToEdge
{
	void Setup(
		SystemBarStyle statusBarStyle,
		SystemBarStyle navigationBarStyle,
		global::Android.Views.Window window,
		global::Android.Views.View view,
		bool statusBarIsDark,
		bool navigationBarIsDark)
	{
		// No edge to edge, pre SDK 21
	}

	void AdjustLayoutInDisplayCutoutMode(global::Android.Views.Window window)
	{
		// No display cutout before SDK 28
	}
}

internal class EdgeToEdgeBase : IEdgeToEdge
{
	public virtual void Setup(
		SystemBarStyle statusBarStyle,
		SystemBarStyle navigationBarStyle,
		global::Android.Views.Window window,
		global::Android.Views.View view,
		bool statusBarIsDark,
		bool navigationBarIsDark)
	{
		// No edge to edge, pre SDK 21
	}

	public virtual void AdjustLayoutInDisplayCutoutMode(global::Android.Views.Window window)
	{
		// No display cutout before SDK 28
	}
}

internal class EdgeToEdgeApi21 : EdgeToEdgeBase
{
	public override void Setup(
		SystemBarStyle statusBarStyle,
		SystemBarStyle navigationBarStyle,
		global::Android.Views.Window window,
		global::Android.Views.View view,
		bool statusBarIsDark,
		bool navigationBarIsDark)
	{
		WindowCompat.SetDecorFitsSystemWindows(window, false);
		window.AddFlags(WindowManagerFlags.TranslucentStatus);
		window.AddFlags(WindowManagerFlags.TranslucentNavigation);
	}
}

internal class EdgeToEdgeApi23 : EdgeToEdgeBase
{
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1422:Validate platform compatibility", Justification = "<Pending>")]
	public override void Setup(
		SystemBarStyle statusBarStyle,
		SystemBarStyle navigationBarStyle,
		global::Android.Views.Window window,
		global::Android.Views.View view,
		bool statusBarIsDark,
		bool navigationBarIsDark)
	{
		WindowCompat.SetDecorFitsSystemWindows(window, false);
		window.SetStatusBarColor(statusBarStyle.GetScrim(statusBarIsDark));
		window.SetNavigationBarColor(navigationBarStyle.DarkScrim);
		new WindowInsetsControllerCompat(window, view).AppearanceLightStatusBars = !statusBarIsDark;
	}
}

internal class EdgeToEdgeApi26 : EdgeToEdgeBase
{
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1422:Validate platform compatibility", Justification = "<Pending>")]
	public override void Setup(
		SystemBarStyle statusBarStyle,
		SystemBarStyle navigationBarStyle,
		global::Android.Views.Window window,
		global::Android.Views.View view,
		bool statusBarIsDark,
		bool navigationBarIsDark)
	{
		WindowCompat.SetDecorFitsSystemWindows(window, false);
		window.SetStatusBarColor(statusBarStyle.GetScrim(statusBarIsDark));
		window.SetNavigationBarColor(navigationBarStyle.GetScrim(navigationBarIsDark));
		var c = new WindowInsetsControllerCompat(window, view);
		c.AppearanceLightStatusBars = !statusBarIsDark;
		c.AppearanceLightNavigationBars = !navigationBarIsDark;
	}
}

internal class EdgeToEdgeApi28 : EdgeToEdgeApi26
{
	public override void AdjustLayoutInDisplayCutoutMode(global::Android.Views.Window window)
	{
		if (OperatingSystem.IsAndroidVersionAtLeast(28))
			window.Attributes!.LayoutInDisplayCutoutMode = LayoutInDisplayCutoutMode.ShortEdges;
	}
}

internal class EdgeToEdgeApi29 : EdgeToEdgeApi28
{
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1422:Validate platform compatibility", Justification = "<Pending>")]
	public override void Setup(
		SystemBarStyle statusBarStyle,
		SystemBarStyle navigationBarStyle,
		global::Android.Views.Window window,
		global::Android.Views.View view,
		bool statusBarIsDark,
		bool navigationBarIsDark)
	{
		if (OperatingSystem.IsAndroidVersionAtLeast(29))
		{
			WindowCompat.SetDecorFitsSystemWindows(window, false);
			window.SetStatusBarColor(statusBarStyle.GetScrimWithEnforcedContrast(statusBarIsDark));
			window.SetNavigationBarColor(navigationBarStyle.GetScrimWithEnforcedContrast(navigationBarIsDark));
			window.StatusBarContrastEnforced = false;
			window.NavigationBarContrastEnforced = navigationBarStyle.NightMode == UiMode.NightUndefined;

			var c = new WindowInsetsControllerCompat(window, view);
			c.AppearanceLightStatusBars = !statusBarIsDark;
			c.AppearanceLightNavigationBars = !navigationBarIsDark;
		}
	}
}

internal class EdgeToEdge30 : EdgeToEdgeApi29
{
	public override void AdjustLayoutInDisplayCutoutMode(global::Android.Views.Window window)
	{
		if (OperatingSystem.IsAndroidVersionAtLeast(30))
			window.Attributes!.LayoutInDisplayCutoutMode = LayoutInDisplayCutoutMode.Always;
	}
}