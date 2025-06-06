using WaterIntakeTracker.Models;

namespace WaterIntakeTracker.Services;

public class WaterIntakeService
{
    private readonly WaterIntakeModel _model = new();
    
    public event Action? OnStateChanged;

    public WaterIntakeModel GetModel() => _model;

    public void AddGlass()
    {
        _model.AddGlass();
        OnStateChanged?.Invoke();
    }

    public void RemoveGlass()
    {
        _model.RemoveGlass();
        OnStateChanged?.Invoke();
    }

    public void Reset()
    {
        _model.Reset();
        OnStateChanged?.Invoke();
    }
}