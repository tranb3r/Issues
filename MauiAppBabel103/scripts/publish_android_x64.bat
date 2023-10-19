@echo off

set Z_TargetFramework=net8.0-android34.0
set Z_Configuration=Release
set Z_RuntimeIdentifier=android-x64
set Z_AndroidSdkDirectory=D:\android\sdk
set Z_ProjectName=MauiAppBabel103

echo -- INIT ----------------------------------------------------------------------------------------------------------------------------------------------------
echo TargetFramework: %Z_TargetFramework%
echo Configuration: %Z_Configuration%
echo RuntimeIdentifier: %Z_RuntimeIdentifier%
echo AndroidSdkDirectory: %Z_AndroidSdkDirectory%

echo -- CLEAN ---------------------------------------------------------------------------------------------------------------------------------------------------
dotnet clean -v m ../%Z_ProjectName%/%Z_ProjectName%.csproj -c %Z_Configuration%

echo -- BUILD, SIGN, ZIPALIGN------------------------------------------------------------------------------------------------------------------------------------
dotnet build -bl -v m ../%Z_ProjectName%/%Z_ProjectName%.csproj -c %Z_Configuration% -f %Z_TargetFramework% -r %Z_RuntimeIdentifier% --self-contained -p:AndroidSdkDirectory=%Z_AndroidSdkDirectory%
