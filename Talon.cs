using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_labN6
{
    class Talon : ICloneable
    {
        private Date Admission_Date;
        private Time Admission_Time;
        private int kabinet;
        private Doctor medic;

        
        public void SetTalon(Doctor doctor)
        {
            Admission_Date = new Date();
            Admission_Time = new Time();

            bool False_Input_Value;

            Console.WriteLine(" <Ввод информации о талоне>");
            Admission_Date.SetFormat();
            Admission_Time.SetFormat();

            do
            {
                Console.Write(" Номер кабинета: ");
                False_Input_Value = SetBool();
                if (False_Input_Value)
                    Console.WriteLine("\n <Номер кабинета введен некорректно>");
            } while (False_Input_Value);

            medic = doctor;

            Console.WriteLine(" <Ввод завершён>");
        }
        private bool SetBool()
        {
            bool False_input_value = false;

            string[] input_values = Console.ReadLine().Split(" ");
            const int Quantity_input_value = 1;
            False_input_value = input_values.Length != Quantity_input_value;
            if (False_input_value)
                return False_input_value;
            try
            {
                kabinet = Convert.ToInt32(input_values[0]);
            } catch(Exception e)
            {
                False_input_value = true;
                return False_input_value;
            }

            const int Minimum_value = 0,
                Maximum_value = 500;
            False_input_value = kabinet < Minimum_value || kabinet > Maximum_value;
            return False_input_value;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"| {medic.Fio.Full, 45} | {Admission_Date.FormatDate} | {Admission_Time.FormatTime} | {kabinet, 3}|"); 
        }

        public static Talon operator+(Talon talon, string time)
        {
            string[] input_values = time.Split(".");
            const int Quantity_input_value = 2;
            bool False_input_value = input_values.Length != Quantity_input_value;
            if (False_input_value)
                return null;
            Talon value = (Talon)talon.Clone();
            int[] inttime = new int[2];
            int value_number = 0;

            foreach (string string_value in input_values) 
                try
                {
                    inttime[value_number++] = Convert.ToInt32(string_value);
                }
                catch (Exception e)
                {
                    return null;
                }

            value.Admission_Time.ChangeTime(inttime, value.Admission_Date);

            return value;
        }

        public static Talon operator ++(Talon talon)
        {
            return new Talon
            {
                Admission_Time = talon.Admission_Time,
                Admission_Date = talon.Admission_Date,
                kabinet = talon.kabinet + 1,
                medic = talon.medic
            };
        }
        public Date GetDate()
        {
            return Admission_Date;
        }
        public Time GetTime()
        {
            return Admission_Time;
        }
        public int GetKabinet()
        {
            return kabinet;
        }
        public Doctor GetDoctor()
        {
            return medic;
        }
        public Talon()
        {
            Admission_Date = null;
            Admission_Time = null;
            medic = null;
        }
        public object Clone()
        {
            Time Time_for_admission = new()
            {
                Hour = this.Admission_Time.Hour,
                Minutes = this.Admission_Time.Minutes,
                FormatTime = this.Admission_Time.FormatTime
            };
            Date Date_for_admission = new()
            {
                Day = this.Admission_Date.Day,
                Mounth = this.Admission_Date.Mounth,
                Year = this.Admission_Date.Year,
                FormatDate = this.Admission_Date.FormatDate
            };
            return new Talon
            {
                Admission_Date = Date_for_admission,
                Admission_Time = Time_for_admission,
                kabinet = this.kabinet,
                medic = this.medic
            };
        }
    }
}
