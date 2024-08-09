using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{

    public class Display
    {
        public void Subscribe(Clock clock)
        {
            clock.SecondChanged += TimeHasChanged;
        }

        private void TimeHasChanged(object sender, TimeInfoEventArgs e)
        {
            Console.WriteLine($"Current Time: {e.Hour:D2}:{e.Minute:D2}:{e.Second:D2}");
        }
    }
}
