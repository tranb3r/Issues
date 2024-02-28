@echo off

SETLOCAL

set Z_TargetFramework=net8.0-ios17.2
set Z_Configuration=Release
set Z_RuntimeIdentifier=ios-arm64
set Z_Platform=iPhone
set Z_DotNetRootRemoteDirectory=/Users/%Z_MacServerUser%/Library/Caches/Xamarin/XMA/SDKs/dotnet/
set Z_ProjectName=MauiAppIOsBuildIssue

echo -- INIT ----------------------------------------------------------------------------------------------------------------------------------------------------
echo TargetFramework: %Z_TargetFramework%
echo Configuration: %Z_Configuration%
echo RuntimeIdentifier: %Z_RuntimeIdentifier%
echo Platform: %Z_Platform%
echo MacServerAddress: %Z_MacServerAddress%
echo MacServerUser: %Z_MacServerUser%
echo DotNetRootRemoteDirectory: %Z_DotNetRootRemoteDirectory%

echo -- GET VERSION ---------------------------------------------------------------------------------------------------------------------------------------------
set /p Z_Version=<..\version.txt
for /f "tokens=1,2 delims=-" %%i in ("%Z_Version%") do set "Z_VersionName=%%i" &set "Z_VersionCode=%%j"
echo Version: %Z_VersionName% - %Z_VersionCode%

echo -- CLEAN ---------------------------------------------------------------------------------------------------------------------------------------------------
dotnet clean -v m ../%Z_ProjectName%/%Z_ProjectName%.csproj -c %Z_Configuration% -p:Platform=%Z_Platform% -p:ServerAddress=%Z_MacServerAddress% -p:ServerUser=%Z_MacServerUser%

echo -- BUILD ---------------------------------------------------------------------------------------------------------------------------------------------------
dotnet build -bl -v m ../%Z_ProjectName%/%Z_ProjectName%.csproj -c %Z_Configuration% -f %Z_TargetFramework% -r %Z_RuntimeIdentifier% --self-contained -p:Platform=%Z_Platform% -p:ArchiveOnBuild=true -p:ApplicationDisplayVersion=%Z_VersionName% -p:ApplicationVersion=%Z_VersionCode% -p:ServerAddress=%Z_MacServerAddress% -p:ServerUser=%Z_MacServerUser% -p:_DotNetRootRemoteDirectory=%Z_DotNetRootRemoteDirectory%

echo -- DONE !! -------------------------------------------------------------------------------------------------------------------------------------------------
ENDLOCAL
