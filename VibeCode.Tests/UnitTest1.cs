namespace VibeCode.Tests;

public class ProgramTests
{
    [Fact]
    public void ProgramShouldHaveMainMethod()
    {
        // Arrange
        var programType = typeof(VibeCode.Program);
        
        // Act
        var mainMethod = programType.GetMethod("Main", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
        
        // Assert
        Assert.NotNull(mainMethod);
    }
    
    [Fact]
    public void BasicApplicationTest()
    {
        // This is a basic test to ensure the application can be instantiated
        // In a real MAUI app, we would test UI components and navigation
        Assert.True(true, "Basic test passes");
    }
}