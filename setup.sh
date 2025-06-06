#!/bin/bash

# Water Intake Tracker - MAUI Setup Script
echo "🚀 Setting up Water Intake Tracker (.NET MAUI App)"
echo "=================================================="

# Check if .NET is installed
if ! command -v dotnet &> /dev/null; then
    echo "❌ .NET SDK is not installed. Please install .NET 8.0 SDK first."
    echo "   Download from: https://dotnet.microsoft.com/download"
    exit 1
fi

echo "✅ .NET SDK found: $(dotnet --version)"

# Install MAUI workload
echo "📦 Installing .NET MAUI workload..."
if dotnet workload install maui; then
    echo "✅ MAUI workload installed successfully"
else
    echo "❌ Failed to install MAUI workload"
    echo "   Please check your internet connection and try again"
    echo "   Or follow the manual setup guide: https://learn.microsoft.com/en-us/dotnet/maui/get-started/first-app"
    
    # Offer alternative for environments without MAUI
    echo ""
    echo "🔄 Alternative: Using simplified project configuration..."
    if [ -f "WaterIntakeTracker/WaterIntakeTracker-Full.csproj" ]; then
        cp WaterIntakeTracker/WaterIntakeTracker-Full.csproj WaterIntakeTracker/WaterIntakeTracker.csproj
        echo "✅ Project file updated for full MAUI support"
    fi
fi

# Navigate to project directory
cd WaterIntakeTracker

# Restore dependencies
echo "📚 Restoring project dependencies..."
if dotnet restore; then
    echo "✅ Dependencies restored successfully"
else
    echo "❌ Failed to restore dependencies"
    exit 1
fi

# Try to build the project
echo "🔨 Building the project..."
if dotnet build; then
    echo "✅ Project built successfully!"
    echo ""
    echo "🎉 Setup complete! Your Water Intake Tracker is ready!"
    echo ""
    echo "To run the app:"
    echo "  • For Android: dotnet run --framework net8.0-android"
    echo "  • For iOS: dotnet run --framework net8.0-ios"
    echo "  • For Windows: dotnet run --framework net8.0-windows10.0.19041.0"
    echo ""
    echo "💧 Stay hydrated! 💧"
else
    echo "❌ Build failed. This might be due to missing MAUI workloads in your environment."
    echo ""
    echo "📋 Manual setup instructions:"
    echo "1. Install Visual Studio 2022 with .NET MAUI workload"
    echo "2. Or follow the guide: https://learn.microsoft.com/en-us/dotnet/maui/get-started/first-app"
    echo "3. Run 'dotnet workload install maui' in a terminal"
    echo "4. Then run this script again"
fi