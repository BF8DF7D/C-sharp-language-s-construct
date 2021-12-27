using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_labN6
{
    class Date
    {
        private int day,
          mounth,
            year;
        private string formatDate;

        public void SetFormat()
        {
            bool False_Input_Value;
            do
            {
                Console.Write(" Дата: ");
                False_Input_Value = SetBool();
                if (False_Input_Value)
                    Console.WriteLine("\n <Дата введена некорректно>");
            } while (False_Input_Value);
        }
        public bool SetBool()
        {
            bool False_input_value = false;

            string[] input_values = Console.ReadLine().Split(".");
            const int Quantity_input_value = 3;
            False_input_value = input_values.Length != Quantity_input_value;
            if (False_input_value)
                return False_input_value;

            int[] date = new int[3];
            int input_number = 0;
            foreach (string value in input_values)
            {
                try
                {
                    date[input_number++] = Convert.ToInt32(value);
                }
                catch (Exception e)
                {
                    False_input_value = true;
                    return False_input_value;
                }
            }

            const int day = 0,
                mounth = 1,
                year = 2;

            const int Minimum_for_days_and_months = 0,
                Maximum_day = 31,
                Maximum_mounth = 12,
                Minimum_value_for_years = 999,
                Maximum_years = 9999;

            False_input_value = (date[day] <= Minimum_for_days_and_months || date[day] > Maximum_day)
                || (date[mounth] <= Minimum_for_days_and_months || date[mounth] > Maximum_mounth)
                || (date[year] <= Minimum_value_for_years || date[year] > Maximum_years);
            if (False_input_value)
                return False_input_value;

            formatDate = $"{date[day]:d2}.{date[mounth]:d2}.{date[year]}";
            this.day = date[day];
            this.mounth = date[mounth];
            this.year = date[year];

            return False_input_value;
        }

        public int GetDay()
        {
            return day;
        }
        public int GetMounth()
        {
            return mounth;
        }
        public int GetYear()
        {
            return year;
        }
        public string GetFormatDate()
        {
            return formatDate;
        }

        public Date()
        {
            day = -1;
            mounth = -1;
            year = -1;
        }
    }
}
