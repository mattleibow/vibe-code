namespace WaterIntakeTracker.Models;

public class WaterIntakeModel
{
    public int GlassesConsumed { get; set; } = 0;
    public int DailyGoalGlasses { get; set; } = 8;
    public int MillilitersPerGlass { get; set; } = 250;

    public int TotalMilliliters => GlassesConsumed * MillilitersPerGlass;
    public int DailyGoalMilliliters => DailyGoalGlasses * MillilitersPerGlass;
    public double ProgressPercentage => Math.Min(100.0, (double)GlassesConsumed / DailyGoalGlasses * 100.0);
    public bool IsGoalReached => GlassesConsumed >= DailyGoalGlasses;

    public void AddGlass()
    {
        if (GlassesConsumed < 20) // Reasonable daily limit
        {
            GlassesConsumed++;
        }
    }

    public void RemoveGlass()
    {
        if (GlassesConsumed > 0)
        {
            GlassesConsumed--;
        }
    }

    public void Reset()
    {
        GlassesConsumed = 0;
    }
}