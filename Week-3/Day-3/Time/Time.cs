namespace Time
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes + seconds / 60;
            Seconds = seconds % 60;
        }

        public Duration(int seconds)
        {
            Hours = seconds / 3600;
            Minutes = (seconds % 3600) / 60;
            Seconds = seconds % 60;
        }

        public override string ToString()
        {
            return $"{Hours}H:{Minutes}M:{Seconds}S";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Duration duration)
            {
                return Hours == duration.Hours && Minutes == duration.Minutes && Seconds == duration.Seconds;
            }

            return false;
        }

        public static Duration operator +(Duration duration1, Duration duration2)
        {
            return new Duration(duration1.Hours + duration2.Hours, duration1.Minutes + duration2.Minutes, duration1.Seconds + duration2.Seconds);
        }

        public static Duration operator +(int seconds, Duration duration)
        {
            return new Duration(duration.Hours, duration.Minutes, duration.Seconds + seconds);
        }

        public static Duration operator -(Duration duration1, Duration duration2)
        {
            return new Duration(duration1.Hours - duration2.Hours, duration1.Minutes - duration2.Minutes, duration1.Seconds - duration2.Seconds);
        }

        public static Duration operator -(int seconds, Duration duration)
        {
            return new Duration(duration.Hours, duration.Minutes, duration.Seconds - seconds);
        }

        public static bool operator ==(Duration duration1, Duration duration2)
        {
            return duration1.Equals(duration2);
        }

        public static bool operator !=(Duration duration1, Duration duration2)
        {
            return !duration1.Equals(duration2);
        }

        public static bool operator >(Duration duration1, Duration duration2)
        {
            return duration1.Hours > duration2.Hours || duration1.Hours == duration2.Hours && (duration1.Minutes > duration2.Minutes || duration1.Minutes == duration2.Minutes && duration1.Seconds > duration2.Seconds);
        }

        public static bool operator <(Duration duration1, Duration duration2)
        {
            return duration1.Hours < duration2.Hours || duration1.Hours == duration2.Hours && (duration1.Minutes < duration2.Minutes || duration1.Minutes == duration2.Minutes && duration1.Seconds < duration2.Seconds);
        }

        public static bool operator >=(Duration duration1, Duration duration2)
        {
            return duration1.Hours > duration2.Hours || duration1.Hours == duration2.Hours && (duration1.Minutes > duration2.Minutes || duration1.Minutes == duration2.Minutes && duration1.Seconds >= duration2.Seconds);
        }

        public static bool operator <=(Duration duration1, Duration duration2)
        {
            return duration1.Hours < duration2.Hours || duration1.Hours == duration2.Hours && (duration1.Minutes < duration2.Minutes || duration1.Minutes == duration2.Minutes && duration1.Seconds <= duration2.Seconds);
        }

        public static Duration operator ++(Duration duration)
        {
            return new Duration(duration.Hours, duration.Minutes + 1, duration.Seconds);
        }

        public static Duration operator --(Duration duration)
        {
            return new Duration(duration.Hours, duration.Minutes - 1, duration.Seconds);
        }
    }
}