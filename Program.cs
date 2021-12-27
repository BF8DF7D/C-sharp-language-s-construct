using System;

namespace zadanie_labN6
{
    class Program
    {
        static void Main(string[] args)
        {

            Disease prosrtuda = new Disease(),
            otravlenie = new Disease();

            prosrtuda.SetDisease();
            Console.WriteLine();
            otravlenie.SetDisease();
            Console.WriteLine();
            prosrtuda.PrintInfo();

            Console.WriteLine("\n");

            Doctor doctor = new Doctor();
            doctor.SetDoctor();
            Console.WriteLine();
            doctor.PrintInfo();

            Console.WriteLine("\n");

            Talon talon = new Talon();
            talon.SetTalon(doctor);
            Console.WriteLine();
            talon.PrintInfo();

            Console.WriteLine("\n");

            Diagnosis one = new Diagnosis(),
            two = new Diagnosis();
            one.SetDiadnosis(talon, prosrtuda);
            two.SetDiadnosis(talon, otravlenie);
            two.PrintInfo();

            Console.WriteLine("\n");

            Patient bolnoi = new Patient();
            bolnoi.SetPacient();
            Console.WriteLine();

            bolnoi.GiveDiagnosis(one);
            bolnoi.GiveDiagnosis(two);

            bolnoi.PrintInfo();

            Console.WriteLine(); 
            bolnoi.DeleteDiagnosis(0);
            bolnoi.PrintInfo();

            Console.WriteLine("\n");

            string Name_Disease;
            Console.WriteLine(" Введите наименования болезни, чтобы узнать есть ли оно в истории болезни пациента");
            for (bool Exid_Value = false; !Exid_Value;)
            {
                Console.Write(" Наименование : ");
                Name_Disease = Console.ReadLine();
                if (Name_Disease == "")
                    Exid_Value = true;
                else
                {
                    if (bolnoi.DiseaseOf(Name_Disease))
                        Console.WriteLine($" В истории болезни пациента есть \"{Name_Disease}\"");
                    else
                        Console.WriteLine($" В истории блезни пациента не числится \"{Name_Disease}\"");
                }
            }

            Console.WriteLine("\n");

            bolnoi.DeleteAll();
            bolnoi.PrintInfo();

            Console.ReadKey();

        }
    }
}
