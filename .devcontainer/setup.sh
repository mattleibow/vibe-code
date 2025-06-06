#!/bin/bash
# .devcontainer/setup.sh
# Post-create setup script for the .NET MAUI development environment

set -e

echo "🚀 Setting up .NET MAUI development environment..."

# Verify .NET SDK
echo "✅ Verifying .NET SDK installation..."
dotnet --version
dotnet --list-sdks

# Install MAUI Android workload
echo "✅ Installing MAUI Android workload..."
dotnet workload install maui-android --skip-sign-check

# List installed workloads
echo "✅ Installed workloads:"
dotnet workload list

# Restore project dependencies
echo "✅ Restoring project dependencies..."
if [ -f "VibeCodeApp/VibeCodeApp.csproj" ]; then
    dotnet restore VibeCodeApp/VibeCodeApp.csproj
    echo "Dependencies restored successfully."
else
    echo "⚠️  VibeCodeApp.csproj not found - skipping dependency restore"
fi

# Test build to verify setup
echo "✅ Testing project build..."
if [ -f "VibeCodeApp/VibeCodeApp.csproj" ]; then
    dotnet build VibeCodeApp/VibeCodeApp.csproj --no-restore --configuration Release --verbosity minimal
    echo "Build test completed successfully."
else
    echo "⚠️  VibeCodeApp.csproj not found - skipping build test"
fi

echo ""
echo "🎉 .NET MAUI development environment setup complete!"
echo "✨ GitHub Copilot can now work with a fully configured environment."
echo ""
echo "The environment includes:"
echo "  - .NET 9.0 SDK"
echo "  - MAUI Android workload"
echo "  - Project dependencies restored"
echo "  - Build verification completed"
echo ""
echo "You can now use GitHub Copilot with full access to .NET MAUI development tools!"