# 💧 Water Intake Tracker

A beautiful .NET MAUI app to help you track your daily water intake and stay hydrated!

## ✨ Features

- **Cool Progress Visualization**: Watch your water bottle fill up as you drink!
- **Daily Goal Tracking**: Set and achieve your 8-glass daily hydration goal
- **Add Glass Button**: Easily log each glass of water you drink
- **Remove Glass Button**: Undo mistakes with the remove function
- **Achievement System**: Celebrate when you reach your daily goal
- **Beautiful UI**: Impressive water-themed design with smooth animations
- **Motivational Messages**: Stay encouraged with progress-based messages

## 🚀 Getting Started

### Prerequisites

To build and run this .NET MAUI app, you need:

1. **Visual Studio 2022** (Windows) or **Visual Studio for Mac** with .NET MAUI workload
2. **.NET 8.0 SDK** or later
3. **MAUI Workload** installed

### Installation Steps

1. **Install .NET MAUI Workload:**
   ```bash
   dotnet workload install maui
   ```

2. **Clone the repository:**
   ```bash
   git clone https://github.com/mattleibow/vibe-code.git
   cd vibe-code/WaterIntakeTracker
   ```

3. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

4. **Build the project:**
   ```bash
   dotnet build
   ```

5. **Run the app:**
   ```bash
   # For Android
   dotnet run --framework net8.0-android

   # For iOS (requires Mac)
   dotnet run --framework net8.0-ios

   # For Windows
   dotnet run --framework net8.0-windows10.0.19041.0
   ```

### Alternative Setup

If you encounter issues with workloads, follow the official Microsoft documentation:
- [.NET MAUI Installation Guide](https://learn.microsoft.com/en-us/dotnet/maui/get-started/first-app?view=net-maui-9.0&tabs=vswin&pivots=devices-android)

## 📱 How to Use

1. **Track Your Progress**: The main screen shows your current water intake with a beautiful bottle visualization
2. **Add Water**: Tap the "➕ Add Glass" button each time you drink a glass of water
3. **Fix Mistakes**: Use the "➖ Remove" button if you accidentally logged extra glasses
4. **Reach Your Goal**: Watch the motivational messages and celebrate when you hit 8 glasses!
5. **Stay Motivated**: The app provides encouraging messages throughout your day

## 🎨 UI Features

- **Water Bottle Animation**: Visual representation that fills as you drink
- **Progress Bar**: Standard progress indicator showing percentage complete
- **Achievement Banner**: Special celebration when you reach your goal
- **Motivational Messages**: Context-aware encouragement
- **Beautiful Colors**: Water-themed blue gradient design
- **Smooth Animations**: Button press feedback and achievement animations

## 🏗️ Project Structure

```
WaterIntakeTracker/
├── WaterIntakeTracker.csproj     # Project configuration
├── MauiProgram.cs                # App initialization
├── App.xaml/.cs                  # Application entry point
├── AppShell.xaml/.cs             # Navigation shell
├── MainPage.xaml/.cs             # Main water tracking page
├── Resources/
│   ├── Styles/                   # App styling and colors
│   ├── AppIcon/                  # App icon resources
│   ├── Splash/                   # Splash screen
│   └── Images/                   # Additional images
└── Platforms/                    # Platform-specific code
    ├── Android/
    ├── iOS/
    ├── MacCatalyst/
    └── Windows/
```

## 🔧 Development Notes

- Built with **.NET MAUI** for cross-platform compatibility
- Uses **XAML** for beautiful, declarative UI design
- Implements **MVVM patterns** with code-behind for simplicity
- **Water-themed color scheme** throughout the app
- **Responsive design** that works on phones and tablets

## 🎯 Daily Goal

The app is designed around the standard recommendation of **8 glasses of water per day** (approximately 2 liters). This goal is perfect for most adults to maintain proper hydration.

## 🤝 Contributing

Feel free to contribute to make this water intake tracker even better! Whether it's bug fixes, new features, or UI improvements, all contributions are welcome.

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](../LICENSE) file for details.

---

Stay hydrated! 💧💪