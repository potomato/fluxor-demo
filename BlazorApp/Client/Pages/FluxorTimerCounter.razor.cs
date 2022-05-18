using Microsoft.AspNetCore.Components;
using Fluxor;
using Fluxor.Blazor.Web.Components;
using BlazorApp.Client.Store.TimerCounter;
using BlazorApp.Client.Store.TimerCounter.Actions;

namespace BlazorApp.Client.Pages;

public partial class FluxorTimerCounter : FluxorComponent
{
    [Inject]
    private IState<TimerCounterState> State { get; init; }

    [Inject]
    private IDispatcher Dispatcher { get; init; }

    private void StartCounting()
    {
        Dispatcher.Dispatch(new StartCountingAction());
    }

    private void StopCounting()
    {
        Dispatcher.Dispatch(new StopCountingAction());
    }
}