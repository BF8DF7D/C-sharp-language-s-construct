using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_labN6
{
    class Doctor
    {
        private FIO fio;
        private string dolgnost;
        internal FIO Fio
        {
            get => fio;
        }


        public void SetDoctor()
        {
            fio = new FIO();
            Console.WriteLine(" <Ввод информации о докторе>");
            fio.SetFormat();
            Console.Write(" Должность: ");
            dolgnost = Console.ReadLine();
            Console.WriteLine(" <Ввод завершён>");
        }
        public void PrintInfo()
        {
            Console.WriteLine($"| {GetFIO().GetFullName(), 45} | {GetDolgnost(), 20} |");
        }

        public Talon CreateTalon()
        {
            Talon newtalon = new();
            newtalon.SetTalon(this);
            return newtalon;
        }
        public FIO GetFIO()
        {
            return fio;
        }
        public string GetDolgnost()
        {
            return dolgnost;
        }

        public Doctor()
        {
            fio = null;
        }
    }
}
