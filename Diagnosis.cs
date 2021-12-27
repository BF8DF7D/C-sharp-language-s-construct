using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_labN6
{
    class Diagnosis
    {
        private Talon talon;
        private Disease disease;

        public void SetDiadnosis(Talon coupon_of_patient, Disease disease_of_patient)
        {
            talon = coupon_of_patient;
            disease = disease_of_patient;
        }

        public void PrintInfo()
        {
            Console.WriteLine($" Доктор: {GetTalon().GetDoctor().GetFIO().GetFullName()}");
            Console.WriteLine($" Дата приёма: {GetTalon().GetDate().GetFormatDate()}");
            Console.WriteLine($" Время приёма: {GetTalon().GetTime().GetFormatTime()}");
            Console.WriteLine($" Номер кабинета: {GetTalon().GetKabinet()}");
            GetDisease().PrintInfo();
        }

        public Talon GetTalon()
        {
            return talon;
        }
        public Disease GetDisease()
        {
            return disease;
        }

        public Diagnosis()
        {
            talon = null;
            disease = null;
        }
    }
}
