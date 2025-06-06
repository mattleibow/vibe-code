# Converting to Full .NET MAUI Project

This project contains a complete .NET MAUI water intake tracker application structure. To convert it to a working MAUI app:

## Step 1: Install MAUI Workload

```bash
# Install .NET MAUI workload
dotnet workload install maui
```

## Step 2: Update Project File

Replace the content of `WaterIntakeApp.csproj` with:

```xml
<Project Sdk="Microsoft.NET.Sdk">

	<PropertyGroup>
		<TargetFrameworks>net8.0-android;net8.0-ios;net8.0-maccatalyst</TargetFrameworks>
		<TargetFrameworks Condition="$([MSBuild]::IsOSPlatform('windows'))">$(TargetFrameworks);net8.0-windows10.0.19041.0</TargetFrameworks>

		<OutputType>Exe</OutputType>
		<RootNamespace>WaterIntakeApp</RootNamespace>
		<UseMaui>true</UseMaui>
		<SingleProject>true</SingleProject>
		<ImplicitUsings>enable</ImplicitUsings>

		<!-- Display Version -->
		<ApplicationDisplayVersion>1.0</ApplicationDisplayVersion>
		<ApplicationVersion>1</ApplicationVersion>

		<SupportedOSPlatformVersion Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'android'">21.0</SupportedOSPlatformVersion>
		<SupportedOSPlatformVersion Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'ios'">11.0</SupportedOSPlatformVersion>
		<SupportedOSPlatformVersion Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'maccatalyst'">13.1</SupportedOSPlatformVersion>
		<SupportedOSPlatformVersion Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'windows'">10.0.17763.0</SupportedOSPlatformVersion>
		<TargetPlatformMinVersion Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'windows'">10.0.17763.0</TargetPlatformMinVersion>
	</PropertyGroup>

	<ItemGroup>
		<!-- App Icon -->
		<MauiIcon Include="Resources\AppIcon\appicon.svg" ForegroundFile="Resources\AppIcon\appiconfg.svg" Color="#1E88E5" />

		<!-- Splash Screen -->
		<MauiSplashScreen Include="Resources\Splash\splash.svg" Color="#1E88E5" BaseSize="128,128" />

		<!-- Images -->
		<MauiImage Include="Resources\Images\*" />

		<!-- Custom Fonts -->
		<MauiFont Include="Resources\Fonts\*" />

		<!-- Raw Assets -->
		<MauiAsset Include="Resources\Raw\**" LogicalName="%(RecursiveDir)%(Filename)%(Extension)" />
	</ItemGroup>

	<ItemGroup>
		<PackageReference Include="Microsoft.Maui.Controls" Version="8.0.90" />
		<PackageReference Include="Microsoft.Maui.Controls.Compatibility" Version="8.0.90" />
		<PackageReference Include="Microsoft.Extensions.Logging.Debug" Version="8.0.0" />
	</ItemGroup>

</Project>
```

## Step 3: Remove Temporary Files

Delete or rename these files that were created for the standalone demo:
- `Program.cs` (the demo console program)

## Step 4: Add Required Font

Download OpenSans-Regular.ttf from Google Fonts and place it in:
```
Resources/Fonts/OpenSans-Regular.ttf
```

## Step 5: Build and Run

```bash
# Restore packages
dotnet restore

# Build for Android
dotnet build -t:Run -f net8.0-android

# Build for iOS (macOS only)
dotnet build -t:Run -f net8.0-ios

# Build for Windows
dotnet build -t:Run -f net8.0-windows
```

## Platform-Specific Notes

### Android
- Minimum API level: 21 (Android 5.0)
- The app will request appropriate permissions automatically

### iOS
- Minimum iOS version: 11.0
- May require Apple Developer account for device deployment

### Windows
- Minimum Windows version: 10.0.17763.0
- Uses WinUI 3 for native Windows experience

### macOS (Catalyst)
- Minimum macOS version: 13.1
- Runs iOS app on macOS with catalyst

## Features Once Running

The app will provide:
- ✨ Animated water level progress
- 🥤 Tap to add glasses (250ml each)
- ❌ Remove glasses with confirmation
- 📊 Real-time statistics
- 🎯 Goal tracking (2000ml daily)
- 🎉 Celebration animations
- 💧 Beautiful water-themed UI

The impressive design and smooth animations will definitely impress your boss! 🌟