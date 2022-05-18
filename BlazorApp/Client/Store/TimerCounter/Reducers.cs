using Fluxor;
using BlazorApp.Client.Store.TimerCounter.Actions;

namespace BlazorApp.Client.Store.TimerCounter;

public class Reducers
{
    [ReducerMethod]
    public static TimerCounterState Reduce(TimerCounterState state, IncrementCountAction _)
    {
        return state with { CounterValue = state.CounterValue + 1 };
    }


    [ReducerMethod]
    public static TimerCounterState Reduce(TimerCounterState state, StartCountingAction _)
    {
        return state with { IsCounting = true };
    }


    [ReducerMethod]
    public static TimerCounterState Reduce(TimerCounterState state, StopCountingAction _)
    {
        return state with { IsCounting = false };
    }
}
