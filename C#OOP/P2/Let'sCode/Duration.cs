using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_sCode
{
    internal class Duration : IComparable
    {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }
        private int totalSeconds;
   
        public Duration()
        {
            Hours = Minutes = Seconds = 0;
        }
        public Duration(int _hours, int _minutes, int _seconds)
        {
            Hours = _hours; Minutes = _minutes; Seconds = _seconds;
            totalSeconds = Hours * 3600 + Minutes * 60 + Seconds * 60;

        }
        public Duration(int _seconds)
        {
            Hours = _seconds / 3600;
            Minutes = (_seconds % 3600) / 60;
            Seconds = (_seconds % 3600) % 60;
            totalSeconds = Hours * 3600 + Minutes * 60 + Seconds * 60;
        }
        public static Duration operator +(Duration D1, Duration D2)
        {

            return new Duration(D1.totalSeconds + D2.totalSeconds);
        }
        public static Duration operator +(Duration D1, int _seconds)
        {

            return new Duration(D1.totalSeconds + _seconds);
        }
        public static Duration operator +(int _seconds, Duration D1)
        {

            return new Duration(D1.totalSeconds + _seconds);
        }
        public static Duration operator -(Duration D1, Duration D2)
        {
            return new Duration(D1.totalSeconds - D2.totalSeconds);
        }
        public static Duration operator ++(Duration D)
        {
            return new Duration(D.totalSeconds + 60);
        }
        public static Duration operator --(Duration D)
        {
            return new Duration(D.totalSeconds - 60);
        }
        public static bool operator <(Duration D1, Duration D2)
        {
            return D1.totalSeconds < D2.totalSeconds;
        }
        public static bool operator <=(Duration D1, Duration D2)
        {
            return D1.totalSeconds <= D2.totalSeconds;
        }
        public static bool operator >(Duration D1, Duration D2)
        {
            return D1.totalSeconds > D2.totalSeconds;
        }
        public static bool operator >=(Duration D1, Duration D2)
        {
            return D1.totalSeconds >= D2.totalSeconds;
        }
        public static explicit operator DateTime(Duration D)
        {
            return new DateTime().AddSeconds(D.totalSeconds);
        }
        public static implicit operator bool(Duration D)
        {
            return D.totalSeconds != 0;
        }
        public override string ToString()
        {
            if (Hours != 0)
                return $"Hours:{Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
            else
                return $"Minutes :{Minutes}, Seconds :{Seconds}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is not Duration)
                return false;
            else
            {
                Duration D = (Duration)obj;
                return Hours == D.Hours && Minutes == D.Minutes && Seconds == D.Seconds;
            }

        }
        public override int GetHashCode()
        {
            return Hours.GetHashCode() ^ Minutes.GetHashCode() ^ Seconds.GetHashCode();
        }

        public int CompareTo(object? obj)
        {
            Duration D = (Duration)obj;
            if (Hours > D.Hours)
                return 1;
            if (Hours < D.Hours)
                return -1;
            if (Hours == D.Hours)
            {
                if (Minutes > D.Minutes)
                    return 1;
                if (Minutes < D.Minutes)
                    return -1;
            }
            if (Minutes == D.Minutes)
            {
                if (Seconds > D.Seconds)
                    return 1;
                if (Seconds < D.Seconds)
                    return -1;
            }
            return 0;
        }
    }
}
