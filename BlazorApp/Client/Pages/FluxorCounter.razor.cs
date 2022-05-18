using Microsoft.AspNetCore.Components;
using Fluxor;
using Fluxor.Blazor.Web.Components;
using BlazorApp.Client.Store.Counter;

namespace BlazorApp.Client.Pages;

public partial class FluxorCounter : FluxorComponent
{
    [Inject]
    private IState<CounterState> State { get; init; }

    [Inject]
    private IDispatcher Dispatcher { get; init; }

    private void IncrementCount()
    {
        Dispatcher.Dispatch(new IncrementCountAction());
    }
}