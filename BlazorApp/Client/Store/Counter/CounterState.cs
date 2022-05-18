using Fluxor;

namespace BlazorApp.Client.Store.Counter;

[FeatureState]
public record CounterState
{
    public CounterState(int counterValue)
    {
        CounterValue = counterValue;
    }

    private CounterState()
    {
    }

    public int CounterValue { get; init; }
}
