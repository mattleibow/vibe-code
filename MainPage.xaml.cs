using Microsoft.Maui.Controls;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WaterIntakeApp;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
    private const int GLASS_SIZE_ML = 250;
    private const int DAILY_GOAL_ML = 2000; // 8 glasses
    private const int MAX_GLASSES = 12;
    
    private int _currentIntake = 0;
    private int _glassCount = 0;
    private double _waterHeight = 0;
    private double _dropOpacity = 0.5;

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
        
        // Initialize the date
        CurrentDate = DateTime.Now.ToString("MMMM dd, yyyy");
        
        // Update the UI
        UpdateUI();
        
        // Start drop animation
        StartDropAnimation();
    }

    #region Properties for Data Binding

    public string CurrentDate { get; set; }

    public string ProgressText => $"{_currentIntake}ml / {DAILY_GOAL_ML}ml";

    public string GoalText => $"Goal: {DAILY_GOAL_ML / GLASS_SIZE_ML} glasses ({DAILY_GOAL_ML}ml)";

    public string PercentageText => $"{Math.Round(ProgressValue * 100)}%";

    public double ProgressValue => Math.Min((double)_currentIntake / DAILY_GOAL_ML, 1.0);

    public double WaterHeight => Math.Min(280 * ProgressValue, 280);

    public double DropOpacity => _dropOpacity;

    public string CurrentIntakeText => $"{_currentIntake}ml";

    public string GlassCountText => $"{_glassCount} glasses";

    public bool CanRemoveGlass => _glassCount > 0;

    public string MotivationText
    {
        get
        {
            var percentage = ProgressValue * 100;
            return percentage switch
            {
                >= 100 => "🎉 Amazing! You've reached your daily goal! Keep up the great work!",
                >= 75 => "🌟 Fantastic! You're almost there! Just a little more to go!",
                >= 50 => "💪 Great progress! You're halfway to your goal!",
                >= 25 => "👍 Good start! Keep drinking to stay hydrated!",
                _ => "🚀 Time to start hydrating! Your body will thank you!"
            };
        }
    }

    #endregion

    #region Event Handlers

    private async void OnAddGlassClicked(object sender, EventArgs e)
    {
        if (_glassCount >= MAX_GLASSES)
        {
            await DisplayAlert("Limit Reached", 
                "You've reached the maximum daily limit of 12 glasses. Great job staying hydrated!", 
                "OK");
            return;
        }

        // Add glass with cool animation
        _currentIntake += GLASS_SIZE_ML;
        _glassCount++;
        
        // Animate the button press
        await AnimateButtonPress(AddGlassButton);
        
        // Animate water drop
        await AnimateWaterDrop();
        
        // Update UI
        UpdateUI();
        UpdateGlassesIndicator();
        
        // Check if goal is reached
        if (_currentIntake >= DAILY_GOAL_ML && (_currentIntake - GLASS_SIZE_ML) < DAILY_GOAL_ML)
        {
            await CelebrateGoalReached();
        }
    }

    private async void OnRemoveGlassClicked(object sender, EventArgs e)
    {
        if (_glassCount <= 0) return;

        bool confirm = await DisplayAlert("Remove Glass", 
            "Are you sure you want to remove a glass from your intake?", 
            "Yes", "No");
            
        if (!confirm) return;

        // Remove glass with animation
        _currentIntake = Math.Max(0, _currentIntake - GLASS_SIZE_ML);
        _glassCount = Math.Max(0, _glassCount - 1);
        
        // Animate the button press
        await AnimateButtonPress(RemoveGlassButton);
        
        // Update UI
        UpdateUI();
        UpdateGlassesIndicator();
    }

    #endregion

    #region UI Updates

    private void UpdateUI()
    {
        // Update all binding properties
        OnPropertyChanged(nameof(ProgressText));
        OnPropertyChanged(nameof(GoalText));
        OnPropertyChanged(nameof(PercentageText));
        OnPropertyChanged(nameof(ProgressValue));
        OnPropertyChanged(nameof(WaterHeight));
        OnPropertyChanged(nameof(CurrentIntakeText));
        OnPropertyChanged(nameof(GlassCountText));
        OnPropertyChanged(nameof(CanRemoveGlass));
        OnPropertyChanged(nameof(MotivationText));
        
        // Animate water level change
        AnimateWaterLevel();
    }

    private void UpdateGlassesIndicator()
    {
        GlassesIndicator.Children.Clear();
        
        for (int i = 0; i < Math.Min(_glassCount, 8); i++)
        {
            var glassIcon = new Label
            {
                Text = "🥤",
                FontSize = 20,
                VerticalOptions = LayoutOptions.Center
            };
            GlassesIndicator.Children.Add(glassIcon);
        }
        
        // Show count if more than 8 glasses
        if (_glassCount > 8)
        {
            var countLabel = new Label
            {
                Text = $"+{_glassCount - 8}",
                FontSize = 16,
                FontAttributes = FontAttributes.Bold,
                TextColor = Colors.Blue,
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(5, 0, 0, 0)
            };
            GlassesIndicator.Children.Add(countLabel);
        }
    }

    #endregion

    #region Animations

    private async void StartDropAnimation()
    {
        while (true)
        {
            // Fade in
            _dropOpacity = 0.3;
            OnPropertyChanged(nameof(DropOpacity));
            await Task.Delay(1000);
            
            // Fade out
            _dropOpacity = 0.8;
            OnPropertyChanged(nameof(DropOpacity));
            await Task.Delay(1000);
        }
    }

    private async Task AnimateWaterLevel()
    {
        // Smooth water level animation
        if (WaterFill != null)
        {
            await WaterFill.FadeTo(0.7, 250);
            await WaterFill.FadeTo(1.0, 250);
        }
    }

    private async Task AnimateWaterDrop()
    {
        if (WaterDropIcon != null)
        {
            // Create a falling water drop effect
            await WaterDropIcon.ScaleTo(1.3, 150);
            await WaterDropIcon.FadeTo(1.0, 100);
            await WaterDropIcon.ScaleTo(1.0, 150);
            await WaterDropIcon.FadeTo(0.5, 200);
        }
    }

    private async Task AnimateButtonPress(Button button)
    {
        // Cool button press animation
        await button.ScaleTo(0.95, 100);
        await button.ScaleTo(1.05, 100);
        await button.ScaleTo(1.0, 100);
    }

    private async Task CelebrateGoalReached()
    {
        // Epic celebration animation
        var celebration = new Label
        {
            Text = "🎉 GOAL REACHED! 🎉",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            TextColor = Colors.Gold,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            Opacity = 0
        };

        // Add celebration to the main grid temporarily
        var mainGrid = (Grid)Content;
        if (mainGrid != null)
        {
            mainGrid.Children.Add(celebration);
            
            // Animate celebration
            await celebration.FadeTo(1, 300);
            await celebration.ScaleTo(1.2, 200);
            await celebration.ScaleTo(1.0, 200);
            await Task.Delay(2000);
            await celebration.FadeTo(0, 300);
            
            // Remove celebration
            mainGrid.Children.Remove(celebration);
        }

        // Show congratulations alert
        await DisplayAlert("Congratulations! 🎉", 
            "You've reached your daily water intake goal! Your boss will be impressed with your hydration dedication!", 
            "Awesome!");
    }

    #endregion

    #region INotifyPropertyChanged Implementation

    public new event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}