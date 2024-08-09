using System;
using System.Timers;

namespace Clock
{
    public class Clock
    {
        private System.Timers.Timer _timer;

        public event EventHandler<TimeInfoEventArgs> SecondChanged;

        public Clock()
        {
            _timer = new System.Timers.Timer(1000); // 1-second intervals
            _timer.Elapsed += TimerElapsed;
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            OnSecondChanged(new TimeInfoEventArgs(hour, minute, second));
        }

        protected virtual void OnSecondChanged(TimeInfoEventArgs e)
        {
            SecondChanged?.Invoke(this, e);
        }
    }
}
