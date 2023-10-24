@echo off

set Z_TargetFramework=net7.0-android
set Z_Configuration=Release
set Z_RuntimeIdentifier=android-arm64
set Z_ProjectName=MauiAppFlurlHttpTrimmerIssue

echo -- INIT ----------------------------------------------------------------------------------------------------------------------------------------------------
echo TargetFramework: %Z_TargetFramework%
echo Configuration: %Z_Configuration%
echo RuntimeIdentifier: %Z_RuntimeIdentifier%
echo ProjectName: %Z_ProjectName%

echo -- CLEAN ---------------------------------------------------------------------------------------------------------------------------------------------------
dotnet clean -v m ../%Z_ProjectName%/%Z_ProjectName%.csproj -c %Z_Configuration%

echo -- BUILD ---------------------------------------------------------------------------------------------------------------------------------------------------
dotnet build -bl -v m ../%Z_ProjectName%/%Z_ProjectName%.csproj -c %Z_Configuration% -f %Z_TargetFramework% -r %Z_RuntimeIdentifier% --self-contained

echo -- DONE !! -------------------------------------------------------------------------------------------------------------------------------------------------
