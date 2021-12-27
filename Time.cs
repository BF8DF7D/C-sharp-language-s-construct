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

            const int hour = 0,
                minutes = 1;

            const int Minimum_value_for_all = 0,
                Maximum_hour = 23,
                Maximum_minutes = 59;

            False_input_value = (time[hour] < Minimum_value_for_all || time[hour] > Maximum_hour)
                || (time[minutes] < Minimum_value_for_all || time[minutes] > Maximum_minutes);
            if (False_input_value)
                return False_input_value;

            formatTime = $"{time[hour]:d2}:{time[minutes]:d2}";
            this.hour = time[hour];
            this.minutes = time[minutes];
            return False_input_value;
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
