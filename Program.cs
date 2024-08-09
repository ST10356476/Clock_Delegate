using Clock;
using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            Display display = new Display();

            display.Subscribe(clock);

            clock.Start();

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
            clock.Stop();
        }
    }

}