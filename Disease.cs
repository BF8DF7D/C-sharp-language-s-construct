using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_labN6
{
    class Disease
    {
        private string Name_Disease;
        private string[] Disease_Symptoms;

        public void SetDisease() 
        {
            Console.WriteLine(" <Ввод информации о заболевании>");
            Console.Write(" Наименование: ");
            Name_Disease = Console.ReadLine();

            Console.WriteLine(" Симптомы.\n Вводите каждый новый симптом с новой строки.\n Для прекращения операции нажмите Enter");

            for(int input_value_number = 0; input_value_number < 50; input_value_number++) {
                Console.Write(" : ");
                Disease_Symptoms[input_value_number] = Console.ReadLine();
                if (Disease_Symptoms[input_value_number] == "")
                    break;
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine($" Наименование: {GetName()}");
            Console.WriteLine(" Симптомы: ");
            string[] disease_simptoms = GetSymptoms();
            int Output_value_number = 0;
            foreach (string symptom in disease_simptoms)
            {
                if (symptom == "")
                    break;
                Console.WriteLine($" [{++Output_value_number:d2}] {symptom}");
            }
        }
        
        public string GetName() 
        {
            return Name_Disease;
        }
        public string[] GetSymptoms()
        {
            return Disease_Symptoms;
        }
        public Disease()
        {
            Disease_Symptoms = new string[51];
        }
    }
}
