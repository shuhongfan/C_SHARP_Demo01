using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class sy3_3
    {
        static void Main(string[] args)
        {
            Time time1 = new Time(1,42,16);
            Time time2 = new Time(2,26,52);
            Time result = time1 + time2;
            Console.Write("{0}时:{1}分:{2}秒+{3}时:{4}分:{5}秒=", time1.Hours, time1.Minutes, time1.Seconds, time2.Hours, time2.Minutes, time2.Seconds);
            Console.WriteLine("{0}时:{1}分:{2}秒", result.Hours, result.Minutes, result.Seconds);

        }
    }

    class Time
    {
        private int hours=0,minutes=0, seconds=0;

        public Time(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public Time()
        {
        }

        public int Hours
        {
            get => hours;
            set => hours = value;
        }

        public int Minutes
        {
            get => minutes;
            set => minutes = value;
        }

        public int Seconds
        {
            get => seconds;
            set => seconds = value;
        }

        public static Time operator +(Time time1, Time time2)
        {
            Time result = new Time();
            result.seconds = time1.seconds + time2.seconds;
            result.minutes = time1.minutes + time2.minutes;
            result.hours = time1.hours + time2.hours + result.minutes/60;

            result.seconds = result.seconds % 60;
            result.minutes=result.minutes% 60;
            return result;
        }
    }
}
