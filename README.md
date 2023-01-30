# Issues

Migration from Xamarin.Forms to DotNet Maui

### Open issues

| Description | Link | Severity | Repro |
| --- | --- | --- | --- |
| TabbedPage content becomes blank after navigating tabs | dotnet/maui/issues/7558 <br /> dotnet/maui/issues/9743 | Critical | [MauiAppTabbedPageBlank](MauiAppTabbedPageBlank) |
| CollectionView Header/Footer/EmptyView issues | dotnet/maui/issues/11896 | High | [MauiAppCollectionViewHeaderOrEmpty](MauiAppCollectionViewHeaderOrEmpty) |
| Random crash | xamarin/xamarin-android/issues/7335 | High | |
| CollectionView virtualization does not work when using a DataTemplateSelector | dotnet/maui/issues/11272 <br /> https://github.com/xamarin/Xamarin.Forms/issues/13045 | Medium | [CollectionViewVirtualization](CollectionViewVirtualization) |
| Border margin issue | dotnet/maui/issues/11994 <br /> dotnet/maui/issues/7764 <br /> dotnet/maui/issues/7521 | Medium | [MauiAppBorderMargin](MauiAppBorderMargin) |
| MauiIcon is incorrectly streched and clipped | dotnet/maui/issues/11295 <br /> dotnet/maui/issues/11159 | Low | [MauiAppIconStretched](MauiAppIconStretched) |
| Unable to load font 'monospace' | dotnet/maui/issues/11422 | Low | [MauiAppFontMonospace](MauiAppFontMonospace) |
| Java.Lang.IllegalStateException when pushing modal page on app resume | dotnet/maui/issues/11259 <br /> dotnet/maui/issues/11501 | Low | [MauiAppExceptionOnResume](MauiAppExceptionOnResume) |
| (Un)SelectedTabColor do not work for TabbedPage icons (FontImageSource) on iOS | dotnet/maui/issues/12250 <br /> dotnet/maui/issues/6043 <br /> dotnet/maui/issues/6718 <br /> xamarin/Xamarin.Forms/issues/8556 | Low | [MauiAppTabbedPageIconColor](MauiAppTabbedPageIconColor) |
| IsPassword cannot be set dynamically for numeric keyboard | dotnet/maui/issues/12332 | Low | [MauiAppSfTextInputLayout](MauiAppSfTextInputLayout) |
| Border content clipping issue on iOS | dotnet/maui/issues/12398 | Low | [MauiAppBorderPaddingClip](MauiAppBorderPaddingClip) |
| Carsousel view position is not correct on iOS | dotnet/maui/issues/12425 | Low | [MauiAppCarouselView](MauiAppCarouselView) |
| CollectionView Items display issue when Header is resized on iOS | dotnet/maui/issues/12429 | Low | [MauiAppCollectionViewHeaderResize](MauiAppCollectionViewHeaderResize) |
| SwipeView animation is not fluid when combined with LongPress gesture on iOS | vapolia/MauiGestures/issues/2 | Low | [MauiAppSwipeViewAnimation](MauiAppSwipeViewAnimation) |

### Fixed issues

| Description | Link | Severity | Repro |
| --- | --- | --- | --- |
| SwipeItemView sizing is wrong | dotnet/maui/issues/10065 <br /> dotnet/maui/issues/6018 | Low | [MauiAppSwipeItemViewSizing](MauiAppSwipeItemViewSizing) |
| UseLocalNotification is not defined for net7.0 TFM | thudugala/Plugin.LocalNotification/issues/343 | Low | [MauiAppLocalNotificationLib](MauiAppLocalNotificationLib) |
| SfTextInputLayout maui issues | https://support.syncfusion.com/support/tickets/426462 | Low | [MauiAppSfTextInputLayout](MauiAppSfTextInputLayout) |
| Fody warning assembly has already been processed | Fody/Fody/issues/1023 | Low | [MauiAppFodyAlreadyProcessed](MauiAppFodyAlreadyProcessed) |

### Severity

- critical: must be resolved immediately, as it renders the app unusable until it is resolved.
- high: must be resolved at the earliest, as it degrades user experience and there is no workaround.
- medium: can be fixed in the normal course of development and testing.
- low:  can be fixed at a later date (more serious bugs take priority).
