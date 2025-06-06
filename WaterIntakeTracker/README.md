# 💧 Water Intake Tracker

A cool and modern water intake tracking app built with Blazor Server that helps you stay hydrated throughout the day!

## Features

### 🎯 Core Functionality
- **Cool Circular Progress Bar** - Visually stunning progress visualization showing your daily water intake
- **Add Glass Button** - Easy one-click button to add a glass of water (250ml)
- **Undo Button** - Remove the last glass if you made a mistake
- **Reset Day Button** - Start fresh with a new day
- **Daily Goal Tracking** - Default goal of 8 glasses (2000ml) per day

### 🎨 Impressive UI Design
- **Modern Gradient Background** - Eye-catching purple-blue gradient
- **Animated Progress Circle** - Smooth animated SVG progress indicator
- **Glass-morphism Design** - Modern translucent buttons with backdrop blur effects
- **Responsive Layout** - Works beautifully on desktop and mobile devices
- **Celebratory Animations** - Special effects when daily goal is reached
- **Real-time Stats** - Live tracking of consumed, remaining, and goal amounts

### 📊 Smart Features
- **Progress Percentage** - Shows exact percentage of daily goal completed
- **Milliliter Tracking** - Tracks both glasses and milliliters consumed
- **Goal Achievement** - Celebrates when you reach your daily hydration goal
- **Safety Limits** - Prevents excessive intake (max 20 glasses per day)

## Technical Architecture

### 🏗️ Project Structure
```
WaterIntakeTracker/
├── Models/
│   └── WaterIntakeModel.cs      # Core data model
├── Services/
│   └── WaterIntakeService.cs    # State management service
├── Components/
│   └── Pages/
│       └── Home.razor           # Main UI component
├── wwwroot/
│   └── water-tracker.css       # Custom styles
└── Program.cs                   # Service registration
```

### 🧪 Testing
- Comprehensive unit tests for core functionality
- Tests cover all user scenarios and edge cases
- Validates business logic and state management

## Getting Started

### Prerequisites
- .NET 8.0 SDK or later

### Running the Application
1. Navigate to the project directory:
   ```bash
   cd WaterIntakeTracker
   ```

2. Run the application:
   ```bash
   dotnet run
   ```

3. Open your browser and navigate to `http://localhost:5135`

### Running Tests
```bash
cd WaterIntakeTracker.Tests
dotnet test
```

## Usage

1. **Track Your Intake**: Click the "Add Glass" button each time you drink a glass of water
2. **Monitor Progress**: Watch the beautiful circular progress bar fill up as you get closer to your goal
3. **Fix Mistakes**: Use the "Undo" button if you accidentally added a glass
4. **Daily Reset**: Click "Reset Day" to start tracking fresh for a new day
5. **Celebrate Success**: Enjoy the celebration animation when you reach your daily goal!

## Design Philosophy

This app was designed with the goal of creating an impressive, professional-looking interface that would make any boss proud! The modern glass-morphism design, smooth animations, and intuitive user experience combine to create a tool that's both functional and visually stunning.

The circular progress visualization provides immediate visual feedback on hydration progress, while the carefully chosen color scheme and typography create a premium feel that sets this app apart from basic water tracking tools.

## Future Enhancements

Potential features for future versions:
- Customizable daily goals
- Historical tracking and charts
- Reminder notifications
- Multiple drink types support
- Personal hydration insights
- Social sharing features

---

*Stay hydrated and impress your boss! 💧✨*