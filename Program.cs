using System;

namespace zadanie_labN6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Disease prosrtuda = new("Простуда"),
            otravlenie = new("Отравление");

            Console.WriteLine($" Есть заболевание №1       : {prosrtuda.GetName()}");
            Console.WriteLine($" И есть заболевание №2     : {otravlenie.GetName()}");
            otravlenie = prosrtuda;
            Console.WriteLine($" Копия №1 в №2             : {otravlenie.GetName()}\n");
            Console.WriteLine($" Изменёним значение №1 на  : Заболевание");
            prosrtuda.SetName("Заболевание");
            Console.WriteLine($" Изменённое значение №1    : {prosrtuda.GetName()}");
            Console.WriteLine($" Значение №2               : {otravlenie.GetName()}\n");

            RefOutTest Test = new RefOutTest();
            int uref = 0;
            int uout;
            Test.UseOut(out uout);
            Console.WriteLine($" Значение uout после метода : {uout}");
            Test.UseRef(ref uref);

            Doctor doctor = new Doctor();
            doctor.SetDoctor();
            Console.WriteLine();
            doctor.PrintInfo();
            Console.WriteLine("\n");
            doctor.Fio.Last = "Демидов";
            doctor.Fio.Patronynic = "Сергеевич";
            Console.WriteLine($"ФИО доктора [изменённое]: {doctor.Fio.Full}\n");

            Console.WriteLine("\n");

            Talon talon = doctor.CreateTalon();
            talon.PrintInfo();
            Console.WriteLine();
            Talon sumtime = talon + "23.23";
            if (sumtime != null)
                sumtime.PrintInfo();
            Console.WriteLine();
            (talon++).PrintInfo();
            Console.WriteLine();
            (++talon).PrintInfo();
            Console.WriteLine("\n");

            prosrtuda.SetDisease();
            Console.WriteLine();
            otravlenie.SetDisease();
            Console.WriteLine();
            prosrtuda.PrintInfo();

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
