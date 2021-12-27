using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_labN6
{
    class Talon
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
            Console.WriteLine($"| {GetDoctor().GetFIO().GetFullName(), 45} | {GetDate().GetFormatDate()} | {GetTime().GetFormatTime()} | {GetKabinet(), 3}|"); 
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
    }
}
