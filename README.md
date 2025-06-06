# vibe-code

A .NET MAUI application for Android built with .NET 9.0.

## Development with GitHub Copilot

This repository includes a **development container** configuration that provides a pre-configured environment for GitHub Copilot. This setup addresses firewall access issues and ensures Copilot has access to all necessary .NET MAUI development tools.

### Quick Start with Codespaces
1. Click **Code** → **Codespaces** → **Create codespace**
2. The environment will automatically configure with .NET 9.0 and MAUI Android workload
3. GitHub Copilot will have full access to the development tools

### Local Development with Dev Containers
1. Install the **Dev Containers** extension in VS Code
2. Open this repository in VS Code
3. Press `Ctrl+Shift+P` and run **Dev Containers: Reopen in Container**
4. The container will build and configure automatically

For more details, see [`.devcontainer/README.md`](.devcontainer/README.md).

## Prerequisites (Local Setup)

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

## Environment Validation

Run the validation script to check if your environment is properly configured:

```bash
./validate-copilot-setup.sh
```

## CI/CD

The project includes a GitHub Actions workflow that automatically builds the Android APK on push and pull requests to the main branch.