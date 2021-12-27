using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_labN6
{
    class Pasport
    {
        private int series,
            number;
        private string formatPasport;

        public void SetFormat()
        {
            bool False_Input_Value;
            do
            {
                Console.Write(" Паспорт: ");
                False_Input_Value = SetBool();
                if (False_Input_Value)
                    Console.WriteLine("\n <Паспортные данные введены некорректно>");
            } while (False_Input_Value);
        }
        public bool SetBool()
        {
            bool False_input_value = false;
            string[] input_values = Console.ReadLine().Split(" ");
            const int Quantity_input_value = 2;
            False_input_value = input_values.Length != Quantity_input_value;
            if (False_input_value)
                return False_input_value;

            int[] pasport = new int[2];
            int input_number = 0;
            foreach (string value in input_values)
            {
                try
                {
                    pasport[input_number++] = Convert.ToInt32(value);
                }
                catch (Exception e)
                {
                    False_input_value = true;
                    return False_input_value;
                }
            }
            const int series = 0,
                number = 1;

            const int Minimum_value_for_all = 0,
                Maximum_for_series = 9999,
                Maximum_for_number = 999999;

            False_input_value = (pasport[series] <= Minimum_value_for_all || pasport[series] > Maximum_for_series)
                || (pasport[number] <= Minimum_value_for_all || pasport[number] > Maximum_for_number);
            if (False_input_value)
                return False_input_value;

            formatPasport= $"{pasport[series]:d4} {pasport[number]:d6}";
            this.series = pasport[series];
            this.number = pasport[number];
            return False_input_value;
        }

        public int GetSeries()
        {
            return series;
        }
        public int GetNumber()
        {
            return number;
        }
        public string GetFormatPasport()
        {
            return formatPasport;
        }
        
        public Pasport()
        {
            series = -1;
            number = -1;
        }
    }
}
