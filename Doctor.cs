using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_labN6
{
    class Doctor
    {
        private FIO Fio;
        private string dolgnost;

        public void SetDoctor()
        {
            Fio = new FIO();
            Console.WriteLine(" <Ввод информации о докторе>");
            Fio.SetFormat();
            Console.Write(" Должность: ");
            dolgnost = Console.ReadLine();
            Console.WriteLine(" <Ввод завершён>");
        }
        public void PrintInfo()
        {
            Console.WriteLine($"| {GetFIO().GetFullName(), 45} | {GetDolgnost(), 20} |");
        }

        public FIO GetFIO()
        {
            return Fio;
        }
        public string GetDolgnost()
        {
            return dolgnost;
        }

        public Doctor()
        {
            Fio = null;
        }
    }
}
