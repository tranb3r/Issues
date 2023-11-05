# Issues

Migration from Xamarin.Forms to DotNet Maui

### Open issues

| Description | Link | Severity | Repro |
| --- | --- | --- | --- |
| Snackbar InvalidOperationException when using dotnet trimmer | CommunityToolkit/Maui/issues/1460 | Low | [MauiAppSnackbar](MauiAppSnackbar) |
| App crashes on restart (after being killed by system) when using TitleView | dotnet/maui/issues/16499 | High | [MauiAppDontKeepActivities](MauiAppDontKeepActivities) |
| CollectionView Header/Footer/EmptyView issues | dotnet/maui/issues/11896 | High | [MauiAppCollectionViewHeaderOrEmpty](MauiAppCollectionViewHeaderOrEmpty) |
| Border margin issue | dotnet/maui/issues/11994 <br /> dotnet/maui/issues/7764 <br /> dotnet/maui/issues/7521 | Medium | [MauiAppBorderMargin](MauiAppBorderMargin) |
| Memory leak when scrolling a CollectionView with IsGrouped=true | dotnet/maui/issues/17698 | Medium | [MauiAppCollectionViewGroupingLeak](MauiAppCollectionViewGroupingLeak) |
| Memory leak with CarouselView | dotnet/maui/issues/17726 | Medium | [MauiAppCarouselViewLeak](MauiAppCarouselViewLeak) |
| MauiIcon is incorrectly streched and clipped | dotnet/maui/issues/11295 <br /> dotnet/maui/issues/11159 | Low | [MauiAppIconStretched](MauiAppIconStretched) |
| Java.Lang.IllegalStateException when pushing modal page on app resume | dotnet/maui/issues/11259 <br /> dotnet/maui/issues/11501 | Low | [MauiAppExceptionOnResume](MauiAppExceptionOnResume) |
| (Un)SelectedTabColor do not work for TabbedPage icons (FontImageSource) on iOS | dotnet/maui/issues/12250 <br /> dotnet/maui/issues/6043 <br /> dotnet/maui/issues/6718 <br /> xamarin/Xamarin.Forms/issues/8556 | Low | [MauiAppTabbedPageIconColor](MauiAppTabbedPageIconColor) |
| Border content clipping issue on iOS | dotnet/maui/issues/12398 | Low | [MauiAppBorderPaddingClip](MauiAppBorderPaddingClip) |
| Carsousel view position is not correct on iOS | dotnet/maui/issues/12425 | Low | [MauiAppCarouselView](MauiAppCarouselView) |
| CollectionView Items display issue when Header is resized on iOS | dotnet/maui/issues/12429 | Low | [MauiAppCollectionViewHeaderResize](MauiAppCollectionViewHeaderResize) |
| SwipeView animation is not fluid when combined with LongPress gesture on iOS | vapolia/MauiGestures/issues/2 | Low | [MauiAppSwipeViewAnimation](MauiAppSwipeViewAnimation) |
| System.Linq.Dynamic.Core ParseException when using dotnet trimmer | zzzprojects/System.Linq.Dynamic.Core/issues/678 | Low | [SldcTrimmer](SldcTrimmer) |
| Issue with Babel 10.3 and ObservableProperty | | Low | [MauiAppBabel103](MauiAppBabel103) |

### Fixed issues

| Description | Link | Severity | Repro |
| --- | --- | --- | --- |
| SwipeView Execute mode does not work | https://github.com/dotnet/maui/issues/17371 | Critical | [MauiAppTestSwipeView](MauiAppTestSwipeView) |
| TabbedPage content becomes blank after navigating tabs | dotnet/maui/issues/7558 <br /> dotnet/maui/issues/9743 | Critical | [MauiAppTabbedPageBlank](MauiAppTabbedPageBlank) |
| UI freeze with net8-pre5 | smstuebe/xamarin-fingerprint/issues/237 | Critical | [MauiSamplePluginFingerprint](MauiSamplePluginFingerprint) |
| Random crash | xamarin/xamarin-android/issues/7335 | High | |
| CollectionView virtualization does not work when using a DataTemplateSelector | dotnet/maui/issues/11272 <br /> https://github.com/xamarin/Xamarin.Forms/issues/13045 | Medium | [CollectionViewVirtualization](CollectionViewVirtualization) |
| SwipeItemView sizing is wrong | dotnet/maui/issues/10065 <br /> dotnet/maui/issues/6018 | Low | [MauiAppSwipeItemViewSizing](MauiAppSwipeItemViewSizing) |
| UseLocalNotification is not defined for net7.0 TFM | thudugala/Plugin.LocalNotification/issues/343 | Low | [MauiAppLocalNotificationLib](MauiAppLocalNotificationLib) |
| SfTextInputLayout maui issues | https://support.syncfusion.com/support/tickets/426462 | Low | [MauiAppSfTextInputLayout](MauiAppSfTextInputLayout) |
| Fody warning assembly has already been processed | Fody/Fody/issues/1023 | Low | [MauiAppFodyAlreadyProcessed](MauiAppFodyAlreadyProcessed) |
| Build error when using x:Bind with MauiGesture | levitali/CompiledBindings/issues/27 | Low | [MauiAppTestCompiledBindings](MauiAppTestCompiledBindings) |
| Entry not working when keyboard is numeric and os language is not english (net8-pre5) | https://github.com/dotnet/maui/issues/15884 | Low | [MauiAppKeyboardNumeric](MauiAppKeyboardNumeric) |
| Unable to load font 'monospace' | dotnet/maui/issues/11422 | Low | [MauiAppFontMonospace](MauiAppFontMonospace) |
| IsPassword cannot be set dynamically for numeric keyboard | dotnet/maui/issues/12332 | Low | [MauiAppSfTextInputLayout](MauiAppSfTextInputLayout) |
| Issue with Babel 10.x and merging of resources assemblies | | Low | [MauiAppBabel10MergeResources](MauiAppBabel10MergeResources) |
| flurl.http trimmer issue in 4.0.0-pre5 | tmenier/Flurl/issues/772 | Low | [MauiAppFlurlHttpTrimmerIssue](MauiAppFlurlHttpTrimmerIssue) |

### Severity

- critical: must be resolved immediately, as it renders the app unusable until it is resolved.
- high: must be resolved at the earliest, as it degrades user experience and there is no workaround.
- medium: can be fixed in the normal course of development and testing.
- low:  can be fixed at a later date (more serious bugs take priority).
