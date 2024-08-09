using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public class TimeInfoEventArgs : EventArgs
    {
        public int Hour { get; }
        public int Minute { get; }
        public int Second { get; }

        public TimeInfoEventArgs(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
    }
}
