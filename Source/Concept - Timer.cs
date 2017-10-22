public static class Time
    {
        private static Timer increaseTimer;
        public static int year = 2068;
        public static int month = 1;
        public static int day = 1;
        public static int hour = 8;
        public static int minute = 0;
        public static void Activate()
        {
            increaseTimer = new Timer();
            increaseTimer.Interval = 1000;
            increaseTimer.Elapsed += TimeIncrease;
            increaseTimer.AutoReset = true;
            increaseTimer.Enabled = true;
        }
        private static void TimeIncrease(object source, ElapsedEventArgs e)
        {
            minute++;
            if (minute == 60)
            {
                hour++;
                minute = 0;
            }
            if (hour == 24)
            {
                day++;
                hour = 0;
            }
            if (day == 31)
            {
                month++;
                day = 1;
            }
            if (month == 12)
            {
                year++;
                month = 0;
            }           
        }
    }