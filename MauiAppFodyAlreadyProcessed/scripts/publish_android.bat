@echo off
dotnet clean -v m ../MauiAppFodyAlreadyProcessed.Maui/MauiAppFodyAlreadyProcessed.Maui.csproj -c Release
dotnet build -bl -v m ../MauiAppFodyAlreadyProcessed.Maui/MauiAppFodyAlreadyProcessed.Maui.csproj -c Release -f net7.0-android33.0 -r android-arm64 --self-contained
