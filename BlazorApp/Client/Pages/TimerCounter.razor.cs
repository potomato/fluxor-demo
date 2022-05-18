using Microsoft.AspNetCore.Components;

namespace BlazorApp.Client.Pages;

public partial class TimerCounter : ComponentBase, IDisposable
{
    private int currentCount = 0;
    private bool disposedValue;
    private readonly static TimeSpan period = TimeSpan.FromSeconds(1);
    private Timer timer;

 
    public TimerCounter()
    {
        timer = new Timer(OnTimer, null, Timeout.InfiniteTimeSpan, Timeout.InfiniteTimeSpan);
    }

    private void OnTimer(object state)
    {
        IncrementCount();
    }

    private void IncrementCount()
    {
        currentCount++;
        Console.WriteLine($"CurrentCount now {currentCount}");
    }

    private void StartCounting()
    {
        timer.Change(TimeSpan.Zero, period);
    }

    private void StopCounting()
    {
        timer.Change(Timeout.InfiniteTimeSpan, Timeout.InfiniteTimeSpan);
    }


    #region Disposable implementation
    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                timer.Dispose();
            }

            disposedValue = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
    #endregion
}