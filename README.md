# HydroVibe 💧

> A smart .NET MAUI app concept for hydration tracking - currently in early development.

## Current Status

This repository contains a foundational .NET MAUI application that will evolve into **HydroVibe**, a comprehensive hydration tracking solution. The current implementation is a basic MAUI app structure, with the full HydroVibe features planned for future development.

## Vision: HydroVibe App Concept

HydroVibe will be a cross-platform mobile application designed to help users maintain optimal hydration levels through intelligent tracking, personalized reminders, and comprehensive analytics.

### Planned Key Features

🚰 **Smart Water Logging**
- One-tap quick-add buttons for common volumes
- Custom container support with personalized volumes
- Visual progress tracking with animated indicators
- Undo functionality for easy corrections

📊 **Comprehensive Analytics** 
- Weekly and monthly hydration trends
- Achievement system with unlockable badges
- Personal statistics and progress insights
- Goal achievement tracking

⏰ **Intelligent Reminders**
- Adaptive notification scheduling based on your habits
- Weather and activity-aware reminder frequency
- Customizable quiet hours and notification styles
- Non-intrusive, gentle nudges to stay hydrated

🎯 **Personalized Experience**
- Individual goals calculated from body weight and activity level
- Machine learning-powered habit recognition
- Custom container library with your favorite bottles and cups
- Dark/light theme support with accessibility features

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

## Development

### For Developers
```bash
# Clone the repository
git clone https://github.com/mattleibow/vibe-code.git

# Navigate to project directory
cd vibe-code

# Navigate to the app directory
cd VibeCodeApp

# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Run on Android
dotnet build -t:Run -f net8.0-android
```

## Documentation

Comprehensive concept documentation is available in the [docs](./docs/) folder:

- **[App Concept](./docs/app-concept.md)**: Detailed feature overview and user personas
- **[Technical Specifications](./docs/technical-specs.md)**: Architecture, data models, and implementation plans  
- **[User Guide](./docs/user-guide.md)**: Planned user experience and feature guide

## Roadmap

### Phase 1: Foundation (In Progress)
- [x] Basic .NET MAUI project structure
- [x] Cross-platform build configuration
- [ ] Core water logging functionality
- [ ] Basic progress tracking and goals
- [ ] Simple reminder system
- [ ] Cross-platform UI implementation

### Phase 2: Intelligence (Planned)
- [ ] Advanced analytics and trend analysis
- [ ] Machine learning-powered habit insights
- [ ] Weather integration for smart suggestions
- [ ] Achievement system and gamification

### Phase 3: Integration (Future)
- [ ] Health app synchronization (Apple Health, Google Fit)
- [ ] Wearable device support (Apple Watch, Wear OS)
- [ ] Social features and family sharing
- [ ] Advanced ML-powered personalization

## CI/CD

The project includes a GitHub Actions workflow that automatically builds the Android APK on push and pull requests to the main branch.

## Contributing

We welcome contributions! Please see our [Contributing Guidelines](CONTRIBUTING.md) for details on:

- Code standards and style guidelines
- Pull request process
- Issue reporting
- Development setup

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

**Building the future of hydration tracking with .NET MAUI** 💧

Made with ❤️ using .NET MAUI
