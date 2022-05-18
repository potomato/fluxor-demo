using Fluxor;

namespace BlazorApp.Client.Store.TimerCounter;

[FeatureState]
public record TimerCounterState
{
    public TimerCounterState(int counterValue, bool isCounting)
    {
        CounterValue = counterValue;
        IsCounting = isCounting;
    }

    private TimerCounterState()
    {
    }

    public int CounterValue { get; init; }

    public bool IsCounting { get; init; }
}
