using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_labN6
{
    class FIO
    {
        
        private string last_name,
            first_name,
            patronynic,
            full_name;

        public bool SetBool()
        {

            bool False_input_value = true;

            full_name = Console.ReadLine();
            string[] name_elements = full_name.Split(" ");
            const int Quantity_input_values = 3; 
            False_input_value = name_elements.Length != Quantity_input_values;
            if (False_input_value)
                return False_input_value;
                
            const int last_name = 0,
            first_name = 1,
            patronynic = 2;

            this.last_name = name_elements[last_name];
            this.first_name = name_elements[first_name];
            this.patronynic = name_elements[patronynic];
            return False_input_value;
        }
        public void SetFormat()
        {
            bool False_input_value;
            do
            {
                Console.Write(" ФИО: ");
                False_input_value = SetBool();
                if (False_input_value)
                    Console.WriteLine("\n <ФИО введено некорректно>");
            } while (False_input_value);
        }

        public string GetLastName()
        {
            return last_name;
        }
        public string GetFisrstName()
        {
            return first_name;
        }
        public string GetPatonynic()
        {
            return patronynic;
        }
        public string GetFullName()
        {
            return full_name;
        }

        public FIO()
        {

        }
    };
}

