@echo off

set Z_TargetFramework=net7.0-android33.0
set Z_Configuration=Release
set Z_RuntimeIdentifier=android-arm64

echo -- INIT ----------------------------------------------------------------------------------------------------------------------------------------------------
echo TargetFramework: %Z_TargetFramework%
echo Configuration: %Z_Configuration%
echo RuntimeIdentifier: %Z_RuntimeIdentifier%

echo -- CLEAN ---------------------------------------------------------------------------------------------------------------------------------------------------
dotnet clean -v m ../MauiAppBabel10MergeResources/MauiAppBabel10MergeResources.csproj -c %Z_Configuration%

echo -- BUILD ---------------------------------------------------------------------------------------------------------------------------------------------------
dotnet build -bl -v m ../MauiAppBabel10MergeResources/MauiAppBabel10MergeResources.csproj -c %Z_Configuration% -f %Z_TargetFramework% -r %Z_RuntimeIdentifier% --self-contained

echo -- DONE !! -------------------------------------------------------------------------------------------------------------------------------------------------
