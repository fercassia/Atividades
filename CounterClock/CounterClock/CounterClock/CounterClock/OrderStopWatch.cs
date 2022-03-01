using System;

namespace CounterClock.CounterClock
{
    public class OrderStopWatch
    {
        private string _userChoice;
        private bool _start = false;
        private readonly StopWatch _stopWatch = new StopWatch();

        public void Choices(string userChoice)
        {
            _userChoice = userChoice;

            if (_userChoice.Equals("s"))
            {
                if (_start.Equals(true))
                {
                    throw new InvalidOperationException("\nThe StopWatch is already started");
                }
                _stopWatch.Start();
                _start = true;
            }

            if (_userChoice.Equals("r") && _start.Equals(false))
            {
                _stopWatch.Restart();
            }

            if (_userChoice.Equals("p"))
            {
                if (_start.Equals(false))
                {
                    throw new InvalidOperationException("\nThe StopWatch is already stopped");
                }
                _stopWatch.Pause();
                _start = false;
            }
        }
    }
}
