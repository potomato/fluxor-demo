using Fluxor;

namespace BlazorApp.Client.Store.Counter;

public class Reducers
{
    [ReducerMethod]
    public static CounterState Reduce(CounterState state, IncrementCountAction _)
    {
        return state with 
            { CounterValue = state.CounterValue + 1 };
    }
}
