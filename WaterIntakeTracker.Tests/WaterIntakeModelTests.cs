using WaterIntakeTracker.Models;
using Xunit;

namespace WaterIntakeTracker.Tests;

public class WaterIntakeModelTests
{
    [Fact]
    public void InitialState_ShouldBeZeroGlasses()
    {
        // Arrange & Act
        var model = new WaterIntakeModel();

        // Assert
        Assert.Equal(0, model.GlassesConsumed);
        Assert.Equal(0, model.TotalMilliliters);
        Assert.Equal(0.0, model.ProgressPercentage);
        Assert.False(model.IsGoalReached);
    }

    [Fact]
    public void AddGlass_ShouldIncreaseGlassCount()
    {
        // Arrange
        var model = new WaterIntakeModel();

        // Act
        model.AddGlass();

        // Assert
        Assert.Equal(1, model.GlassesConsumed);
        Assert.Equal(250, model.TotalMilliliters);
        Assert.Equal(12.5, model.ProgressPercentage);
        Assert.False(model.IsGoalReached);
    }

    [Fact]
    public void RemoveGlass_ShouldDecreaseGlassCount()
    {
        // Arrange
        var model = new WaterIntakeModel();
        model.AddGlass();
        model.AddGlass();

        // Act
        model.RemoveGlass();

        // Assert
        Assert.Equal(1, model.GlassesConsumed);
        Assert.Equal(250, model.TotalMilliliters);
    }

    [Fact]
    public void RemoveGlass_WhenZeroGlasses_ShouldStayAtZero()
    {
        // Arrange
        var model = new WaterIntakeModel();

        // Act
        model.RemoveGlass();

        // Assert
        Assert.Equal(0, model.GlassesConsumed);
    }

    [Fact]
    public void IsGoalReached_WhenEightGlasses_ShouldReturnTrue()
    {
        // Arrange
        var model = new WaterIntakeModel();

        // Act
        for (int i = 0; i < 8; i++)
        {
            model.AddGlass();
        }

        // Assert
        Assert.Equal(8, model.GlassesConsumed);
        Assert.Equal(2000, model.TotalMilliliters);
        Assert.Equal(100.0, model.ProgressPercentage);
        Assert.True(model.IsGoalReached);
    }

    [Fact]
    public void AddGlass_ShouldNotExceedTwentyGlasses()
    {
        // Arrange
        var model = new WaterIntakeModel();

        // Act
        for (int i = 0; i < 25; i++)
        {
            model.AddGlass();
        }

        // Assert
        Assert.Equal(20, model.GlassesConsumed);
    }

    [Fact]
    public void Reset_ShouldResetToZero()
    {
        // Arrange
        var model = new WaterIntakeModel();
        model.AddGlass();
        model.AddGlass();
        model.AddGlass();

        // Act
        model.Reset();

        // Assert
        Assert.Equal(0, model.GlassesConsumed);
        Assert.Equal(0, model.TotalMilliliters);
        Assert.Equal(0.0, model.ProgressPercentage);
        Assert.False(model.IsGoalReached);
    }
}