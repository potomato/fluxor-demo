using BlazorApp.Client.Store.TimerCounter.Actions;
using Fluxor;

namespace BlazorApp.Client.Store.TimerCounter
{
    public class Effects
    {
        private readonly IState<TimerCounterState> State;

        public Effects(IState<TimerCounterState> state)
        {
            State = state;
        }


        [EffectMethod]
        public Task Handle(StartCountingAction _, IDispatcher dispatcher)
        {
            dispatcher.Dispatch(new IncrementCountAction());
            return Task.CompletedTask;
        }


        [EffectMethod]
        public async Task HandleAsync(IncrementCountAction _, IDispatcher dispatcher)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            if (State.Value.IsCounting) dispatcher.Dispatch(new IncrementCountAction());
        }
    }
}
