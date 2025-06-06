#!/bin/bash
# validate-copilot-setup.sh
# Simple script to validate that the Copilot setup environment is working correctly

set -e  # Exit on any error

echo "🔍 Validating Copilot Setup Environment..."
echo "=========================================="

# Check .NET SDK
echo "✅ Checking .NET SDK..."
if ! command -v dotnet &> /dev/null; then
    echo "❌ dotnet command not found"
    exit 1
fi

DOTNET_VERSION=$(dotnet --version)
echo "   Found .NET SDK version: $DOTNET_VERSION"

if [[ ! "$DOTNET_VERSION" =~ ^9\.0\. ]]; then
    echo "❌ Expected .NET 9.0.x, found $DOTNET_VERSION"
    exit 1
fi

# Check MAUI workload
echo "✅ Checking MAUI Android workload..."
if ! dotnet workload list | grep -q "maui-android"; then
    echo "❌ MAUI Android workload not installed"
    exit 1
fi
echo "   MAUI Android workload is installed"

# Check project restore
echo "✅ Checking project restore..."
if [ ! -f "VibeCodeApp/VibeCodeApp.csproj" ]; then
    echo "❌ VibeCodeApp.csproj not found"
    exit 1
fi

cd VibeCodeApp
if ! dotnet restore --verbosity quiet; then
    echo "❌ Project restore failed"
    exit 1
fi
echo "   Project restored successfully"

# Check project build
echo "✅ Checking project build..."
if ! dotnet build --no-restore --configuration Release --verbosity quiet; then
    echo "❌ Project build failed"
    exit 1
fi
echo "   Project built successfully"

echo ""
echo "🎉 All validation checks passed!"
echo "✨ The Copilot setup environment is ready for development."