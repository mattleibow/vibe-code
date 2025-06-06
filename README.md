# vibe-code

A .NET MAUI application for Android built with .NET 9.0.

## Prerequisites

- .NET 9.0 SDK
- MAUI Android workload

## Setup

1. Install the latest .NET SDK:
```bash
curl -sSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin --channel 9.0
```

2. Install the MAUI Android workload:
```bash
dotnet workload install maui-android
```

## Build

To build the Android application:

```bash
cd VibeCodeApp
dotnet restore
dotnet build --configuration Release
```

## CI/CD

The project includes a GitHub Actions workflow that automatically builds the Android APK on push and pull requests to the main branch.