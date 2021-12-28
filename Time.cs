using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_labN6
{
    class Time
    {
        private int hour,
            minutes;
        private string formatTime;

        internal int Hour
        {
            get => hour;
            set => hour = value;
        }
        internal int Minutes
        {
            get => minutes;
            set => minutes = value;
        }
        internal string FormatTime
        {
            get => formatTime;
            set => formatTime = value;
        }
        public void SetFormat()
        {
            bool False_Input_Value;
            do
            {
                Console.Write(" Время: ");
                False_Input_Value = SetBool();
                if (False_Input_Value)
                    Console.WriteLine("\n <Время введено некорректно>");
            } while (False_Input_Value);
        }
        public bool SetBool()
        {
            bool False_input_value = false;

            string[] input_values = Console.ReadLine().Split(".");
            const int Quantity_input_value = 2;
            False_input_value = input_values.Length != Quantity_input_value;
            if (False_input_value)
                return False_input_value;

            int[] time = new int[2];
            int input_number = 0;
            foreach (string value in input_values)
            {
                try 
                {
                    time[input_number++] = Convert.ToInt32(value);
                } catch (Exception e)
                {
                    False_input_value = true;
                    return False_input_value;
                }
            }

            int hour = time[0],
                minutes = time[1];

            const int Minimum_value_for_all = 0,
                Maximum_hour = 23,
                Maximum_minutes = 59;

            False_input_value = (hour < Minimum_value_for_all || hour > Maximum_hour)
                || (minutes < Minimum_value_for_all || minutes > Maximum_minutes);
            if (False_input_value)
                return False_input_value;

            formatTime = $"{hour:d2}:{minutes:d2}";
            this.hour = hour;
            this.minutes = minutes;
            return False_input_value;
        }
        public void ChangeTime(int[] changing_values,Date date)
        {
            int input_hours = changing_values[0],
                input_minutes = changing_values[1];

            const int Quantity_minutes_for_hour = 60,
                Quantity_hours_for_days = 24,
                Quantity_days_for_mounths = 31,
                Quantity_mounth_for_year = 12;

            minutes += input_minutes;
            hour += minutes / Quantity_minutes_for_hour;
            hour += input_hours;
            minutes %= Quantity_minutes_for_hour;

            date.Day += hour / Quantity_hours_for_days;
            hour %= Quantity_hours_for_days;
            date.Mounth += date.Day / Quantity_days_for_mounths;
            date.Mounth %= Quantity_days_for_mounths;
            date.Year += date.Mounth / Quantity_mounth_for_year;


            formatTime = $"{hour:d2}:{minutes:d2}";
            date.FormatDate = $"{date.Day:d2}.{date.Mounth:d2}.{date.Year}";
        }

        public int[] GetAllInfo()
        {
            int[] info = { hour, minutes };
            return info;
        }
        public int GetHour()
        {
            return hour;
        }
        public int GetMinutes()
        {
            return minutes;
        }
        public string GetFormatTime()
        {
            return formatTime;
        }
        public Time()
        {
            hour = -1;
            minutes = -1;
        }
    }
}
