using System;

namespace CounterClock.CounterClock
{
    public class StopWatch : ICounterClock
    {
        private TimeSpan _timeStart;
        private TimeSpan _timePause;
        private TimeSpan _totalTimeElapsed;

        private const double _millisecondsForSeconds = 1000;

        public TimeSpan Start()
        {
            this._timeStart = DateTime.Now.TimeOfDay;
            Console.WriteLine("\nstart time: " + _timeStart);

            return _timeStart;
        }

        public TimeSpan Pause()
        {
            this._timePause = DateTime.Now.TimeOfDay;
            Console.WriteLine("Pause Time: " + _timePause);

            var totalTimeElapsed = Math.Round((this._timePause - this._timeStart).TotalMilliseconds / _millisecondsForSeconds, 3);
            this._totalTimeElapsed = TimeSpan.FromSeconds(totalTimeElapsed);

            Console.WriteLine($"\nTime elapsed: {_totalTimeElapsed} sec");

            return _totalTimeElapsed;
        }

        public TimeSpan Restart()
        {
            this._timeStart = default;
            this._timePause = default;
            Console.WriteLine($"\nRestart: {_timeStart}");

            return _timeStart;
        }
    }
}
