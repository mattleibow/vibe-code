namespace WaterIntakeTracker;

public partial class MainPage : ContentPage
{
    private int _glassesConsumed = 0;
    private const int DailyGoal = 8;
    private readonly string[] _motivationalMessages = 
    {
        "Great start! Keep it up! 💪",
        "You're doing amazing! 🌟",
        "Halfway there! Don't stop now! 🚀",
        "Almost at your goal! 🎯",
        "So close! One more push! 💯",
        "Fantastic! You're a hydration hero! 🦸‍♀️",
        "Incredible dedication! 🏆",
        "You're on fire! Keep going! 🔥"
    };

    public MainPage()
    {
        InitializeComponent();
        UpdateUI();
    }

    private void OnAddGlassClicked(object sender, EventArgs e)
    {
        if (_glassesConsumed < DailyGoal)
        {
            _glassesConsumed++;
            UpdateUI();
            
            // Add a subtle animation
            AnimateButton(AddGlassBtn);
            
            // Show achievement if goal reached
            if (_glassesConsumed == DailyGoal)
            {
                ShowAchievement();
            }
        }
    }

    private void OnRemoveGlassClicked(object sender, EventArgs e)
    {
        if (_glassesConsumed > 0)
        {
            _glassesConsumed--;
            UpdateUI();
            
            // Add a subtle animation
            AnimateButton(RemoveGlassBtn);
            
            // Hide achievement if no longer at goal
            if (_glassesConsumed < DailyGoal)
            {
                HideAchievement();
            }
        }
    }

    private void UpdateUI()
    {
        // Update progress label
        ProgressLabel.Text = $"{_glassesConsumed} / {DailyGoal} glasses completed";
        
        // Update progress bar
        double progress = (double)_glassesConsumed / DailyGoal;
        ProgressBar.Progress = progress;
        
        // Update percentage label
        PercentageLabel.Text = $"{(int)(progress * 100)}% Complete";
        
        // Update water level visual
        double waterHeight = progress * 194; // Max height minus margins
        WaterLevel.HeightRequest = waterHeight;
        
        // Update motivational message
        if (_glassesConsumed == 0)
        {
            MotivationLabel.Text = "Let's start hydrating! 💧";
        }
        else if (_glassesConsumed < DailyGoal)
        {
            int messageIndex = Math.Min(_glassesConsumed - 1, _motivationalMessages.Length - 1);
            MotivationLabel.Text = _motivationalMessages[messageIndex];
        }
        else
        {
            MotivationLabel.Text = "Goal achieved! You're a hydration champion! 🏅";
        }
        
        // Change water color based on progress
        if (progress >= 1.0)
        {
            WaterLevel.BackgroundColor = Color.FromArgb("#2196F3"); // Bright blue when complete
        }
        else if (progress >= 0.75)
        {
            WaterLevel.BackgroundColor = Color.FromArgb("#4FC3F7"); // Light blue
        }
        else if (progress >= 0.5)
        {
            WaterLevel.BackgroundColor = Color.FromArgb("#81D4FA"); // Very light blue
        }
        else
        {
            WaterLevel.BackgroundColor = Color.FromArgb("#B3E5FC"); // Pale blue
        }
    }

    private async void AnimateButton(Button button)
    {
        try
        {
            await button.ScaleTo(0.95, 100);
            await button.ScaleTo(1.0, 100);
        }
        catch
        {
            // Animation might fail in some environments, ignore
        }
    }

    private async void ShowAchievement()
    {
        try
        {
            AchievementFrame.IsVisible = true;
            AchievementFrame.Opacity = 0;
            await AchievementFrame.FadeTo(1, 500);
            
            // Scale animation for extra effect
            await AchievementFrame.ScaleTo(1.05, 200);
            await AchievementFrame.ScaleTo(1.0, 200);
        }
        catch
        {
            // Animation might fail in some environments, just show the frame
            AchievementFrame.IsVisible = true;
            AchievementFrame.Opacity = 1;
        }
    }

    private async void HideAchievement()
    {
        try
        {
            await AchievementFrame.FadeTo(0, 300);
            AchievementFrame.IsVisible = false;
        }
        catch
        {
            // Animation might fail in some environments, just hide the frame
            AchievementFrame.IsVisible = false;
        }
    }
}